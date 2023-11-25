namespace LAB04Nhom
{
    partial class frmSuaBDHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaBDHP));
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.lblTinChi = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.LblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.btnCNDiemHP = new System.Windows.Forms.Button();
            this.lblSDHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(309, 253);
            this.txtSoTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(290, 27);
            this.txtSoTC.TabIndex = 3;
            // 
            // lblTinChi
            // 
            this.lblTinChi.Location = new System.Drawing.Point(83, 253);
            this.lblTinChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinChi.Name = "lblTinChi";
            this.lblTinChi.Size = new System.Drawing.Size(125, 29);
            this.lblTinChi.TabIndex = 26;
            this.lblTinChi.Text = "Số tín chỉ";
            this.lblTinChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(392, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(309, 123);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(290, 27);
            this.txtMaHP.TabIndex = 1;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(309, 318);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(290, 27);
            this.txtDiem.TabIndex = 4;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(309, 188);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(290, 27);
            this.txtTenHP.TabIndex = 2;
            // 
            // lblDiem
            // 
            this.lblDiem.Location = new System.Drawing.Point(83, 318);
            this.lblDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(125, 29);
            this.lblDiem.TabIndex = 17;
            this.lblDiem.Text = "Điểm ";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTenHP
            // 
            this.LblTenHP.Location = new System.Drawing.Point(83, 188);
            this.LblTenHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTenHP.Name = "LblTenHP";
            this.LblTenHP.Size = new System.Drawing.Size(125, 29);
            this.LblTenHP.TabIndex = 18;
            this.LblTenHP.Text = "Tên học phần";
            this.LblTenHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaHP
            // 
            this.lblMaHP.Location = new System.Drawing.Point(83, 123);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(125, 29);
            this.lblMaHP.TabIndex = 19;
            this.lblMaHP.Text = "Mã HP";
            this.lblMaHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCNDiemHP
            // 
            this.btnCNDiemHP.Location = new System.Drawing.Point(183, 402);
            this.btnCNDiemHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCNDiemHP.Name = "btnCNDiemHP";
            this.btnCNDiemHP.Size = new System.Drawing.Size(107, 38);
            this.btnCNDiemHP.TabIndex = 5;
            this.btnCNDiemHP.Text = "Cập nhật";
            this.btnCNDiemHP.UseVisualStyleBackColor = true;
            this.btnCNDiemHP.Click += new System.EventHandler(this.btnCNDiemHP_Click);
            // 
            // lblSDHP
            // 
            this.lblSDHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSDHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDHP.Location = new System.Drawing.Point(0, 0);
            this.lblSDHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDHP.Name = "lblSDHP";
            this.lblSDHP.Size = new System.Drawing.Size(682, 71);
            this.lblSDHP.TabIndex = 0;
            this.lblSDHP.Text = "SỬA ĐIỂM HỌC PHẦN";
            this.lblSDHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSuaBDHP
            // 
            this.AcceptButton = this.btnCNDiemHP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.txtSoTC);
            this.Controls.Add(this.lblTinChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTenHP);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.LblTenHP);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.btnCNDiemHP);
            this.Controls.Add(this.lblSDHP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSuaBDHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa bảng điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Label lblTinChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label LblTenHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Button btnCNDiemHP;
        private System.Windows.Forms.Label lblSDHP;
    }
}