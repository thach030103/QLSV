using LAB04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB04Nhom
{
    public partial class frmManHinhQL : Form
    {
        public frmManHinhQL()
        {
            InitializeComponent();
        }
        private int modeGhiLuu = 0;
        private bool checkClickMK = false;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private string ComputeHash(string password, HashAlgorithm algorithm)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = algorithm.ComputeHash(passwordBytes);
            return "0x" + BitConverter.ToString(hashBytes).Replace("-", "");
        }
        // Hàm tạo public key và private key
        public static void GenerateRSAKey(string employeeId, out string publicKey, out string privateKey)
        {
            CspParameters cspParams = new CspParameters
            {
                KeyContainerName = $"KeyContainer_{employeeId}"
            };

            using (var rsa = new RSACryptoServiceProvider(512, cspParams))
            {
                publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
                privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));

                // Lưu khóa vào thư mục riêng biệt cho từng nhân viên
                Directory.CreateDirectory($"Keys/{employeeId}");
                File.WriteAllText($"Keys/{employeeId}/publickey.txt", publicKey);
                File.WriteAllText($"Keys/{employeeId}/privatekey.txt", privateKey);
            }
        }
        static string RSAEncrypt(string plainText, string publicKey)
        {
            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(plainText);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
            {
                rsa.ImportCspBlob(Convert.FromBase64String(publicKey));
                byte[] encryptedBytes = rsa.Encrypt(bytesToEncrypt, false);
                string encryptedText = Convert.ToBase64String(encryptedBytes);
                return "0x" + BitConverter.ToString(encryptedBytes).Replace("-", "");
            }
        }
        static string RSADecrypt(byte[] encryptedData, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(512))
            {
                rsa.ImportCspBlob(Convert.FromBase64String(privateKey));
                byte[] decryptedBytes = rsa.Decrypt(encryptedData, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
        private static string LoadPublicKeyFromFile(string employeeId)
        {
            return File.ReadAllText($"Keys/{employeeId}/publickey.txt");
        }
        private static string LoadPrivateKeyFromFile(string employeeId)
        {
            return File.ReadAllText($"Keys/{employeeId}/privatekey.txt");
        }
        private void loadDSNV()
        {
            // Lấy dữ liệu từ database
            string sql = "SP_SEL_ENCRYPT_NHANVIEN";
            List<CustomParameter> lst = new List<CustomParameter>();
            DataTable dt = new Database().SelectData(sql, lst);

            // Thêm cột mới để lưu giá trị được giải mã
            dt.Columns.Add("LUONG_DECRYPTED", typeof(string));

            // Duyệt qua từng DataRow để giải mã giá trị của cột "LUONG" và gán vào cột mới
            foreach (DataRow row in dt.Rows)
            {
                if (row["LUONG"] != DBNull.Value)
                {

                    byte[] encryptedData = (byte[])row["LUONG"];
                    string privateKey = LoadPrivateKeyFromFile(row["MANV"].ToString());
                    string decryptedData = RSADecrypt(encryptedData, privateKey);
                    row["LUONG_DECRYPTED"] = decryptedData;
                }

            }

            // Xóa cột "LUONG" cũ và đổi tên cột mới thành "LUONG"
            dt.Columns.Remove("LUONG");
            dt.Columns["LUONG_DECRYPTED"].ColumnName = "LUONG";

            // Hiển thị dữ liệu trên DataGridView
            dgvDSNV.DataSource = dt;
            dgvDSNV.Columns["MatKhau"].Visible = false;

            SetAllTextBoxToReadOnly();
        }
        private byte[] bytes(string hexString)
        {
            byte[] bytes = Enumerable.Range(2, hexString.Length - 2)
                          .Where(x => x % 2 == 0)
                          .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                          .ToArray();
            return bytes;
        }
        private void insertNV()
        {
            string sql = "SP_INS_PUBLIC_ENCRYPT_NHANVIEN";
            // Tạo khóa
            string publicKey, privateKey;
            GenerateRSAKey(txtMaNV.Text, out publicKey, out privateKey);

            // Đọc khóa từ các tệp
            publicKey = LoadPublicKeyFromFile(txtMaNV.Text);
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@MANV",
                value = txtMaNV.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@HOTEN",
                value = txtHoTen.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@EMAIL",
                value = txtEmail.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@LUONG",
                value = bytes(RSAEncrypt(txtLuong.Text, publicKey))
            });
            lst.Add(new CustomParameter()
            {
                key = "@TENDN",
                value = txtTenDangNhap.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@MATKHAU",
                value = bytes(ComputeHash(txtMatKhau.Text, SHA1.Create()))
            });
            lst.Add(new CustomParameter()
            {
                key = "@PUB",
                value = publicKey
            });
            var rs = new Database().ExeCute(sql, lst);
            if (rs == 1)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDSNV();
                modeGhiLuu = 0;
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void updateNV()
        {
            DataGridViewRow row = dgvDSNV.SelectedRows[0];
            string sql = "SP_UPD_NHANVIEN";
            // Tạo khóa
            string publicKey, privateKey;
            GenerateRSAKey(row.Cells["MANV"].Value.ToString(), out publicKey, out privateKey);

            // Đọc khóa từ các tệp
            publicKey = LoadPublicKeyFromFile(row.Cells["MANV"].Value.ToString());

            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@MANV",
                value = txtMaNV.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@HOTEN",
                value = txtHoTen.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@EMAIL",
                value = txtEmail.Text
            });
            lst.Add(new CustomParameter()
            {
                key = "@LUONG",
                value = bytes(RSAEncrypt(txtLuong.Text, publicKey))
            });
            lst.Add(new CustomParameter()
            {
                key = "@TENDN",
                value = txtTenDangNhap.Text
            });
            if (checkClickMK)
            {
                lst.Add(new CustomParameter()
                {
                    key = "@MATKHAU",
                    value = bytes(ComputeHash(txtMatKhau.Text, SHA1.Create()))
                });
            }
            else
            {
                lst.Add(new CustomParameter()
                {
                    key = "@MATKHAU",
                    value = row.Cells["MATKHAU"].Value
                });
            }
            lst.Add(new CustomParameter()
            {
                key = "@PUB",
                value = publicKey
            });
            var rs = new Database().ExeCute(sql, lst);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDSNV();
                modeGhiLuu = 0;
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmDSNV_Load(object sender, EventArgs e)
        {
            loadDSNV();
            LoadDSLH();
            lblCurNV.Text = frmLogin.username;
        }
        private void btnKhong_Click(object sender, EventArgs e)
        {
            loadDSNV();
        }
        public void SetAllTextBoxToReadOnly()
        {
            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            txtLuong.Enabled = false;
            txtMaNV.Enabled = false;
            txtMatKhau.Enabled = false;
            txtTenDangNhap.Enabled = false;
        }
        public void EnableEditAllTextBox()
        {
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            txtLuong.Enabled = true;
            txtMaNV.Enabled = true;
            txtMatKhau.Enabled = true;
            txtTenDangNhap.Enabled = true;
        }
        public void ClearAllTextBox()
        {
            txtEmail.Clear();
            txtHoTen.Clear();
            txtLuong.Clear();
            txtMaNV.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow row = dgvDSNV.SelectedRows[0];
                txtMaNV.Text = row.Cells["MANV"].Value.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtLuong.Text = row.Cells["LUONG"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TENDN"].Value.ToString();
                txtMatKhau.Text = row.Cells["MATKHAU"].Value.ToString();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool isConfirmed = false; // biến kiểm tra đã xác nhận xoá hay chưa
                                      // Duyệt qua các hàng đã chọn
            foreach (DataGridViewRow row in dgvDSNV.SelectedRows)
            {
                string manv = row.Cells["MANV"].Value.ToString();
                if (!isConfirmed) // Nếu chưa xác nhận xoá
                {
                    if (MessageBox.Show("Bạn có muốn xoá hay không?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return; // Không xoá nếu người dùng không xác nhận
                    }
                    isConfirmed = true; // Đã xác nhận xoá
                }
                string sql = "SP_DEL_NHANVIEN";
                // Xóa hàng đó từ cơ sở dữ liệu
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    key = "@MANV",
                    value = manv
                });
                var rs = new Database().ExeCute(sql, lst);
            }
            loadDSNV();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text =="")
            {
                loadDSNV();
            }
            EnableEditAllTextBox();
            txtMaNV.Enabled = false;
            txtEmail.Focus();
            modeGhiLuu = 2;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableEditAllTextBox();
            ClearAllTextBox();
            txtMaNV.Focus();
            modeGhiLuu = 1;
        }
        private void btnGhiLuu_Click(object sender, EventArgs e)
        {
            //Check các trường có bị empty hay không
            if (!CheckData())
            {
                return;
            }
            if (modeGhiLuu == 1)
            {
                insertNV();
            }
            else if (modeGhiLuu == 2)
            {
                updateNV();
            }
            else
            {
                return;
            }
        }
        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (!txtMatKhau.ReadOnly)
            {
                txtMatKhau.Clear();
                checkClickMK = true;
            }
        }
        //tab QLLH
        private void btnThoatLH_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private string tukhoa="";
        private void LoadDSLH()
        {
            string sql = "SP_SEL_LOP";
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            DataTable dt = new Database().SelectData(sql, lst);

            // Hiển thị dữ liệu trên DataGridView
            dgvQLLH.DataSource = dt;
        }
        private void btnTimKiemLH_Click(object sender, EventArgs e)
        {
            tukhoa=txtTimKiemLH.Text;
            LoadDSLH();
        }
        private void btnThemLH_Click(object sender, EventArgs e)
        {
            frmThemLH TL = new frmThemLH();
            TL.ShowDialog();
            LoadDSLH();
        }
        private void dgvQLLH_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvQLLH.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dgvQLLH.ClearSelection();
                    dgvQLLH.Rows[rowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvQLLH, e.X, e.Y);
                }
            }
        }
        private void sửaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvQLLH.SelectedRows[0].Index;
            string malop = dgvQLLH.Rows[rowIndex].Cells["MALOP"].Value.ToString();
            string manv = dgvQLLH.Rows[rowIndex].Cells["MANV"].Value.ToString();
            string tenlop = dgvQLLH.Rows[rowIndex].Cells["TENLOP"].Value.ToString();
            if (manv == frmLogin.username)
            {
                frmSuaLop SL = new frmSuaLop(malop, tenlop, manv);
                SL.ShowDialog();
                LoadDSLH();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sửa lớp này!");
            }
        }
        private void xóaLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvQLLH.SelectedRows[0].Index;
            string manv = dgvQLLH.Rows[rowIndex].Cells["MANV"].Value.ToString();
            string malop = dgvQLLH.Rows[rowIndex].Cells["MALOP"].Value.ToString();
            if (manv == frmLogin.username)
            {
                if (MessageBox.Show("Bạn có muốn xoá hay không?",
                          "Cảnh báo",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "SP_DEL_LOP";
                    // Xóa hàng đó từ cơ sở dữ liệu
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@MALOP",
                        value = malop
                    });
                    var rs = new Database().ExeCute(sql, lst);
                    LoadDSLH();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa lớp này!");
            }
            
        }
        private void xemDSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvQLLH.SelectedRows[0].Index;
            string malop = dgvQLLH.Rows[rowIndex].Cells["MALOP"].Value.ToString();
            string manv = dgvQLLH.Rows[rowIndex].Cells["MANV"].Value.ToString();
            frmDSSV frmDSSV = new frmDSSV(malop,manv);
            frmDSSV.Show();
            this.Hide();
        }
    }
}

