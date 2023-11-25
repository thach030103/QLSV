namespace LAB04Nhom
{
    partial class frmSuaLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaLop));
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.LblLop = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.btnCapNhatLop = new System.Windows.Forms.Button();
            this.lblSuaLop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(392, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(316, 140);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(290, 27);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(316, 308);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(290, 27);
            this.txtMaNV.TabIndex = 3;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(316, 224);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(290, 27);
            this.txtTenLop.TabIndex = 2;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(77, 308);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(125, 29);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLop
            // 
            this.LblLop.Location = new System.Drawing.Point(77, 224);
            this.LblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLop.Name = "LblLop";
            this.LblLop.Size = new System.Drawing.Size(125, 29);
            this.LblLop.TabIndex = 0;
            this.LblLop.Text = "Tên lớp";
            this.LblLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Location = new System.Drawing.Point(77, 140);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(125, 29);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp";
            this.lblMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.Location = new System.Drawing.Point(183, 390);
            this.btnCapNhatLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(107, 38);
            this.btnCapNhatLop.TabIndex = 4;
            this.btnCapNhatLop.Text = "Cập nhật";
            this.btnCapNhatLop.UseVisualStyleBackColor = true;
            this.btnCapNhatLop.Click += new System.EventHandler(this.btnCapNhatLop_Click);
            // 
            // lblSuaLop
            // 
            this.lblSuaLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaLop.Location = new System.Drawing.Point(0, 0);
            this.lblSuaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuaLop.Name = "lblSuaLop";
            this.lblSuaLop.Size = new System.Drawing.Size(682, 71);
            this.lblSuaLop.TabIndex = 0;
            this.lblSuaLop.Text = "SỬA LỚP HỌC";
            this.lblSuaLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSuaLop
            // 
            this.AcceptButton = this.btnCapNhatLop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.LblLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.btnCapNhatLop);
            this.Controls.Add(this.lblSuaLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label LblLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Button btnCapNhatLop;
        private System.Windows.Forms.Label lblSuaLop;
    }
}