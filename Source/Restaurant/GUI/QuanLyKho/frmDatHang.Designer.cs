namespace GUI.QuanLyKho
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.groupDMNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.lstbDanhMucNguyenLieu = new DevExpress.XtraEditors.ListBoxControl();
            this.groupDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.lstbDanhSachNCC = new DevExpress.XtraEditors.ListBoxControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lbNguyenLieu = new DevExpress.XtraEditors.LabelControl();
            this.txtNguyenLieu = new DevExpress.XtraEditors.TextEdit();
            this.lbNCC = new DevExpress.XtraEditors.LabelControl();
            this.txtNCC = new DevExpress.XtraEditors.TextEdit();
            this.lbSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.groupDSDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridDSDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnKetThucDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.lbDonVi = new DevExpress.XtraEditors.LabelControl();
            this.groupThongTinDatHang = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).BeginInit();
            this.groupDMNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbDanhMucNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).BeginInit();
            this.groupDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbDanhSachNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).BeginInit();
            this.groupDSDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).BeginInit();
            this.groupThongTinDatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDMNguyenLieu
            // 
            this.groupDMNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDMNguyenLieu.Controls.Add(this.lstbDanhMucNguyenLieu);
            this.groupDMNguyenLieu.Location = new System.Drawing.Point(12, 28);
            this.groupDMNguyenLieu.Name = "groupDMNguyenLieu";
            this.groupDMNguyenLieu.Size = new System.Drawing.Size(202, 384);
            this.groupDMNguyenLieu.TabIndex = 0;
            this.groupDMNguyenLieu.Text = "Danh Mục Nguyên Liệu";
            // 
            // lstbDanhMucNguyenLieu
            // 
            this.lstbDanhMucNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbDanhMucNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.lstbDanhMucNguyenLieu.Name = "lstbDanhMucNguyenLieu";
            this.lstbDanhMucNguyenLieu.Size = new System.Drawing.Size(198, 360);
            this.lstbDanhMucNguyenLieu.TabIndex = 0;
            // 
            // groupDSNCC
            // 
            this.groupDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDSNCC.Controls.Add(this.lstbDanhSachNCC);
            this.groupDSNCC.Location = new System.Drawing.Point(274, 28);
            this.groupDSNCC.Name = "groupDSNCC";
            this.groupDSNCC.Size = new System.Drawing.Size(197, 384);
            this.groupDSNCC.TabIndex = 0;
            this.groupDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // lstbDanhSachNCC
            // 
            this.lstbDanhSachNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbDanhSachNCC.Location = new System.Drawing.Point(2, 22);
            this.lstbDanhSachNCC.Name = "lstbDanhSachNCC";
            this.lstbDanhSachNCC.Size = new System.Drawing.Size(193, 360);
            this.lstbDanhSachNCC.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.navigate_right48;
            this.pictureEdit1.Location = new System.Drawing.Point(220, 201);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 66);
            this.pictureEdit1.TabIndex = 1;
            // 
            // lbNguyenLieu
            // 
            this.lbNguyenLieu.Location = new System.Drawing.Point(16, 34);
            this.lbNguyenLieu.Name = "lbNguyenLieu";
            this.lbNguyenLieu.Size = new System.Drawing.Size(62, 13);
            this.lbNguyenLieu.TabIndex = 2;
            this.lbNguyenLieu.Text = "Nguyên Liệu ";
            // 
            // txtNguyenLieu
            // 
            this.txtNguyenLieu.Location = new System.Drawing.Point(96, 31);
            this.txtNguyenLieu.Name = "txtNguyenLieu";
            this.txtNguyenLieu.Size = new System.Drawing.Size(278, 20);
            this.txtNguyenLieu.TabIndex = 3;
            // 
            // lbNCC
            // 
            this.lbNCC.Location = new System.Drawing.Point(16, 60);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(69, 13);
            this.lbNCC.TabIndex = 2;
            this.lbNCC.Text = "Nhà Cung Cấp";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(96, 57);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(278, 20);
            this.txtNCC.TabIndex = 3;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Location = new System.Drawing.Point(16, 86);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(45, 13);
            this.lbSoLuong.TabIndex = 2;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(96, 83);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(278, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // groupDSDatHang
            // 
            this.groupDSDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDSDatHang.Controls.Add(this.gridDSDatHang);
            this.groupDSDatHang.Location = new System.Drawing.Point(477, 183);
            this.groupDSDatHang.Name = "groupDSDatHang";
            this.groupDSDatHang.Size = new System.Drawing.Size(445, 229);
            this.groupDSDatHang.TabIndex = 4;
            this.groupDSDatHang.Text = "Danh Sách Đặt Hàng";
            // 
            // gridDSDatHang
            // 
            this.gridDSDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSDatHang.Location = new System.Drawing.Point(2, 22);
            this.gridDSDatHang.MainView = this.gridView2;
            this.gridDSDatHang.Name = "gridDSDatHang";
            this.gridDSDatHang.Size = new System.Drawing.Size(441, 205);
            this.gridDSDatHang.TabIndex = 1;
            this.gridDSDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.gridView2.GridControl = this.gridDSDatHang;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Columns";
            this.gridColumn3.FieldName = "TenMon";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(831, 418);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 32);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy ";
            // 
            // btnKetThucDatHang
            // 
            this.btnKetThucDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKetThucDatHang.Image = global::GUI.Properties.Resources.save_24;
            this.btnKetThucDatHang.Location = new System.Drawing.Point(667, 418);
            this.btnKetThucDatHang.Name = "btnKetThucDatHang";
            this.btnKetThucDatHang.Size = new System.Drawing.Size(158, 32);
            this.btnKetThucDatHang.TabIndex = 5;
            this.btnKetThucDatHang.Text = "Kết Thúc Đặt Hàng";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.add_16;
            this.btnThem.Location = new System.Drawing.Point(479, 152);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 25);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoa.Location = new System.Drawing.Point(603, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 25);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            // 
            // lbDonVi
            // 
            this.lbDonVi.Location = new System.Drawing.Point(380, 34);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(16, 13);
            this.lbDonVi.TabIndex = 6;
            this.lbDonVi.Text = "....";
            // 
            // groupThongTinDatHang
            // 
            this.groupThongTinDatHang.Controls.Add(this.txtNguyenLieu);
            this.groupThongTinDatHang.Controls.Add(this.lbDonVi);
            this.groupThongTinDatHang.Controls.Add(this.lbNguyenLieu);
            this.groupThongTinDatHang.Controls.Add(this.lbNCC);
            this.groupThongTinDatHang.Controls.Add(this.txtNCC);
            this.groupThongTinDatHang.Controls.Add(this.lbSoLuong);
            this.groupThongTinDatHang.Controls.Add(this.txtSoLuong);
            this.groupThongTinDatHang.Location = new System.Drawing.Point(479, 28);
            this.groupThongTinDatHang.MinimumSize = new System.Drawing.Size(438, 118);
            this.groupThongTinDatHang.Name = "groupThongTinDatHang";
            this.groupThongTinDatHang.Size = new System.Drawing.Size(438, 118);
            this.groupThongTinDatHang.TabIndex = 7;
            this.groupThongTinDatHang.Text = "Thông Tin Đặt Hàng";
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 462);
            this.Controls.Add(this.groupThongTinDatHang);
            this.Controls.Add(this.btnKetThucDatHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupDSDatHang);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupDSNCC);
            this.Controls.Add(this.groupDMNguyenLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).EndInit();
            this.groupDMNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstbDanhMucNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).EndInit();
            this.groupDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstbDanhSachNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).EndInit();
            this.groupDSDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).EndInit();
            this.groupThongTinDatHang.ResumeLayout(false);
            this.groupThongTinDatHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDMNguyenLieu;
        private DevExpress.XtraEditors.GroupControl groupDSNCC;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ListBoxControl lstbDanhMucNguyenLieu;
        private DevExpress.XtraEditors.ListBoxControl lstbDanhSachNCC;
        private DevExpress.XtraEditors.LabelControl lbNguyenLieu;
        private DevExpress.XtraEditors.TextEdit txtNguyenLieu;
        private DevExpress.XtraEditors.LabelControl lbNCC;
        private DevExpress.XtraEditors.TextEdit txtNCC;
        private DevExpress.XtraEditors.LabelControl lbSoLuong;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.GroupControl groupDSDatHang;
        private DevExpress.XtraGrid.GridControl gridDSDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnKetThucDatHang;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LabelControl lbDonVi;
        private DevExpress.XtraEditors.GroupControl groupThongTinDatHang;
    }
}