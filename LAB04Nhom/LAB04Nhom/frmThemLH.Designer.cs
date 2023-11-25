namespace LAB04Nhom
{
    partial class frmThemLH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLH));
            this.lblThemLop = new System.Windows.Forms.Label();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.LblLop = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThemLop
            // 
            this.lblThemLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLop.Location = new System.Drawing.Point(0, 0);
            this.lblThemLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThemLop.Name = "lblThemLop";
            this.lblThemLop.Size = new System.Drawing.Size(682, 71);
            this.lblThemLop.TabIndex = 0;
            this.lblThemLop.Text = "THÊM LỚP HỌC";
            this.lblThemLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(183, 365);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(107, 38);
            this.btnThemLop.TabIndex = 4;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // lblMaLop
            // 
            this.lblMaLop.Location = new System.Drawing.Point(77, 115);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(125, 29);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp";
            this.lblMaLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLop
            // 
            this.LblLop.Location = new System.Drawing.Point(77, 199);
            this.LblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLop.Name = "LblLop";
            this.LblLop.Size = new System.Drawing.Size(125, 29);
            this.LblLop.TabIndex = 0;
            this.LblLop.Text = "Tên lớp";
            this.LblLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(77, 283);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(125, 29);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(316, 199);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(290, 27);
            this.txtTenLop.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(316, 283);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(290, 27);
            this.txtMaNV.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(316, 115);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(290, 27);
            this.txtMaLop.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(392, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemLH
            // 
            this.AcceptButton = this.btnThemLop;
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
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.lblThemLop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lớp học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThemLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label LblLop;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThoat;
    }
}