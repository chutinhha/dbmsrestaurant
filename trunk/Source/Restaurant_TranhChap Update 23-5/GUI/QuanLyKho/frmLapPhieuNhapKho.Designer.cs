namespace GUI.QuanLyKho
{
    partial class frmLapPhieuNhapKho
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
            this.groupDSDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThoiGianDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridChiTietDH = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TeNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).BeginInit();
            this.groupDSDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDSDatHang
            // 
            this.groupDSDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDSDatHang.Controls.Add(this.gridDatHang);
            this.groupDSDatHang.Location = new System.Drawing.Point(324, 12);
            this.groupDSDatHang.Name = "groupDSDatHang";
            this.groupDSDatHang.Size = new System.Drawing.Size(548, 405);
            this.groupDSDatHang.TabIndex = 0;
            this.groupDSDatHang.Text = "Danh Sách Đặt Hàng Chưa Giao";
            // 
            // gridDatHang
            // 
            this.gridDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatHang.Location = new System.Drawing.Point(2, 22);
            this.gridDatHang.MainView = this.gvDatHang;
            this.gridDatHang.Name = "gridDatHang";
            this.gridDatHang.Size = new System.Drawing.Size(544, 381);
            this.gridDatHang.TabIndex = 2;
            this.gridDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatHang});
            // 
            // gvDatHang
            // 
            this.gvDatHang.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvDatHang.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clTenNCC,
            this.clTongTien,
            this.clThoiGianDat});
            this.gvDatHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvDatHang.GridControl = this.gridDatHang;
            this.gvDatHang.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvDatHang.Name = "gvDatHang";
            this.gvDatHang.OptionsBehavior.Editable = false;
            this.gvDatHang.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDatHang.OptionsView.ShowGroupPanel = false;
            this.gvDatHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDatHang_FocusedRowChanged);
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
            // clThoiGianDat
            // 
            this.clThoiGianDat.Caption = "Thời Gian Đặt";
            this.clThoiGianDat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clThoiGianDat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clThoiGianDat.FieldName = "ThoiGianDat";
            this.clThoiGianDat.Name = "clThoiGianDat";
            this.clThoiGianDat.Visible = true;
            this.clThoiGianDat.VisibleIndex = 3;
            this.clThoiGianDat.Width = 85;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNhapHang.Image = global::GUI.Properties.Resources.ok_24;
            this.btnNhapHang.Location = new System.Drawing.Point(651, 423);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(117, 32);
            this.btnNhapHang.TabIndex = 2;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(783, 423);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.gridChiTietDH);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(306, 405);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Chi Tiết Nhập Hàng";
            // 
            // gridChiTietDH
            // 
            this.gridChiTietDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChiTietDH.Location = new System.Drawing.Point(2, 22);
            this.gridChiTietDH.MainView = this.gvChiTietDH;
            this.gridChiTietDH.Name = "gridChiTietDH";
            this.gridChiTietDH.Size = new System.Drawing.Size(302, 381);
            this.gridChiTietDH.TabIndex = 3;
            this.gridChiTietDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietDH});
            // 
            // gvChiTietDH
            // 
            this.gvChiTietDH.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvChiTietDH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvChiTietDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TeNL,
            this.SoLuong,
            this.ThanhTien});
            this.gvChiTietDH.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvChiTietDH.GridControl = this.gridChiTietDH;
            this.gvChiTietDH.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gvChiTietDH.Name = "gvChiTietDH";
            this.gvChiTietDH.OptionsBehavior.Editable = false;
            this.gvChiTietDH.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvChiTietDH.OptionsView.ShowGroupPanel = false;
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
            // frmLapPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.groupDSDatHang);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmLapPhieuNhapKho";
            this.Text = "flrmLapPhieuNhapKho";
            this.Load += new System.EventHandler(this.frmLapPhieuNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).EndInit();
            this.groupDSDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTietDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDSDatHang;
        private DevExpress.XtraEditors.SimpleButton btnNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraGrid.GridControl gridDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn clTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn clThoiGianDat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridChiTietDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietDH;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TeNL;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
    }
}