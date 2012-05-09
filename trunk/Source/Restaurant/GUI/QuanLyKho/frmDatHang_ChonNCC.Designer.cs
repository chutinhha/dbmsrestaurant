namespace GUI.QuanLyKho
{
    partial class frmDatHang_ChonNCC
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
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.groupDMNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.lvNCC = new System.Windows.Forms.ListView();
            this.cl_NCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsNguyenLieu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DiemUuTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).BeginInit();
            this.groupDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).BeginInit();
            this.groupDMNguyenLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.navigate_right48;
            this.pictureEdit1.Location = new System.Drawing.Point(320, 161);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 66);
            this.pictureEdit1.TabIndex = 4;
            // 
            // groupDSNCC
            // 
            this.groupDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDSNCC.Controls.Add(this.lvNCC);
            this.groupDSNCC.Location = new System.Drawing.Point(12, 12);
            this.groupDSNCC.Name = "groupDSNCC";
            this.groupDSNCC.Size = new System.Drawing.Size(300, 373);
            this.groupDSNCC.TabIndex = 3;
            this.groupDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // groupDMNguyenLieu
            // 
            this.groupDMNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDMNguyenLieu.Controls.Add(this.lsNguyenLieu);
            this.groupDMNguyenLieu.Location = new System.Drawing.Point(374, 12);
            this.groupDMNguyenLieu.Name = "groupDMNguyenLieu";
            this.groupDMNguyenLieu.Size = new System.Drawing.Size(300, 373);
            this.groupDMNguyenLieu.TabIndex = 2;
            this.groupDMNguyenLieu.Text = "Danh Mục Nguyên Liệu Từ Nhà Cung Cấp";
            // 
            // lvNCC
            // 
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_STT,
            this.cl_NCC,
            this.cl_DiemUuTien});
            this.lvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.GridLines = true;
            this.lvNCC.Location = new System.Drawing.Point(2, 22);
            this.lvNCC.MultiSelect = false;
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(296, 349);
            this.lvNCC.TabIndex = 2;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            // 
            // cl_NCC
            // 
            this.cl_NCC.Text = "Nhà Cung Cấp";
            this.cl_NCC.Width = 184;
            // 
            // lsNguyenLieu
            // 
            this.lsNguyenLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsNguyenLieu.FullRowSelect = true;
            this.lsNguyenLieu.GridLines = true;
            this.lsNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.lsNguyenLieu.MultiSelect = false;
            this.lsNguyenLieu.Name = "lsNguyenLieu";
            this.lsNguyenLieu.Size = new System.Drawing.Size(296, 349);
            this.lsNguyenLieu.TabIndex = 2;
            this.lsNguyenLieu.UseCompatibleStateImageBehavior = false;
            this.lsNguyenLieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nguyên Liệu";
            this.columnHeader2.Width = 161;
            // 
            // cl_DiemUuTien
            // 
            this.cl_DiemUuTien.Text = "Điểm Ưu Tiên";
            this.cl_DiemUuTien.Width = 76;
            // 
            // cl_STT
            // 
            this.cl_STT.Text = "STT";
            this.cl_STT.Width = 30;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(508, 391);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 34;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(597, 391);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá Nguyên Liệu";
            this.columnHeader3.Width = 99;
            // 
            // frmDatHang_ChonNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupDMNguyenLieu);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupDSNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatHang_ChonNCC";
            this.Text = "Chọn Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).EndInit();
            this.groupDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).EndInit();
            this.groupDMNguyenLieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupDSNCC;
        private DevExpress.XtraEditors.GroupControl groupDMNguyenLieu;
        private System.Windows.Forms.ListView lvNCC;
        private System.Windows.Forms.ColumnHeader cl_STT;
        private System.Windows.Forms.ColumnHeader cl_NCC;
        private System.Windows.Forms.ColumnHeader cl_DiemUuTien;
        private System.Windows.Forms.ListView lsNguyenLieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}