namespace GUI.QuanLyNhaHang
{
    partial class UCtrlQLNhanVien
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLoaiNV = new DevExpress.XtraGrid.GridControl();
            this.btnCapNhatNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.groupNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.gridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.btnInDSNV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhanVien)).BeginInit();
            this.groupNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiNV)).BeginInit();
            this.groupLoaiNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại";
            this.gridColumn1.FieldName = "MaLoai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNV.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNV.Location = new System.Drawing.Point(541, 442);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(60, 26);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại";
            this.gridColumn2.FieldName = "TenLoai";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnThemLoaiNV
            // 
            this.btnThemLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemLoaiNV.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemLoaiNV.Location = new System.Drawing.Point(104, 442);
            this.btnThemLoaiNV.Name = "btnThemLoaiNV";
            this.btnThemLoaiNV.Size = new System.Drawing.Size(60, 26);
            this.btnThemLoaiNV.TabIndex = 11;
            this.btnThemLoaiNV.Text = "Thêm";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridLoaiNV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridLoaiNV
            // 
            this.gridLoaiNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiNV.Location = new System.Drawing.Point(2, 22);
            this.gridLoaiNV.MainView = this.gridView1;
            this.gridLoaiNV.Name = "gridLoaiNV";
            this.gridLoaiNV.Size = new System.Drawing.Size(321, 400);
            this.gridLoaiNV.TabIndex = 0;
            this.gridLoaiNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatNV.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatNV.Location = new System.Drawing.Point(607, 442);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatNV.TabIndex = 13;
            this.btnCapNhatNV.Text = "Cập Nhật";
            // 
            // btnCapNhatLoaiNV
            // 
            this.btnCapNhatLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatLoaiNV.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatLoaiNV.Location = new System.Drawing.Point(170, 442);
            this.btnCapNhatLoaiNV.Name = "btnCapNhatLoaiNV";
            this.btnCapNhatLoaiNV.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatLoaiNV.TabIndex = 12;
            this.btnCapNhatLoaiNV.Text = "Cập Nhật";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNV.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNV.Location = new System.Drawing.Point(702, 442);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNV.TabIndex = 15;
            this.btnXoaNV.Text = "Xóa";
            // 
            // btnXoaLoaiNV
            // 
            this.btnXoaLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaLoaiNV.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaLoaiNV.Location = new System.Drawing.Point(265, 442);
            this.btnXoaLoaiNV.Name = "btnXoaLoaiNV";
            this.btnXoaLoaiNV.Size = new System.Drawing.Size(61, 26);
            this.btnXoaLoaiNV.TabIndex = 16;
            this.btnXoaLoaiNV.Text = "Xóa";
            // 
            // groupNhanVien
            // 
            this.groupNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNhanVien.Controls.Add(this.gridNhanVien);
            this.groupNhanVien.Location = new System.Drawing.Point(334, 12);
            this.groupNhanVien.Name = "groupNhanVien";
            this.groupNhanVien.Size = new System.Drawing.Size(543, 424);
            this.groupNhanVien.TabIndex = 8;
            this.groupNhanVien.Text = "Danh Sách Nhân Viên";
            // 
            // gridNhanVien
            // 
            this.gridNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhanVien.Location = new System.Drawing.Point(2, 22);
            this.gridNhanVien.MainView = this.gridView2;
            this.gridNhanVien.Name = "gridNhanVien";
            this.gridNhanVien.Size = new System.Drawing.Size(539, 400);
            this.gridNhanVien.TabIndex = 0;
            this.gridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gridNhanVien;
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
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại Món";
            this.gridColumn4.FieldName = "TenLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Nhà Hàng";
            this.gridColumn8.FieldName = "TenNH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // groupLoaiNV
            // 
            this.groupLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupLoaiNV.Controls.Add(this.gridLoaiNV);
            this.groupLoaiNV.Location = new System.Drawing.Point(3, 12);
            this.groupLoaiNV.Name = "groupLoaiNV";
            this.groupLoaiNV.Size = new System.Drawing.Size(325, 424);
            this.groupLoaiNV.TabIndex = 9;
            this.groupLoaiNV.Text = "Loại Nhân Viên";
            // 
            // btnInDSNV
            // 
            this.btnInDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSNV.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDSNV.Location = new System.Drawing.Point(769, 442);
            this.btnInDSNV.Name = "btnInDSNV";
            this.btnInDSNV.Size = new System.Drawing.Size(106, 26);
            this.btnInDSNV.TabIndex = 14;
            this.btnInDSNV.Text = "In Danh Sách";
            // 
            // UCtrlQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.btnThemLoaiNV);
            this.Controls.Add(this.btnCapNhatNV);
            this.Controls.Add(this.btnCapNhatLoaiNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnXoaLoaiNV);
            this.Controls.Add(this.groupNhanVien);
            this.Controls.Add(this.groupLoaiNV);
            this.Controls.Add(this.btnInDSNV);
            this.Name = "UCtrlQLNhanVien";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhanVien)).EndInit();
            this.groupNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiNV)).EndInit();
            this.groupLoaiNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNV;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnXoaNV;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiNV;
        private DevExpress.XtraEditors.GroupControl groupNhanVien;
        private DevExpress.XtraGrid.GridControl gridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.GroupControl groupLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnInDSNV;


    }
}
