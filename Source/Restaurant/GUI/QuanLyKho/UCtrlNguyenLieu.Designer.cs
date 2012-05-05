namespace GUI.QuanLyKho
{
    partial class UCtrlNguyenLieu
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
            this.clTenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.clDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.gridNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoaNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhMucNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.clSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).BeginInit();
            this.groupNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // clTenNL
            // 
            this.clTenNL.Caption = "Tên Nguyên Liệu";
            this.clTenNL.FieldName = "TenNL";
            this.clTenNL.Name = "clTenNL";
            this.clTenNL.Visible = true;
            this.clTenNL.VisibleIndex = 0;
            // 
            // clGia
            // 
            this.clGia.Caption = "Giá";
            this.clGia.FieldName = "Gia";
            this.clGia.Name = "clGia";
            this.clGia.Visible = true;
            this.clGia.VisibleIndex = 1;
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieu.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(336, 442);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(60, 26);
            this.btnThemNguyenLieu.TabIndex = 19;
            this.btnThemNguyenLieu.Text = "Thêm";
            // 
            // btnCapNhatNguyenLieu
            // 
            this.btnCapNhatNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatNguyenLieu.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatNguyenLieu.Location = new System.Drawing.Point(402, 442);
            this.btnCapNhatNguyenLieu.Name = "btnCapNhatNguyenLieu";
            this.btnCapNhatNguyenLieu.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatNguyenLieu.TabIndex = 22;
            this.btnCapNhatNguyenLieu.Text = "Cập Nhật";
            // 
            // clDonVi
            // 
            this.clDonVi.Caption = "Đơn Vị";
            this.clDonVi.FieldName = "DonVi";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.Visible = true;
            this.clDonVi.VisibleIndex = 2;
            // 
            // groupNguyenLieu
            // 
            this.groupNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNguyenLieu.Controls.Add(this.gridNguyenLieu);
            this.groupNguyenLieu.Location = new System.Drawing.Point(334, 12);
            this.groupNguyenLieu.Name = "groupNguyenLieu";
            this.groupNguyenLieu.Size = new System.Drawing.Size(543, 424);
            this.groupNguyenLieu.TabIndex = 17;
            this.groupNguyenLieu.Text = "Danh Mục Nguyên Liệu";
            // 
            // gridNguyenLieu
            // 
            this.gridNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.gridNguyenLieu.MainView = this.gridView2;
            this.gridNguyenLieu.Name = "gridNguyenLieu";
            this.gridNguyenLieu.Size = new System.Drawing.Size(539, 400);
            this.gridNguyenLieu.TabIndex = 0;
            this.gridNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clTenNL,
            this.clGia,
            this.clDonVi,
            this.clSoLuongTon});
            this.gridView2.GridControl = this.gridNguyenLieu;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // btnXoaNguyenLieu
            // 
            this.btnXoaNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNguyenLieu.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNguyenLieu.Location = new System.Drawing.Point(497, 442);
            this.btnXoaNguyenLieu.Name = "btnXoaNguyenLieu";
            this.btnXoaNguyenLieu.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNguyenLieu.TabIndex = 24;
            this.btnXoaNguyenLieu.Text = "Xóa";
            // 
            // btnInDanhMucNL
            // 
            this.btnInDanhMucNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDanhMucNL.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDanhMucNL.Location = new System.Drawing.Point(564, 442);
            this.btnInDanhMucNL.Name = "btnInDanhMucNL";
            this.btnInDanhMucNL.Size = new System.Drawing.Size(106, 26);
            this.btnInDanhMucNL.TabIndex = 23;
            this.btnInDanhMucNL.Text = "In Danh Sách";
            // 
            // btnDatHang
            // 
            this.btnDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatHang.Location = new System.Drawing.Point(684, 442);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(191, 26);
            this.btnDatHang.TabIndex = 23;
            this.btnDatHang.Text = "Đặt Hàng";
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 240);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Thông Tin Nguyên Liệu";
            // 
            // clSoLuongTon
            // 
            this.clSoLuongTon.Caption = "Số Lượng Tồn";
            this.clSoLuongTon.FieldName = "SoLuongTon";
            this.clSoLuongTon.Name = "clSoLuongTon";
            this.clSoLuongTon.Visible = true;
            this.clSoLuongTon.VisibleIndex = 3;
            // 
            // UCtrlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Controls.Add(this.btnCapNhatNguyenLieu);
            this.Controls.Add(this.groupNguyenLieu);
            this.Controls.Add(this.btnXoaNguyenLieu);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnInDanhMucNL);
            this.Name = "UCtrlNguyenLieu";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).EndInit();
            this.groupNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn clTenNL;
        private DevExpress.XtraGrid.Columns.GridColumn clGia;
        private DevExpress.XtraEditors.SimpleButton btnThemNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn clDonVi;
        private DevExpress.XtraEditors.GroupControl groupNguyenLieu;
        private DevExpress.XtraGrid.GridControl gridNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnXoaNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnInDanhMucNL;
        private DevExpress.XtraEditors.SimpleButton btnDatHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongTon;
    }
}
