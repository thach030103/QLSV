namespace LAB04Nhom
{
    partial class frmBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangDiem));
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.txtTimKiemBD = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemHP = new System.Windows.Forms.Button();
            this.btnTimKiemBD = new System.Windows.Forms.Button();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaĐiểmHọcPhầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐiểmHọcPhầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBD
            // 
            this.dgvBD.AllowUserToAddRows = false;
            this.dgvBD.AllowUserToDeleteRows = false;
            this.dgvBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBD.Location = new System.Drawing.Point(0, 192);
            this.dgvBD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.ReadOnly = true;
            this.dgvBD.RowHeadersWidth = 51;
            this.dgvBD.RowTemplate.Height = 24;
            this.dgvBD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBD.Size = new System.Drawing.Size(982, 311);
            this.dgvBD.TabIndex = 5;
            this.dgvBD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvBD_MouseDown);
            // 
            // txtTimKiemBD
            // 
            this.txtTimKiemBD.Location = new System.Drawing.Point(242, 133);
            this.txtTimKiemBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemBD.Name = "txtTimKiemBD";
            this.txtTimKiemBD.Size = new System.Drawing.Size(396, 27);
            this.txtTimKiemBD.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(882, 63);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemHP
            // 
            this.btnThemHP.Location = new System.Drawing.Point(836, 133);
            this.btnThemHP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(146, 30);
            this.btnThemHP.TabIndex = 10;
            this.btnThemHP.Text = "Thêm học phần";
            this.btnThemHP.UseVisualStyleBackColor = true;
            this.btnThemHP.Click += new System.EventHandler(this.btnThemHP_Click);
            // 
            // btnTimKiemBD
            // 
            this.btnTimKiemBD.Location = new System.Drawing.Point(703, 133);
            this.btnTimKiemBD.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemBD.Name = "btnTimKiemBD";
            this.btnTimKiemBD.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiemBD.TabIndex = 9;
            this.btnTimKiemBD.Text = "Tìm kiếm";
            this.btnTimKiemBD.UseVisualStyleBackColor = true;
            this.btnTimKiemBD.Click += new System.EventHandler(this.btnTimKiemBD_Click);
            // 
            // lblDSSV
            // 
            this.lblDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSSV.ForeColor = System.Drawing.Color.Red;
            this.lblDSSV.Location = new System.Drawing.Point(0, 0);
            this.lblDSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSSV.Name = "lblDSSV";
            this.lblDSSV.Size = new System.Drawing.Size(982, 59);
            this.lblDSSV.TabIndex = 6;
            this.lblDSSV.Text = "BẢNG ĐIỂM";
            this.lblDSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaĐiểmHọcPhầnToolStripMenuItem,
            this.sửaĐiểmHọcPhầnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 52);
            // 
            // xóaĐiểmHọcPhầnToolStripMenuItem
            // 
            this.xóaĐiểmHọcPhầnToolStripMenuItem.Name = "xóaĐiểmHọcPhầnToolStripMenuItem";
            this.xóaĐiểmHọcPhầnToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.xóaĐiểmHọcPhầnToolStripMenuItem.Text = "Xóa điểm học phần";
            this.xóaĐiểmHọcPhầnToolStripMenuItem.Click += new System.EventHandler(this.xóaĐiểmHọcPhầnToolStripMenuItem_Click);
            // 
            // sửaĐiểmHọcPhầnToolStripMenuItem
            // 
            this.sửaĐiểmHọcPhầnToolStripMenuItem.Name = "sửaĐiểmHọcPhầnToolStripMenuItem";
            this.sửaĐiểmHọcPhầnToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.sửaĐiểmHọcPhầnToolStripMenuItem.Text = "Sửa điểm học phần";
            this.sửaĐiểmHọcPhầnToolStripMenuItem.Click += new System.EventHandler(this.sửaĐiểmHọcPhầnToolStripMenuItem_Click);
            // 
            // frmBangDiem
            // 
            this.AcceptButton = this.btnTimKiemBD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.dgvBD);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.btnTimKiemBD);
            this.Controls.Add(this.btnThemHP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTimKiemBD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.TextBox txtTimKiemBD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemHP;
        private System.Windows.Forms.Button btnTimKiemBD;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaĐiểmHọcPhầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaĐiểmHọcPhầnToolStripMenuItem;
    }
}