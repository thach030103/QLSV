using LAB04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04Nhom
{
    public partial class frmThemLH : Form
    {
        public frmThemLH()
        {
            InitializeComponent();
            txtMaNV.Text = frmLogin.username;
            txtMaNV.Enabled = false;
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenLop.Text != "")
            {
                string sql = "SP_INS_LOP";
                List<CustomParameter> lst = new List<CustomParameter>();
                lst.Add(new CustomParameter()
                {
                    key = "@MANV",
                    value = txtMaNV.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@MALOP",
                    value = txtMaLop.Text
                });
                lst.Add(new CustomParameter()
                {
                    key = "@TENLOP",
                    value = txtTenLop.Text
                });
                var rs = new Database().ExeCute(sql, lst);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Dispose();
        }
    }
}
