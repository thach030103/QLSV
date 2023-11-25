using LAB04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmBangDiem : Form
    {
        private string malop = "";
        private string masv = "";
        private string manv = "";
        private string tukhoa = "";
        public frmBangDiem(string malop, string masv,string manv)
        {
            InitializeComponent();
            this.malop = malop;
            this.masv = masv;
            this.manv = manv;
            LoadDSHP();
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
        private static string LoadPrivateKeyFromFile(string employeeId)
        {
            return File.ReadAllText($"Keys/{employeeId}/privatekey.txt");
        }

        private void LoadDSHP()
        {
            string sql = "SP_SEL_BANGDIEM";
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            lst.Add(new CustomParameter()
            {
                key = "@MANV",
                value = manv
            });
            lst.Add(new CustomParameter()
            {
                key = "@MASV",
                value = masv
            });
            DataTable dt = new Database().SelectData(sql, lst);
            // Thêm cột mới để lưu giá trị được giải mã
            dt.Columns.Add("DIEM_DECRYPTED", typeof(string));

            // Duyệt qua từng DataRow để giải mã giá trị của cột "LUONG" và gán vào cột mới
            foreach (DataRow row in dt.Rows)
            {
                if (row["DIEMTHI"] != DBNull.Value)
                {

                    byte[] encryptedData = (byte[])row["DIEMTHI"];
                    string privateKey = LoadPrivateKeyFromFile(manv);
                    string decryptedData = RSADecrypt(encryptedData, privateKey);
                    row["DIEM_DECRYPTED"] = decryptedData;
                }

            }
            // Xóa cột "LUONG" cũ và đổi tên cột mới thành "LUONG"
            dt.Columns.Remove("DIEMTHI");
            dt.Columns["DIEM_DECRYPTED"].ColumnName = "DIEMTHI";

            dgvBD.DataSource = dt;
        }
        private void btnTimKiemBD_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiemBD.Text; 
            LoadDSHP();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSSV frmDSSV = new frmDSSV(malop, manv);
            frmDSSV.Show();
        }

        private void btnThemHP_Click(object sender, EventArgs e)
        {
            if (manv == frmLogin.username)
            {
                frmThemHP frmThemHP = new frmThemHP(masv);
                frmThemHP.ShowDialog();
                LoadDSHP();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm dữ liệu trong lớp này");
            }
        }

        private void xóaĐiểmHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvBD.SelectedRows[0].Index;
            string mahp = dgvBD.Rows[rowIndex].Cells["MAHP"].Value.ToString();
            if (manv == frmLogin.username)
            {
                if (MessageBox.Show("Bạn có muốn xoá hay không?",
                          "Cảnh báo",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "SP_DELETE_HOCPHAN_BANGDIEM";
                    // Xóa hàng đó từ cơ sở dữ liệu
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@MASV",
                        value = masv
                    });
                    lst.Add(new CustomParameter()
                    {
                        key = "@MAHP",
                        value = mahp
                    });
                    var rs = new Database().ExeCute(sql, lst);
                    LoadDSHP();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xoá dữ liệu này!");
            }
        }

        private void sửaĐiểmHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvBD.SelectedRows[0].Index;
            string mahp = dgvBD.Rows[rowIndex].Cells["MAHP"].Value.ToString();
            string tenhp = dgvBD.Rows[rowIndex].Cells["TENHP"].Value.ToString();
            string sotc = dgvBD.Rows[rowIndex].Cells["SOTC"].Value.ToString();
            string diem = dgvBD.Rows[rowIndex].Cells["DIEMTHI"].Value.ToString();
            if (manv == frmLogin.username)
            {
                frmSuaBDHP frmSuaBDHP = new frmSuaBDHP(masv,mahp,tenhp,sotc,diem);
                frmSuaBDHP.ShowDialog();
                LoadDSHP();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sửa dữ liệu lớp này!");
            }
        }

        private void dgvBD_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvBD.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dgvBD.ClearSelection();
                    dgvBD.Rows[rowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvBD, e.X, e.Y);
                }
            }
        }
    }
}
