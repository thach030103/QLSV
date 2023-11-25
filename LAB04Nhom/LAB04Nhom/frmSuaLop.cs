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
    public partial class frmSuaLop : Form
    {
        public frmSuaLop(string malop, string tenlop, string manv)
        {
            InitializeComponent();
            txtMaNV.Text = manv;
            txtTenLop.Text = tenlop;
            txtMaLop.Text = malop;
            txtMaLop.Enabled = false;
        }

        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "")
            {
                string sql = "SP_UPD_LOP";
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
                    MessageBox.Show("Sửa lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa lớp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
