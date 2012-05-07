namespace GUI.QuanLyKho
{
    partial class UCtrlTTDatHang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "aa"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "bb"}, -1);
            this.btnHuyDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongTinDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridDatHang = new DevExpress.XtraGrid.GridControl();
            this.gvDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThoiGianDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThoiGianGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lvNguyenLieu = new System.Windows.Forms.ListView();
            this.cl_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_nguyenlieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).BeginInit();
            this.groupThongTinDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuyDatHang
            // 
            this.btnHuyDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDatHang.Image = global::GUI.Properties.Resources.close_16;
            this.btnHuyDatHang.Location = new System.Drawing.Point(769, 442);
            this.btnHuyDatHang.Name = "btnHuyDatHang";
            this.btnHuyDatHang.Size = new System.Drawing.Size(106, 26);
            this.btnHuyDatHang.TabIndex = 18;
            this.btnHuyDatHang.Text = "Hủy Đặt Hàng";
            this.btnHuyDatHang.Click += new System.EventHandler(this.btnHuyDatHang_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatHang.Image = global::GUI.Properties.Resources.add_16;
            this.btnDatHang.Location = new System.Drawing.Point(506, 442);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(95, 26);
            this.btnDatHang.TabIndex = 21;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnCapNhatDatHang
            // 
            this.btnCapNhatDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatDatHang.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatDatHang.Location = new System.Drawing.Point(607, 442);
            this.btnCapNhatDatHang.Name = "btnCapNhatDatHang";
            this.btnCapNhatDatHang.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatDatHang.TabIndex = 22;
            this.btnCapNhatDatHang.Text = "Cập Nhật";
            this.btnCapNhatDatHang.Click += new System.EventHandler(this.btnCapNhatDatHang_Click);
            // 
            // btnXoaDatHang
            // 
            this.btnXoaDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDatHang.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaDatHang.Location = new System.Drawing.Point(702, 442);
            this.btnXoaDatHang.Name = "btnXoaDatHang";
            this.btnXoaDatHang.Size = new System.Drawing.Size(61, 26);
            this.btnXoaDatHang.TabIndex = 23;
            this.btnXoaDatHang.Text = "Xóa";
            this.btnXoaDatHang.Click += new System.EventHandler(this.btnXoaDatHang_Click);
            // 
            // groupThongTinDatHang
            // 
            this.groupThongTinDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTinDatHang.Controls.Add(this.gridDatHang);
            this.groupThongTinDatHang.Location = new System.Drawing.Point(334, 12);
            this.groupThongTinDatHang.Name = "groupThongTinDatHang";
            this.groupThongTinDatHang.Size = new System.Drawing.Size(543, 424);
            this.groupThongTinDatHang.TabIndex = 19;
            this.groupThongTinDatHang.Text = "Thông Tin Đặt Hàng";
            // 
            // gridDatHang
            // 
            this.gridDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatHang.Location = new System.Drawing.Point(2, 22);
            this.gridDatHang.MainView = this.gvDatHang;
            this.gridDatHang.Name = "gridDatHang";
            this.gridDatHang.Size = new System.Drawing.Size(539, 400);
            this.gridDatHang.TabIndex = 1;
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
            this.clThanhTien,
            this.clThoiGianDat,
            this.clThoiGianGiao,
            this.TinhTrang});
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
            this.clSTT.Width = 26;
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
            // clThanhTien
            // 
            this.clThanhTien.Caption = "Thành Tiền";
            this.clThanhTien.FieldName = "ThanhTien";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.Visible = true;
            this.clThanhTien.VisibleIndex = 2;
            // 
            // clThoiGianDat
            // 
            this.clThoiGianDat.Caption = "Thời Gian Đặt";
            this.clThoiGianDat.FieldName = "ThoiGianDat";
            this.clThoiGianDat.Name = "clThoiGianDat";
            this.clThoiGianDat.Visible = true;
            this.clThoiGianDat.VisibleIndex = 3;
            this.clThoiGianDat.Width = 85;
            // 
            // clThoiGianGiao
            // 
            this.clThoiGianGiao.Caption = "Thời Gian Giao";
            this.clThoiGianGiao.FieldName = "ThoiGianGiao";
            this.clThoiGianGiao.Name = "clThoiGianGiao";
            this.clThoiGianGiao.Visible = true;
            this.clThoiGianGiao.VisibleIndex = 4;
            this.clThoiGianGiao.Width = 85;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Tình Trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 5;
            this.TinhTrang.Width = 90;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.lvNguyenLieu);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 422);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Chi Tiết Đặt Hàng";
            // 
            // lvNguyenLieu
            // 
            this.lvNguyenLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_STT,
            this.cl_nguyenlieu,
            this.SoLuong,
            this.ThanhTien});
            this.lvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNguyenLieu.FullRowSelect = true;
            this.lvNguyenLieu.GridLines = true;
            this.lvNguyenLieu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.lvNguyenLieu.MultiSelect = false;
            this.lvNguyenLieu.Name = "lvNguyenLieu";
            this.lvNguyenLieu.Size = new System.Drawing.Size(321, 398);
            this.lvNguyenLieu.TabIndex = 1;
            this.lvNguyenLieu.UseCompatibleStateImageBehavior = false;
            this.lvNguyenLieu.View = System.Windows.Forms.View.Details;
            // 
            // cl_STT
            // 
            this.cl_STT.Text = "STT";
            this.cl_STT.Width = 30;
            // 
            // cl_nguyenlieu
            // 
            this.cl_nguyenlieu.Text = "Nguyên Liệu";
            this.cl_nguyenlieu.Width = 165;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 57;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "ThànhTiền";
            this.ThanhTien.Width = 65;
            // 
            // UCtrlTTDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnCapNhatDatHang);
            this.Controls.Add(this.btnXoaDatHang);
            this.Controls.Add(this.groupThongTinDatHang);
            this.Controls.Add(this.btnHuyDatHang);
            this.Name = "UCtrlTTDatHang";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).EndInit();
            this.groupThongTinDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuyDatHang;
        private DevExpress.XtraEditors.SimpleButton btnDatHang;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDatHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaDatHang;
        private DevExpress.XtraEditors.GroupControl groupThongTinDatHang;
        private DevExpress.XtraGrid.GridControl gridDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn clThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn clThoiGianDat;
        private DevExpress.XtraGrid.Columns.GridColumn clThoiGianGiao;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListView lvNguyenLieu;
        private System.Windows.Forms.ColumnHeader cl_STT;
        private System.Windows.Forms.ColumnHeader cl_nguyenlieu;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;


    }
}
