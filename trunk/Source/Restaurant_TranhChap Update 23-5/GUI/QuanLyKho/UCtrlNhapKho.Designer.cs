namespace GUI.QuanLyKho
{
    partial class UCtrlNhapKho
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
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDS = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapBieuDo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridChiTietHD = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupThongTinDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThoiGianGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).BeginInit();
            this.groupThongTinDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatHang
            // 
            this.btnDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatHang.Image = global::GUI.Properties.Resources.add_16;
            this.btnDatHang.Location = new System.Drawing.Point(456, 442);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(168, 26);
            this.btnDatHang.TabIndex = 27;
            this.btnDatHang.Text = "Thêm Phiếu Nhập Kho";
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDS.Location = new System.Drawing.Point(630, 442);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(106, 26);
            this.btnInDS.TabIndex = 28;
            this.btnInDS.Text = "In Danh Sách";
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // btnLapBieuDo
            // 
            this.btnLapBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapBieuDo.Image = global::GUI.Properties.Resources.BieuDo_16;
            this.btnLapBieuDo.Location = new System.Drawing.Point(742, 442);
            this.btnLapBieuDo.Name = "btnLapBieuDo";
            this.btnLapBieuDo.Size = new System.Drawing.Size(133, 26);
            this.btnLapBieuDo.TabIndex = 28;
            this.btnLapBieuDo.Text = "Biểu Đồ Thống Kê";
            this.btnLapBieuDo.Click += new System.EventHandler(this.btnLapBieuDo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.gridChiTietHD);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 424);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Chi Tiết Nhập Hàng";
            // 
            // gridChiTietHD
            // 
            this.gridChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChiTietHD.Location = new System.Drawing.Point(2, 22);
            this.gridChiTietHD.MainView = this.gvChiTietHD;
            this.gridChiTietHD.Name = "gridChiTietHD";
            this.gridChiTietHD.Size = new System.Drawing.Size(321, 400);
            this.gridChiTietHD.TabIndex = 3;
            this.gridChiTietHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietHD});
            // 
            // gvChiTietHD
            // 
            this.gvChiTietHD.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvChiTietHD.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvChiTietHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TeNL,
            this.SoLuong,
            this.ThanhTien});
            this.gvChiTietHD.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvChiTietHD.GridControl = this.gridChiTietHD;
            this.gvChiTietHD.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvChiTietHD.Name = "gvChiTietHD";
            this.gvChiTietHD.OptionsBehavior.Editable = false;
            this.gvChiTietHD.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChiTietHD.OptionsView.ShowGroupPanel = false;
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
            this.TeNL.Width = 118;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 69;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành Tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.MaxWidth = 160;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 3;
            this.ThanhTien.Width = 86;
            // 
            // groupThongTinDatHang
            // 
            this.groupThongTinDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTinDatHang.Controls.Add(this.gridHoaDon);
            this.groupThongTinDatHang.Location = new System.Drawing.Point(334, 12);
            this.groupThongTinDatHang.Name = "groupThongTinDatHang";
            this.groupThongTinDatHang.Size = new System.Drawing.Size(543, 424);
            this.groupThongTinDatHang.TabIndex = 29;
            this.groupThongTinDatHang.Text = "Danh Sách Phiếu Nhập Kho";
            // 
            // gridHoaDon
            // 
            this.gridHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHoaDon.Location = new System.Drawing.Point(2, 22);
            this.gridHoaDon.MainView = this.gvHoaDon;
            this.gridHoaDon.Name = "gridHoaDon";
            this.gridHoaDon.Size = new System.Drawing.Size(539, 400);
            this.gridHoaDon.TabIndex = 1;
            this.gridHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvHoaDon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clTenNCC,
            this.clTongTien,
            this.clThoiGianGiao});
            this.gvHoaDon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvHoaDon.GridControl = this.gridHoaDon;
            this.gvHoaDon.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsBehavior.Editable = false;
            this.gvHoaDon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvHoaDon.OptionsView.ShowGroupPanel = false;
            this.gvHoaDon.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDatHang_FocusedRowChanged);
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
            this.clTenNCC.Caption = "Nhà Cung Cấp";
            this.clTenNCC.FieldName = "TenNCC";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.Visible = true;
            this.clTenNCC.VisibleIndex = 1;
            this.clTenNCC.Width = 150;
            // 
            // clTongTien
            // 
            this.clTongTien.Caption = "TongTien";
            this.clTongTien.FieldName = "TongTien";
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.Visible = true;
            this.clTongTien.VisibleIndex = 2;
            // 
            // clThoiGianGiao
            // 
            this.clThoiGianGiao.Caption = "Thời Gian Giao";
            this.clThoiGianGiao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clThoiGianGiao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clThoiGianGiao.FieldName = "ThoiGianGiao";
            this.clThoiGianGiao.Name = "clThoiGianGiao";
            this.clThoiGianGiao.Visible = true;
            this.clThoiGianGiao.VisibleIndex = 3;
            this.clThoiGianGiao.Width = 85;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh16;
            this.btnRefresh.Location = new System.Drawing.Point(339, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 26);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCtrlNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupThongTinDatHang);
            this.Controls.Add(this.btnLapBieuDo);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.btnDatHang);
            this.Name = "UCtrlNhapKho";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).EndInit();
            this.groupThongTinDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDatHang;
        private DevExpress.XtraEditors.SimpleButton btnInDS;
        private DevExpress.XtraEditors.SimpleButton btnLapBieuDo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridChiTietHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietHD;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TeNL;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.GroupControl groupThongTinDatHang;
        private DevExpress.XtraGrid.GridControl gridHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn clTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn clThoiGianGiao;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}
