using LAB04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB04Nhom
{
    public partial class frmDSSV : Form
    {
        private string tukhoa = "";
        private string malop = "";
        private string manv = "";
        public frmDSSV(string malop,string manv)
        {
            InitializeComponent();
            this.malop = malop;
            this.manv = manv;
            LoadDSSV();
        }
        private void LoadDSSV()
        {
            string sql = "SP_CL_STU";
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            lst.Add(new CustomParameter()
            {
                key = "@MALOP",
                value = malop
            });
            DataTable dt = new Database().SelectData(sql, lst);

            // Hiển thị dữ liệu trên DataGridView
            dgvDSSV.DataSource = dt;
            dgvDSSV.Columns["MatKhau"].Visible = false;
        }
        private void dgvDSSV_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvDSSV.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dgvDSSV.ClearSelection();
                    dgvDSSV.Rows[rowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvDSSV, e.X, e.Y);
                }
            }
        }
        private void btnTimKiemDSSV_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiemDSSV.Text;
            LoadDSSV();
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (manv == frmLogin.username)
            {
                frmThemSV frmThemSV = new frmThemSV(malop);
                frmThemSV.ShowDialog();
                LoadDSSV();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thêm sinh viên trong lớp này");
            }
        }
        private void btnThoatDSSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManHinhQL frmManHinhQL = new frmManHinhQL();
            frmManHinhQL.Show();
            frmManHinhQL.tabQL.SelectedTab = frmManHinhQL.tbpQLLH;
        }

        private void xóaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDSSV.SelectedRows[0].Index;
            string masv = dgvDSSV.Rows[rowIndex].Cells["MASV"].Value.ToString();
            if (manv == frmLogin.username)
            {
                if (MessageBox.Show("Bạn có muốn xoá hay không?",
                          "Cảnh báo",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "SP_DEL_SINHVIEN";
                    // Xóa hàng đó từ cơ sở dữ liệu
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(new CustomParameter()
                    {
                        key = "@MASV",
                        value = masv
                    });
                    var rs = new Database().ExeCute(sql, lst);
                    LoadDSSV();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xóa sinh viên của lớp này!");
            }
        }

        private void sửaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDSSV.SelectedRows[0].Index;
            string masv = dgvDSSV.Rows[rowIndex].Cells["MASV"].Value.ToString();
            string hoten = dgvDSSV.Rows[rowIndex].Cells["HOTEN"].Value.ToString();
            DateTime ngaysinh = (DateTime)dgvDSSV.Rows[rowIndex].Cells["NGAYSINH"].Value;
            string diachi = dgvDSSV.Rows[rowIndex].Cells["DIACHI"].Value.ToString();
            string tendn = dgvDSSV.Rows[rowIndex].Cells["TENDN"].Value.ToString();
            object mk = dgvDSSV.Rows[rowIndex].Cells["MATKHAU"].Value;
            if (manv == frmLogin.username)
            {
                frmSuaSV frmSuaSV = new frmSuaSV(malop,masv,hoten,ngaysinh,diachi,tendn,mk);
                frmSuaSV.ShowDialog();
                LoadDSSV();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sửa sinh viên lớp này!");
            }
        }

        private void xemBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDSSV.SelectedRows[0].Index;
            string masv = dgvDSSV.Rows[rowIndex].Cells["MASV"].Value.ToString();
            frmBangDiem frmBangDiem = new frmBangDiem(malop,masv,manv);
            frmBangDiem.Show();
            this.Hide();
        }
    }
}
