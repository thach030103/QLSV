using LAB04Nhom;
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

namespace LAB04
{
    public partial class frmLogin : Form
    {
        public static string username = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                 new CustomParameter()
                {
                    key = "@TENDN",
                    value= txtUserName.Text
                },
                  new CustomParameter()
                {
                    key = "@MATKHAU",
                    value = bytes(ComputeHash(txtPassword.Text, SHA1.Create()))
                },
            };

            try
            {
                var rs = new Database().SelectData("SP_LOGIN", lst);
                if (rs.Rows.Count > 0)
                {                
                    MessageBox.Show("Đăng nhập thành công");
                    if (!string.IsNullOrEmpty(txtUserName.Text) && chkRememberPass.Checked)
                    {
                        Properties.Settings.Default.UserName = txtUserName.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    username= txtUserName.Text;
                    frmManHinhQL frmManHinhQL = new frmManHinhQL();
                    frmManHinhQL.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ"); 
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
            }
        }
        private void chkRememberPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberPass.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text; 
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string savedUserName = Properties.Settings.Default.UserName;
            string savedPass = Properties.Settings.Default.Password;
            if (!string.IsNullOrEmpty(savedUserName))
            {
                txtUserName.Text = savedUserName;
                txtPassword.Text = savedPass;
                chkRememberPass.Checked = true;
            }
            else
            {
                chkRememberPass.Checked = false;
            }
        }
    }
}
