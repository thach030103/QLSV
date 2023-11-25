namespace LAB04Nhom
{
    partial class frmSuaSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaSV));
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTenDn = new System.Windows.Forms.TextBox();
            this.lblTenDn = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.LblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnCapNhatSV = new System.Windows.Forms.Button();
            this.lblSuaSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(316, 355);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(290, 27);
            this.txtMaLop.TabIndex = 22;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Location = new System.Drawing.Point(78, 355);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(125, 29);
            this.lblMaLop.TabIndex = 6;
            this.lblMaLop.Text = "Mã lớp";
            this.lblMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(316, 235);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(290, 27);
            this.dtpNgaySinh.TabIndex = 20;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 4, 29, 11, 21, 59, 0);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(77, 235);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(125, 29);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(316, 475);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(290, 27);
            this.txtMK.TabIndex = 24;
            this.txtMK.Click += new System.EventHandler(this.txtMK_Click);
            // 
            // lblMK
            // 
            this.lblMK.Location = new System.Drawing.Point(78, 475);
            this.lblMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(125, 29);
            this.lblMK.TabIndex = 14;
            this.lblMK.Text = "Mật khẩu";
            this.lblMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDn
            // 
            this.txtTenDn.Location = new System.Drawing.Point(316, 415);
            this.txtTenDn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDn.Name = "txtTenDn";
            this.txtTenDn.Size = new System.Drawing.Size(290, 27);
            this.txtTenDn.TabIndex = 23;
            // 
            // lblTenDn
            // 
            this.lblTenDn.Location = new System.Drawing.Point(77, 415);
            this.lblTenDn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDn.Name = "lblTenDn";
            this.lblTenDn.Size = new System.Drawing.Size(125, 29);
            this.lblTenDn.TabIndex = 16;
            this.lblTenDn.Text = "Tên đăng nhập";
            this.lblTenDn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(392, 592);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(316, 115);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(290, 27);
            this.txtMaSV.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(316, 295);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 27);
            this.txtDiaChi.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(316, 175);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(290, 27);
            this.txtHoTen.TabIndex = 19;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(77, 295);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(125, 29);
            this.lblDiaChi.TabIndex = 17;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHoTen
            // 
            this.LblHoTen.Location = new System.Drawing.Point(77, 175);
            this.LblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHoTen.Name = "LblHoTen";
            this.LblHoTen.Size = new System.Drawing.Size(125, 29);
            this.LblHoTen.TabIndex = 15;
            this.LblHoTen.Text = "Họ tên";
            this.LblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSV
            // 
            this.lblMaSV.Location = new System.Drawing.Point(77, 115);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(125, 29);
            this.lblMaSV.TabIndex = 13;
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblMaSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhatSV
            // 
            this.btnCapNhatSV.Location = new System.Drawing.Point(183, 592);
            this.btnCapNhatSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatSV.Name = "btnCapNhatSV";
            this.btnCapNhatSV.Size = new System.Drawing.Size(107, 38);
            this.btnCapNhatSV.TabIndex = 25;
            this.btnCapNhatSV.Text = "Cập nhật";
            this.btnCapNhatSV.UseVisualStyleBackColor = true;
            this.btnCapNhatSV.Click += new System.EventHandler(this.btnCapNhatSV_Click);
            // 
            // lblSuaSV
            // 
            this.lblSuaSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaSV.Location = new System.Drawing.Point(0, 0);
            this.lblSuaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuaSV.Name = "lblSuaSV";
            this.lblSuaSV.Size = new System.Drawing.Size(682, 71);
            this.lblSuaSV.TabIndex = 3;
            this.lblSuaSV.Text = "SỬA SINH VIÊN";
            this.lblSuaSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSuaSV
            // 
            this.AcceptButton = this.btnCapNhatSV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.txtTenDn);
            this.Controls.Add(this.lblTenDn);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.LblHoTen);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.btnCapNhatSV);
            this.Controls.Add(this.lblSuaSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtTenDn;
        private System.Windows.Forms.Label lblTenDn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label LblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnCapNhatSV;
        private System.Windows.Forms.Label lblSuaSV;
    }
}