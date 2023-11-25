namespace LAB04Nhom
{
    partial class frmManHinhQL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhQL));
            this.tabQL = new System.Windows.Forms.TabControl();
            this.tbpQLNV = new System.Windows.Forms.TabPage();
            this.pnDSNV1 = new System.Windows.Forms.Panel();
            this.grpTTNV = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.pnDSNV2 = new System.Windows.Forms.Panel();
            this.pnDSNV3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhiLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.lblDMNV = new System.Windows.Forms.Label();
            this.tbpQLLH = new System.Windows.Forms.TabPage();
            this.lblCur = new System.Windows.Forms.Label();
            this.lblCurNV = new System.Windows.Forms.Label();
            this.dgvQLLH = new System.Windows.Forms.DataGridView();
            this.lblQLLH = new System.Windows.Forms.Label();
            this.btnTimKiemLH = new System.Windows.Forms.Button();
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnThoatLH = new System.Windows.Forms.Button();
            this.txtTimKiemLH = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDSSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQL.SuspendLayout();
            this.tbpQLNV.SuspendLayout();
            this.pnDSNV1.SuspendLayout();
            this.grpTTNV.SuspendLayout();
            this.pnDSNV2.SuspendLayout();
            this.pnDSNV3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.tbpQLLH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQL
            // 
            this.tabQL.Controls.Add(this.tbpQLNV);
            this.tabQL.Controls.Add(this.tbpQLLH);
            this.tabQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQL.Location = new System.Drawing.Point(12, 3);
            this.tabQL.Name = "tabQL";
            this.tabQL.SelectedIndex = 0;
            this.tabQL.Size = new System.Drawing.Size(1100, 600);
            this.tabQL.TabIndex = 0;
            // 
            // tbpQLNV
            // 
            this.tbpQLNV.Controls.Add(this.pnDSNV1);
            this.tbpQLNV.Controls.Add(this.pnDSNV2);
            this.tbpQLNV.Controls.Add(this.lblDMNV);
            this.tbpQLNV.Location = new System.Drawing.Point(4, 29);
            this.tbpQLNV.Name = "tbpQLNV";
            this.tbpQLNV.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQLNV.Size = new System.Drawing.Size(1092, 567);
            this.tbpQLNV.TabIndex = 0;
            this.tbpQLNV.Text = "Quản lý nhân viên";
            this.tbpQLNV.UseVisualStyleBackColor = true;
            // 
            // pnDSNV1
            // 
            this.pnDSNV1.BackColor = System.Drawing.SystemColors.Info;
            this.pnDSNV1.Controls.Add(this.grpTTNV);
            this.pnDSNV1.Location = new System.Drawing.Point(6, 72);
            this.pnDSNV1.Name = "pnDSNV1";
            this.pnDSNV1.Size = new System.Drawing.Size(1064, 194);
            this.pnDSNV1.TabIndex = 0;
            // 
            // grpTTNV
            // 
            this.grpTTNV.Controls.Add(this.txtMatKhau);
            this.grpTTNV.Controls.Add(this.txtLuong);
            this.grpTTNV.Controls.Add(this.txtHoTen);
            this.grpTTNV.Controls.Add(this.txtTenDangNhap);
            this.grpTTNV.Controls.Add(this.txtEmail);
            this.grpTTNV.Controls.Add(this.txtMaNV);
            this.grpTTNV.Controls.Add(this.lblMatKhau);
            this.grpTTNV.Controls.Add(this.lblLuong);
            this.grpTTNV.Controls.Add(this.lblHoTen);
            this.grpTTNV.Controls.Add(this.lblTenDangNhap);
            this.grpTTNV.Controls.Add(this.lblEmail);
            this.grpTTNV.Controls.Add(this.lblMaNV);
            this.grpTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpTTNV.Location = new System.Drawing.Point(36, 12);
            this.grpTTNV.Name = "grpTTNV";
            this.grpTTNV.Size = new System.Drawing.Size(992, 172);
            this.grpTTNV.TabIndex = 0;
            this.grpTTNV.TabStop = false;
            this.grpTTNV.Text = "Thông tin nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(713, 132);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(258, 27);
            this.txtMatKhau.TabIndex = 11;
            this.txtMatKhau.Click += new System.EventHandler(this.txtMatKhau_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(713, 86);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(258, 27);
            this.txtLuong.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(713, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(258, 27);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(180, 132);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(258, 27);
            this.txtTenDangNhap.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(180, 40);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(258, 27);
            this.txtMaNV.TabIndex = 6;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMatKhau.Location = new System.Drawing.Point(553, 132);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(141, 27);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLuong
            // 
            this.lblLuong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLuong.Location = new System.Drawing.Point(553, 86);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(141, 27);
            this.lblLuong.TabIndex = 4;
            this.lblLuong.Text = "Lương ";
            this.lblLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHoTen.Location = new System.Drawing.Point(553, 40);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(141, 27);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenDangNhap.Location = new System.Drawing.Point(21, 132);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(141, 27);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEmail.Location = new System.Drawing.Point(21, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 27);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMaNV.Location = new System.Drawing.Point(21, 40);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(141, 27);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDSNV2
            // 
            this.pnDSNV2.BackColor = System.Drawing.SystemColors.Info;
            this.pnDSNV2.Controls.Add(this.pnDSNV3);
            this.pnDSNV2.Controls.Add(this.dgvDSNV);
            this.pnDSNV2.Location = new System.Drawing.Point(6, 289);
            this.pnDSNV2.Name = "pnDSNV2";
            this.pnDSNV2.Size = new System.Drawing.Size(1064, 270);
            this.pnDSNV2.TabIndex = 0;
            // 
            // pnDSNV3
            // 
            this.pnDSNV3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDSNV3.Controls.Add(this.btnXoa);
            this.pnDSNV3.Controls.Add(this.btnKhong);
            this.pnDSNV3.Controls.Add(this.btnThoat);
            this.pnDSNV3.Controls.Add(this.btnGhiLuu);
            this.pnDSNV3.Controls.Add(this.btnSua);
            this.pnDSNV3.Controls.Add(this.btnThem);
            this.pnDSNV3.Location = new System.Drawing.Point(36, 210);
            this.pnDSNV3.Name = "pnDSNV3";
            this.pnDSNV3.Size = new System.Drawing.Size(992, 50);
            this.pnDSNV3.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(190, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhong.Location = new System.Drawing.Point(694, 9);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(105, 30);
            this.btnKhong.TabIndex = 4;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(862, 9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 30);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiLuu
            // 
            this.btnGhiLuu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGhiLuu.Location = new System.Drawing.Point(526, 9);
            this.btnGhiLuu.Name = "btnGhiLuu";
            this.btnGhiLuu.Size = new System.Drawing.Size(105, 30);
            this.btnGhiLuu.TabIndex = 3;
            this.btnGhiLuu.Text = "Ghi/Lưu";
            this.btnGhiLuu.UseVisualStyleBackColor = false;
            this.btnGhiLuu.Click += new System.EventHandler(this.btnGhiLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(358, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(22, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AllowUserToAddRows = false;
            this.dgvDSNV.AllowUserToDeleteRows = false;
            this.dgvDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(36, 19);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.ReadOnly = true;
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNV.Size = new System.Drawing.Size(992, 185);
            this.dgvDSNV.TabIndex = 0;
            this.dgvDSNV.SelectionChanged += new System.EventHandler(this.dgvDSNV_SelectionChanged);
            // 
            // lblDMNV
            // 
            this.lblDMNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMNV.Location = new System.Drawing.Point(3, 3);
            this.lblDMNV.Name = "lblDMNV";
            this.lblDMNV.Size = new System.Drawing.Size(1086, 48);
            this.lblDMNV.TabIndex = 0;
            this.lblDMNV.Text = "DANH MỤC NHÂN VIÊN";
            this.lblDMNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpQLLH
            // 
            this.tbpQLLH.Controls.Add(this.lblCur);
            this.tbpQLLH.Controls.Add(this.lblCurNV);
            this.tbpQLLH.Controls.Add(this.dgvQLLH);
            this.tbpQLLH.Controls.Add(this.lblQLLH);
            this.tbpQLLH.Controls.Add(this.btnTimKiemLH);
            this.tbpQLLH.Controls.Add(this.btnThemLH);
            this.tbpQLLH.Controls.Add(this.btnThoatLH);
            this.tbpQLLH.Controls.Add(this.txtTimKiemLH);
            this.tbpQLLH.Location = new System.Drawing.Point(4, 29);
            this.tbpQLLH.Name = "tbpQLLH";
            this.tbpQLLH.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQLLH.Size = new System.Drawing.Size(1092, 567);
            this.tbpQLLH.TabIndex = 1;
            this.tbpQLLH.Text = "Quản lý lớp học";
            this.tbpQLLH.UseVisualStyleBackColor = true;
            // 
            // lblCur
            // 
            this.lblCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCur.ForeColor = System.Drawing.Color.Red;
            this.lblCur.Location = new System.Drawing.Point(899, 60);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(86, 40);
            this.lblCur.TabIndex = 5;
            this.lblCur.Text = "NV:";
            this.lblCur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurNV
            // 
            this.lblCurNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurNV.ForeColor = System.Drawing.Color.Red;
            this.lblCurNV.Location = new System.Drawing.Point(991, 61);
            this.lblCurNV.Name = "lblCurNV";
            this.lblCurNV.Size = new System.Drawing.Size(86, 39);
            this.lblCurNV.TabIndex = 4;
            this.lblCurNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvQLLH
            // 
            this.dgvQLLH.AllowUserToAddRows = false;
            this.dgvQLLH.AllowUserToDeleteRows = false;
            this.dgvQLLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLLH.Location = new System.Drawing.Point(3, 294);
            this.dgvQLLH.Name = "dgvQLLH";
            this.dgvQLLH.ReadOnly = true;
            this.dgvQLLH.RowHeadersWidth = 51;
            this.dgvQLLH.RowTemplate.Height = 24;
            this.dgvQLLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLLH.Size = new System.Drawing.Size(1086, 270);
            this.dgvQLLH.TabIndex = 0;
            this.dgvQLLH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvQLLH_MouseDown);
            // 
            // lblQLLH
            // 
            this.lblQLLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLLH.ForeColor = System.Drawing.Color.Red;
            this.lblQLLH.Location = new System.Drawing.Point(3, 3);
            this.lblQLLH.Name = "lblQLLH";
            this.lblQLLH.Size = new System.Drawing.Size(1086, 47);
            this.lblQLLH.TabIndex = 0;
            this.lblQLLH.Text = "QUẢN LÝ LỚP HỌC\r\n";
            this.lblQLLH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimKiemLH
            // 
            this.btnTimKiemLH.Location = new System.Drawing.Point(860, 177);
            this.btnTimKiemLH.Name = "btnTimKiemLH";
            this.btnTimKiemLH.Size = new System.Drawing.Size(97, 35);
            this.btnTimKiemLH.TabIndex = 4;
            this.btnTimKiemLH.Text = "Tìm kiếm";
            this.btnTimKiemLH.UseVisualStyleBackColor = true;
            this.btnTimKiemLH.Click += new System.EventHandler(this.btnTimKiemLH_Click);
            // 
            // btnThemLH
            // 
            this.btnThemLH.Location = new System.Drawing.Point(991, 177);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(97, 35);
            this.btnThemLH.TabIndex = 3;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.UseVisualStyleBackColor = true;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnThoatLH
            // 
            this.btnThoatLH.Location = new System.Drawing.Point(991, 121);
            this.btnThoatLH.Name = "btnThoatLH";
            this.btnThoatLH.Size = new System.Drawing.Size(97, 35);
            this.btnThoatLH.TabIndex = 2;
            this.btnThoatLH.Text = "Thoát";
            this.btnThoatLH.UseVisualStyleBackColor = true;
            this.btnThoatLH.Click += new System.EventHandler(this.btnThoatLH_Click);
            // 
            // txtTimKiemLH
            // 
            this.txtTimKiemLH.Location = new System.Drawing.Point(518, 177);
            this.txtTimKiemLH.Name = "txtTimKiemLH";
            this.txtTimKiemLH.Size = new System.Drawing.Size(318, 27);
            this.txtTimKiemLH.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaLớpToolStripMenuItem,
            this.xóaLớpToolStripMenuItem,
            this.xemDSSVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 76);
            // 
            // sửaLớpToolStripMenuItem
            // 
            this.sửaLớpToolStripMenuItem.Name = "sửaLớpToolStripMenuItem";
            this.sửaLớpToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.sửaLớpToolStripMenuItem.Text = "Sửa lớp";
            this.sửaLớpToolStripMenuItem.Click += new System.EventHandler(this.sửaLớpToolStripMenuItem_Click);
            // 
            // xóaLớpToolStripMenuItem
            // 
            this.xóaLớpToolStripMenuItem.Name = "xóaLớpToolStripMenuItem";
            this.xóaLớpToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.xóaLớpToolStripMenuItem.Text = "Xóa lớp";
            this.xóaLớpToolStripMenuItem.Click += new System.EventHandler(this.xóaLớpToolStripMenuItem_Click);
            // 
            // xemDSSVToolStripMenuItem
            // 
            this.xemDSSVToolStripMenuItem.Name = "xemDSSVToolStripMenuItem";
            this.xemDSSVToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.xemDSSVToolStripMenuItem.Text = "Xem DSSV";
            this.xemDSSVToolStripMenuItem.Click += new System.EventHandler(this.xemDSSVToolStripMenuItem_Click);
            // 
            // frmManHinhQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 613);
            this.Controls.Add(this.tabQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManHinhQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình quản lý";
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            this.tabQL.ResumeLayout(false);
            this.tbpQLNV.ResumeLayout(false);
            this.pnDSNV1.ResumeLayout(false);
            this.grpTTNV.ResumeLayout(false);
            this.grpTTNV.PerformLayout();
            this.pnDSNV2.ResumeLayout(false);
            this.pnDSNV3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.tbpQLLH.ResumeLayout(false);
            this.tbpQLLH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabQL;
        private System.Windows.Forms.TabPage tbpQLNV;
        public System.Windows.Forms.TabPage tbpQLLH;
        private System.Windows.Forms.Panel pnDSNV1;
        private System.Windows.Forms.GroupBox grpTTNV;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel pnDSNV2;
        private System.Windows.Forms.Panel pnDSNV3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGhiLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Label lblDMNV;
        private System.Windows.Forms.TextBox txtTimKiemLH;
        private System.Windows.Forms.DataGridView dgvQLLH;
        private System.Windows.Forms.Label lblQLLH;
        private System.Windows.Forms.Button btnTimKiemLH;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnThoatLH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDSSVToolStripMenuItem;
        private System.Windows.Forms.Label lblCurNV;
        private System.Windows.Forms.Label lblCur;
    }
}