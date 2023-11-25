namespace LAB04Nhom
{
    partial class frmDSSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSV));
            this.btnTimKiemLH = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnThoatDSSV = new System.Windows.Forms.Button();
            this.txtTimKiemDSSV = new System.Windows.Forms.TextBox();
            this.lblDSSV = new System.Windows.Forms.Label();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemBảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiemLH
            // 
            this.btnTimKiemLH.Location = new System.Drawing.Point(757, 133);
            this.btnTimKiemLH.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemLH.Name = "btnTimKiemLH";
            this.btnTimKiemLH.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiemLH.TabIndex = 3;
            this.btnTimKiemLH.Text = "Tìm kiếm";
            this.btnTimKiemLH.UseVisualStyleBackColor = true;
            this.btnTimKiemLH.Click += new System.EventHandler(this.btnTimKiemDSSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(882, 133);
            this.btnThemSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(100, 30);
            this.btnThemSV.TabIndex = 4;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnThoatDSSV
            // 
            this.btnThoatDSSV.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatDSSV.Location = new System.Drawing.Point(882, 63);
            this.btnThoatDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatDSSV.Name = "btnThoatDSSV";
            this.btnThoatDSSV.Size = new System.Drawing.Size(100, 30);
            this.btnThoatDSSV.TabIndex = 1;
            this.btnThoatDSSV.Text = "Thoát";
            this.btnThoatDSSV.UseVisualStyleBackColor = true;
            this.btnThoatDSSV.Click += new System.EventHandler(this.btnThoatDSSV_Click);
            // 
            // txtTimKiemDSSV
            // 
            this.txtTimKiemDSSV.Location = new System.Drawing.Point(319, 133);
            this.txtTimKiemDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemDSSV.Name = "txtTimKiemDSSV";
            this.txtTimKiemDSSV.Size = new System.Drawing.Size(396, 27);
            this.txtTimKiemDSSV.TabIndex = 2;
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
            this.lblDSSV.TabIndex = 0;
            this.lblDSSV.Text = "DANH SÁCH SINH VIÊN";
            this.lblDSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AllowUserToDeleteRows = false;
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSSV.Location = new System.Drawing.Point(0, 192);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.ReadOnly = true;
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(982, 311);
            this.dgvDSSV.TabIndex = 0;
            this.dgvDSSV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDSSV_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaSinhViênToolStripMenuItem,
            this.sửaSinhViênToolStripMenuItem,
            this.xemBảngĐiểmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 116);
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            this.xóaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xóaSinhViênToolStripMenuItem_Click);
            // 
            // sửaSinhViênToolStripMenuItem
            // 
            this.sửaSinhViênToolStripMenuItem.Name = "sửaSinhViênToolStripMenuItem";
            this.sửaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.sửaSinhViênToolStripMenuItem.Text = "Sửa sinh viên";
            this.sửaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.sửaSinhViênToolStripMenuItem_Click);
            // 
            // xemBảngĐiểmToolStripMenuItem
            // 
            this.xemBảngĐiểmToolStripMenuItem.Name = "xemBảngĐiểmToolStripMenuItem";
            this.xemBảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.xemBảngĐiểmToolStripMenuItem.Text = "Xem bảng điểm";
            this.xemBảngĐiểmToolStripMenuItem.Click += new System.EventHandler(this.xemBảngĐiểmToolStripMenuItem_Click);
            // 
            // frmDSSV
            // 
            this.AcceptButton = this.btnTimKiemLH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoatDSSV;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.lblDSSV);
            this.Controls.Add(this.btnTimKiemLH);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.btnThoatDSSV);
            this.Controls.Add(this.txtTimKiemDSSV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemLH;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnThoatDSSV;
        private System.Windows.Forms.TextBox txtTimKiemDSSV;
        private System.Windows.Forms.Label lblDSSV;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemBảngĐiểmToolStripMenuItem;
    }
}