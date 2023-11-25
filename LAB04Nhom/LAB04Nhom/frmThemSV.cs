using LAB04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB04Nhom
{
    public partial class frmThemSV : Form
    {
        public frmThemSV(string malop)
        {
            InitializeComponent();
            txtMaLop.Text = malop;
            txtMaLop.Enabled = false;
        }
        private string ComputeHash(string password, HashAlgorithm algorithm)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = algorithm.ComputeHash(passwordBytes);
            return "0x" + BitConverter.ToString(hashBytes).Replace("-", "");
        }
        private byte[] bytes(string hexString)
        {
            byte[] bytes = Enumerable.Range(2, hexString.Length - 2)
                          .Where(x => x % 2 == 0)
                          .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                          .ToArray();
            return bytes;
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHoTen.Text != "" && txtTenDn.Text != "" && txtMK.Text != "")
            {
                string sql = "SP_INS_PUBLIC_ENCRYPT_SINHVIEN";
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    key = "@MASV",
                    value = txtMaSV.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@HOTEN",
                    value = txtHoTen.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@NGAYSINH",
                    value = dtpNgaySinh.Value.Date
                });
                lst.Add(new CustomParameter()
                {
                    key = "@DIACHI",
                    value = txtDiaChi.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@MALOP",
                    value = txtMaLop.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@TENDN",
                    value = txtTenDn.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@MATKHAU",
                    value = bytes(ComputeHash(txtMK.Text, MD5.Create()))
                });
                var rs = new Database().ExeCute(sql, lst);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
