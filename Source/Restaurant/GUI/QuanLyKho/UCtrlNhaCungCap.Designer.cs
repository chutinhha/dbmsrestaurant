namespace GUI.QuanLyKho
{
    partial class UCtrlNhaCungCap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThemNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNCC = new DevExpress.XtraEditors.SimpleButton();
            this.groupNhaCungCap = new DevExpress.XtraEditors.GroupControl();
            this.gridNCC = new DevExpress.XtraGrid.GridControl();
            this.gvNCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDiemUuTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDSNCC = new DevExpress.XtraEditors.SimpleButton();
            this.groupNL = new DevExpress.XtraEditors.GroupControl();
            this.gridNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gvNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.btnCapNhatGia = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhaCungCap)).BeginInit();
            this.groupNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNL)).BeginInit();
            this.groupNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNCC.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNCC.Location = new System.Drawing.Point(543, 442);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(60, 26);
            this.btnThemNCC.TabIndex = 19;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnCapNhatNCC
            // 
            this.btnCapNhatNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatNCC.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatNCC.Location = new System.Drawing.Point(609, 442);
            this.btnCapNhatNCC.Name = "btnCapNhatNCC";
            this.btnCapNhatNCC.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatNCC.TabIndex = 22;
            this.btnCapNhatNCC.Text = "Cập Nhật";
            this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
            // 
            // groupNhaCungCap
            // 
            this.groupNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNhaCungCap.Controls.Add(this.gridNCC);
            this.groupNhaCungCap.Location = new System.Drawing.Point(334, 12);
            this.groupNhaCungCap.Name = "groupNhaCungCap";
            this.groupNhaCungCap.Size = new System.Drawing.Size(543, 424);
            this.groupNhaCungCap.TabIndex = 17;
            this.groupNhaCungCap.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // gridNCC
            // 
            this.gridNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNCC.Location = new System.Drawing.Point(2, 22);
            this.gridNCC.MainView = this.gvNCC;
            this.gridNCC.Name = "gridNCC";
            this.gridNCC.Size = new System.Drawing.Size(539, 400);
            this.gridNCC.TabIndex = 1;
            this.gridNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNCC});
            // 
            // gvNCC
            // 
            this.gvNCC.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvNCC.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clTenNCC,
            this.clSDT,
            this.clDiaChi,
            this.clDiemUuTien});
            this.gvNCC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvNCC.GridControl = this.gridNCC;
            this.gvNCC.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvNCC.Name = "gvNCC";
            this.gvNCC.OptionsBehavior.Editable = false;
            this.gvNCC.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvNCC.OptionsView.ShowGroupPanel = false;
            this.gvNCC.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNCC_FocusedRowChanged);
            // 
            // clSTT
            // 
            this.clSTT.Caption = "STT";
            this.clSTT.FieldName = "STT";
            this.clSTT.MaxWidth = 30;
            this.clSTT.Name = "clSTT";
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            this.clSTT.Width = 30;
            // 
            // clTenNCC
            // 
            this.clTenNCC.Caption = "Tên Nhà Cung Cấp";
            this.clTenNCC.FieldName = "TenNCC";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.Visible = true;
            this.clTenNCC.VisibleIndex = 1;
            this.clTenNCC.Width = 122;
            // 
            // clSDT
            // 
            this.clSDT.Caption = "Số Điện Thoại";
            this.clSDT.FieldName = "sdt";
            this.clSDT.MaxWidth = 160;
            this.clSDT.Name = "clSDT";
            this.clSDT.Visible = true;
            this.clSDT.VisibleIndex = 2;
            this.clSDT.Width = 145;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Caption = "Địa Chỉ";
            this.clDiaChi.FieldName = "DiaChi";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Visible = true;
            this.clDiaChi.VisibleIndex = 3;
            this.clDiaChi.Width = 122;
            // 
            // clDiemUuTien
            // 
            this.clDiemUuTien.Caption = "Điểm Ưu Tiên";
            this.clDiemUuTien.FieldName = "DiemUuTien";
            this.clDiemUuTien.MaxWidth = 100;
            this.clDiemUuTien.Name = "clDiemUuTien";
            this.clDiemUuTien.Visible = true;
            this.clDiemUuTien.VisibleIndex = 4;
            this.clDiemUuTien.Width = 100;
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNCC.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNCC.Location = new System.Drawing.Point(704, 442);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNCC.TabIndex = 24;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnInDSNCC
            // 
            this.btnInDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSNCC.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDSNCC.Location = new System.Drawing.Point(771, 442);
            this.btnInDSNCC.Name = "btnInDSNCC";
            this.btnInDSNCC.Size = new System.Drawing.Size(106, 26);
            this.btnInDSNCC.TabIndex = 23;
            this.btnInDSNCC.Text = "In Danh Sách";
            this.btnInDSNCC.Click += new System.EventHandler(this.btnInDSNCC_Click);
            // 
            // groupNL
            // 
            this.groupNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNL.Controls.Add(this.gridNguyenLieu);
            this.groupNL.Location = new System.Drawing.Point(3, 12);
            this.groupNL.Name = "groupNL";
            this.groupNL.Size = new System.Drawing.Size(325, 424);
            this.groupNL.TabIndex = 25;
            this.groupNL.Text = "Nguyên Liệu Từ Nhà Cung Cấp";
            // 
            // gridNguyenLieu
            // 
            this.gridNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.gridNguyenLieu.MainView = this.gvNguyenLieu;
            this.gridNguyenLieu.Name = "gridNguyenLieu";
            this.gridNguyenLieu.Size = new System.Drawing.Size(321, 400);
            this.gridNguyenLieu.TabIndex = 2;
            this.gridNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguyenLieu});
            // 
            // gvNguyenLieu
            // 
            this.gvNguyenLieu.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvNguyenLieu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TeNL,
            this.Gia});
            this.gvNguyenLieu.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvNguyenLieu.GridControl = this.gridNguyenLieu;
            this.gvNguyenLieu.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvNguyenLieu.Name = "gvNguyenLieu";
            this.gvNguyenLieu.OptionsBehavior.Editable = false;
            this.gvNguyenLieu.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvNguyenLieu.OptionsView.ShowGroupPanel = false;
            this.gvNguyenLieu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNguyenLieu_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MaxWidth = 30;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 30;
            // 
            // TeNL
            // 
            this.TeNL.Caption = "Nguyên Liệu";
            this.TeNL.FieldName = "TenNL";
            this.TeNL.Name = "TeNL";
            this.TeNL.Visible = true;
            this.TeNL.VisibleIndex = 1;
            this.TeNL.Width = 122;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá";
            this.Gia.FieldName = "Gia";
            this.Gia.MaxWidth = 160;
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 2;
            this.Gia.Width = 145;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGia.Location = new System.Drawing.Point(131, 444);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtGia.Properties.Appearance.Options.UseFont = true;
            this.txtGia.Size = new System.Drawing.Size(195, 24);
            this.txtGia.TabIndex = 26;
            this.txtGia.EditValueChanged += new System.EventHandler(this.txtGia_EditValueChanged);
            // 
            // btnCapNhatGia
            // 
            this.btnCapNhatGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatGia.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatGia.Location = new System.Drawing.Point(5, 442);
            this.btnCapNhatGia.Name = "btnCapNhatGia";
            this.btnCapNhatGia.Size = new System.Drawing.Size(120, 26);
            this.btnCapNhatGia.TabIndex = 27;
            this.btnCapNhatGia.Text = "Cập Nhật Giá";
            this.btnCapNhatGia.Click += new System.EventHandler(this.btnCapNhatGia_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh16;
            this.btnRefresh.Location = new System.Drawing.Point(426, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 26);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCtrlNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCapNhatGia);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.groupNL);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnCapNhatNCC);
            this.Controls.Add(this.groupNhaCungCap);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnInDSNCC);
            this.Name = "UCtrlNhaCungCap";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupNhaCungCap)).EndInit();
            this.groupNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNL)).EndInit();
            this.groupNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemNCC;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNCC;
        private DevExpress.XtraEditors.GroupControl groupNhaCungCap;
        private DevExpress.XtraEditors.SimpleButton btnXoaNCC;
        private DevExpress.XtraEditors.SimpleButton btnInDSNCC;
        private DevExpress.XtraGrid.GridControl gridNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNCC;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn clSDT;
        private DevExpress.XtraGrid.Columns.GridColumn clDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn clDiemUuTien;
        private DevExpress.XtraEditors.GroupControl groupNL;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatGia;
        private DevExpress.XtraGrid.GridControl gridNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TeNL;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}
