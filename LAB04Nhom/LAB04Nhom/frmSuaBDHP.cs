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

namespace LAB04Nhom
{
    public partial class frmSuaBDHP : Form
    {
        private string masv = "";
        public frmSuaBDHP(string masv, string mahp,string tenhp, string sotc,string diem)
        {
            InitializeComponent();
            txtDiem.Text = diem;
            txtMaHP.Text = mahp;
            txtMaHP.Enabled = false;
            txtTenHP.Text = tenhp;
            txtSoTC.Text = sotc;
            this.masv= masv;
        }
        private static string LoadPublicKeyFromFile(string employeeId)
        {
            return File.ReadAllText($"Keys/{employeeId}/publickey.txt");
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
        private byte[] bytes(string hexString)
        {
            byte[] bytes = Enumerable.Range(2, hexString.Length - 2)
                          .Where(x => x % 2 == 0)
                          .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                          .ToArray();
            return bytes;
        }
        private void btnCNDiemHP_Click(object sender, EventArgs e)
        {
            float diemthi;
            bool isFloat = float.TryParse(txtDiem.Text, out diemthi);
            if (!isFloat || diemthi < 0 || diemthi > 10)
            {
                MessageBox.Show("Điểm thi phải là kiểu float và có giá trị từ 0 đến 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int sotc;
            bool isInt = int.TryParse(txtSoTC.Text, out sotc);
            if (!isInt)
            {
                MessageBox.Show("Số TC phải là kiểu int", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHP.Text != "" && txtTenHP.Text != "")
            {
                string sql = "SP_UPDATE_HOCPHAN_BANGDIEM";
                string publicKey = LoadPublicKeyFromFile(frmLogin.username);
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    key = "@MAHP",
                    value = txtMaHP.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@TENHP",
                    value = txtTenHP.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@SOTC",
                    value = sotc
                });
                lst.Add(new CustomParameter()
                {
                    key = "@MASV",
                    value = masv
                });
                lst.Add(new CustomParameter()
                {
                    key = "@DIEMTHI",
                    value = bytes(RSAEncrypt(txtDiem.Text, publicKey))
                });
                var rs = new Database().ExeCute(sql, lst);
                if (rs >= 1)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
