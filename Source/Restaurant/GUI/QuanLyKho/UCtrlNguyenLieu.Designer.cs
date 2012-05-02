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
            this.btnThemNhomNL = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNhomNL = new DevExpress.XtraEditors.GroupControl();
            this.gridNhomNL = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.gridNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCapNhatNhomNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNhomNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhMucNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhomNL)).BeginInit();
            this.groupNhomNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).BeginInit();
            this.groupNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNhomNL
            // 
            this.btnThemNhomNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemNhomNL.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNhomNL.Location = new System.Drawing.Point(104, 442);
            this.btnThemNhomNL.Name = "btnThemNhomNL";
            this.btnThemNhomNL.Size = new System.Drawing.Size(60, 26);
            this.btnThemNhomNL.TabIndex = 20;
            this.btnThemNhomNL.Text = "Thêm";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá";
            this.gridColumn5.FieldName = "Gia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Đơn Vị Tính";
            this.gridColumn6.FieldName = "DonViTinh";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Nhà Hàng";
            this.gridColumn8.FieldName = "TenNH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // groupNhomNL
            // 
            this.groupNhomNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNhomNL.Controls.Add(this.gridNhomNL);
            this.groupNhomNL.Location = new System.Drawing.Point(3, 12);
            this.groupNhomNL.Name = "groupNhomNL";
            this.groupNhomNL.Size = new System.Drawing.Size(325, 424);
            this.groupNhomNL.TabIndex = 18;
            this.groupNhomNL.Text = "Nhóm Nguyên Liệu";
            // 
            // gridNhomNL
            // 
            this.gridNhomNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhomNL.Location = new System.Drawing.Point(2, 22);
            this.gridNhomNL.MainView = this.gridView1;
            this.gridNhomNL.Name = "gridNhomNL";
            this.gridNhomNL.Size = new System.Drawing.Size(321, 400);
            this.gridNhomNL.TabIndex = 0;
            this.gridNhomNL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridNhomNL;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại";
            this.gridColumn1.FieldName = "MaLoai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại";
            this.gridColumn2.FieldName = "TenLoai";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại Món";
            this.gridColumn4.FieldName = "TenLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridNguyenLieu;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Món";
            this.gridColumn3.FieldName = "TenMon";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // btnCapNhatNhomNL
            // 
            this.btnCapNhatNhomNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatNhomNL.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatNhomNL.Location = new System.Drawing.Point(170, 442);
            this.btnCapNhatNhomNL.Name = "btnCapNhatNhomNL";
            this.btnCapNhatNhomNL.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatNhomNL.TabIndex = 21;
            this.btnCapNhatNhomNL.Text = "Cập Nhật";
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
            // btnXoaNhomNL
            // 
            this.btnXoaNhomNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaNhomNL.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNhomNL.Location = new System.Drawing.Point(265, 442);
            this.btnXoaNhomNL.Name = "btnXoaNhomNL";
            this.btnXoaNhomNL.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNhomNL.TabIndex = 25;
            this.btnXoaNhomNL.Text = "Xóa";
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
            // UCtrlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemNhomNL);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Controls.Add(this.btnCapNhatNguyenLieu);
            this.Controls.Add(this.groupNhomNL);
            this.Controls.Add(this.groupNguyenLieu);
            this.Controls.Add(this.btnCapNhatNhomNL);
            this.Controls.Add(this.btnXoaNguyenLieu);
            this.Controls.Add(this.btnXoaNhomNL);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnInDanhMucNL);
            this.Name = "UCtrlNguyenLieu";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.groupNhomNL)).EndInit();
            this.groupNhomNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).EndInit();
            this.groupNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThemNhomNL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnThemNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.GroupControl groupNhomNL;
        private DevExpress.XtraGrid.GridControl gridNhomNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupNguyenLieu;
        private DevExpress.XtraGrid.GridControl gridNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNhomNL;
        private DevExpress.XtraEditors.SimpleButton btnXoaNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnXoaNhomNL;
        private DevExpress.XtraEditors.SimpleButton btnInDanhMucNL;
        private DevExpress.XtraEditors.SimpleButton btnDatHang;
    }
}
