﻿namespace GUI.QuanLyNhaHang
{
    partial class UCtrlQLDanhSachBanAn
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
            this.btnThemBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemLoaiBA = new DevExpress.XtraEditors.SimpleButton();
            this.gridView_LoaiBanAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridLoaiBA = new DevExpress.XtraGrid.GridControl();
            this.btnCapNhatBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatLoaiBA = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaLoaiBA = new DevExpress.XtraEditors.SimpleButton();
            this.groupBanAn = new DevExpress.XtraEditors.GroupControl();
            this.gridBanAn = new DevExpress.XtraGrid.GridControl();
            this.gridView_BanAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupLoaiBA = new DevExpress.XtraEditors.GroupControl();
            this.btnInDSBA = new DevExpress.XtraEditors.SimpleButton();
            this.groupKhuVuc = new DevExpress.XtraEditors.GroupControl();
            this.gridKhuVuc = new DevExpress.XtraGrid.GridControl();
            this.gridView_KhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaKhuVuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatKhuVuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKhuVuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LoaiBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBanAn)).BeginInit();
            this.groupBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiBA)).BeginInit();
            this.groupLoaiBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKhuVuc)).BeginInit();
            this.groupKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại";
            this.gridColumn1.FieldName = "Maloai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // btnThemBanAn
            // 
            this.btnThemBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBanAn.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemBanAn.Location = new System.Drawing.Point(543, 442);
            this.btnThemBanAn.Name = "btnThemBanAn";
            this.btnThemBanAn.Size = new System.Drawing.Size(60, 26);
            this.btnThemBanAn.TabIndex = 10;
            this.btnThemBanAn.Text = "Thêm";
            this.btnThemBanAn.Click += new System.EventHandler(this.btnThemBanAn_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sức Chứa";
            this.gridColumn2.FieldName = "SucChua";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnThemLoaiBA
            // 
            this.btnThemLoaiBA.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemLoaiBA.Location = new System.Drawing.Point(104, 253);
            this.btnThemLoaiBA.Name = "btnThemLoaiBA";
            this.btnThemLoaiBA.Size = new System.Drawing.Size(60, 26);
            this.btnThemLoaiBA.TabIndex = 11;
            this.btnThemLoaiBA.Text = "Thêm";
            this.btnThemLoaiBA.Click += new System.EventHandler(this.btnThemLoaiBA_Click);
            // 
            // gridView_LoaiBanAn
            // 
            this.gridView_LoaiBanAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView_LoaiBanAn.GridControl = this.gridLoaiBA;
            this.gridView_LoaiBanAn.Name = "gridView_LoaiBanAn";
            this.gridView_LoaiBanAn.OptionsView.ShowGroupPanel = false;
            // 
            // gridLoaiBA
            // 
            this.gridLoaiBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiBA.Location = new System.Drawing.Point(2, 22);
            this.gridLoaiBA.MainView = this.gridView_LoaiBanAn;
            this.gridLoaiBA.Name = "gridLoaiBA";
            this.gridLoaiBA.Size = new System.Drawing.Size(321, 211);
            this.gridLoaiBA.TabIndex = 0;
            this.gridLoaiBA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LoaiBanAn});
            // 
            // btnCapNhatBanAn
            // 
            this.btnCapNhatBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatBanAn.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatBanAn.Location = new System.Drawing.Point(609, 442);
            this.btnCapNhatBanAn.Name = "btnCapNhatBanAn";
            this.btnCapNhatBanAn.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatBanAn.TabIndex = 13;
            this.btnCapNhatBanAn.Text = "Cập Nhật";
            this.btnCapNhatBanAn.Click += new System.EventHandler(this.btnCapNhatBanAn_Click);
            // 
            // btnCapNhatLoaiBA
            // 
            this.btnCapNhatLoaiBA.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatLoaiBA.Location = new System.Drawing.Point(170, 253);
            this.btnCapNhatLoaiBA.Name = "btnCapNhatLoaiBA";
            this.btnCapNhatLoaiBA.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatLoaiBA.TabIndex = 12;
            this.btnCapNhatLoaiBA.Text = "Cập Nhật";
            this.btnCapNhatLoaiBA.Click += new System.EventHandler(this.btnCapNhatLoaiBA_Click);
            // 
            // btnXoaBanAn
            // 
            this.btnXoaBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaBanAn.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaBanAn.Location = new System.Drawing.Point(704, 442);
            this.btnXoaBanAn.Name = "btnXoaBanAn";
            this.btnXoaBanAn.Size = new System.Drawing.Size(61, 26);
            this.btnXoaBanAn.TabIndex = 15;
            this.btnXoaBanAn.Text = "Xóa";
            this.btnXoaBanAn.Click += new System.EventHandler(this.btnXoaBanAn_Click);
            // 
            // btnXoaLoaiBA
            // 
            this.btnXoaLoaiBA.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaLoaiBA.Location = new System.Drawing.Point(265, 253);
            this.btnXoaLoaiBA.Name = "btnXoaLoaiBA";
            this.btnXoaLoaiBA.Size = new System.Drawing.Size(61, 26);
            this.btnXoaLoaiBA.TabIndex = 16;
            this.btnXoaLoaiBA.Text = "Xóa";
            this.btnXoaLoaiBA.Click += new System.EventHandler(this.btnXoaLoaiBA_Click);
            // 
            // groupBanAn
            // 
            this.groupBanAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBanAn.Controls.Add(this.gridBanAn);
            this.groupBanAn.Location = new System.Drawing.Point(334, 12);
            this.groupBanAn.Name = "groupBanAn";
            this.groupBanAn.Size = new System.Drawing.Size(543, 424);
            this.groupBanAn.TabIndex = 8;
            this.groupBanAn.Text = "Danh Sách Bàn Ăn";
            // 
            // gridBanAn
            // 
            this.gridBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBanAn.Location = new System.Drawing.Point(2, 22);
            this.gridBanAn.MainView = this.gridView_BanAn;
            this.gridBanAn.Name = "gridBanAn";
            this.gridBanAn.Size = new System.Drawing.Size(539, 400);
            this.gridBanAn.TabIndex = 0;
            this.gridBanAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_BanAn});
            // 
            // gridView_BanAn
            // 
            this.gridView_BanAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.gridView_BanAn.GridControl = this.gridBanAn;
            this.gridView_BanAn.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView_BanAn.Name = "gridView_BanAn";
            this.gridView_BanAn.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Bàn";
            this.gridColumn3.FieldName = "MaBan";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Khu Vực";
            this.gridColumn4.FieldName = "TenKhuVuc";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sức Chứa";
            this.gridColumn5.FieldName = "SucChua";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nhà Hàng";
            this.gridColumn6.FieldName = "TenNH";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Trạng Thái";
            this.gridColumn8.FieldName = "TrangThai";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // groupLoaiBA
            // 
            this.groupLoaiBA.Controls.Add(this.gridLoaiBA);
            this.groupLoaiBA.Location = new System.Drawing.Point(3, 12);
            this.groupLoaiBA.Name = "groupLoaiBA";
            this.groupLoaiBA.Size = new System.Drawing.Size(325, 235);
            this.groupLoaiBA.TabIndex = 9;
            this.groupLoaiBA.Text = "Loại Bàn Ăn";
            // 
            // btnInDSBA
            // 
            this.btnInDSBA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSBA.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDSBA.Location = new System.Drawing.Point(771, 442);
            this.btnInDSBA.Name = "btnInDSBA";
            this.btnInDSBA.Size = new System.Drawing.Size(106, 26);
            this.btnInDSBA.TabIndex = 14;
            this.btnInDSBA.Text = "In Danh Sách";
            // 
            // groupKhuVuc
            // 
            this.groupKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupKhuVuc.Controls.Add(this.gridKhuVuc);
            this.groupKhuVuc.Location = new System.Drawing.Point(5, 289);
            this.groupKhuVuc.Name = "groupKhuVuc";
            this.groupKhuVuc.Size = new System.Drawing.Size(325, 147);
            this.groupKhuVuc.TabIndex = 9;
            this.groupKhuVuc.Text = "Khu Vực";
            // 
            // gridKhuVuc
            // 
            this.gridKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKhuVuc.Location = new System.Drawing.Point(2, 22);
            this.gridKhuVuc.MainView = this.gridView_KhuVuc;
            this.gridKhuVuc.Name = "gridKhuVuc";
            this.gridKhuVuc.Size = new System.Drawing.Size(321, 123);
            this.gridKhuVuc.TabIndex = 0;
            this.gridKhuVuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_KhuVuc});
            // 
            // gridView_KhuVuc
            // 
            this.gridView_KhuVuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView_KhuVuc.GridControl = this.gridKhuVuc;
            this.gridView_KhuVuc.Name = "gridView_KhuVuc";
            this.gridView_KhuVuc.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã Khu Vực";
            this.gridColumn7.FieldName = "MaKhuVuc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên Khu Vực";
            this.gridColumn9.FieldName = "TenKhuVuc";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Vị Trí";
            this.gridColumn10.FieldName = "ViTri";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // btnXoaKhuVuc
            // 
            this.btnXoaKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaKhuVuc.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaKhuVuc.Location = new System.Drawing.Point(265, 442);
            this.btnXoaKhuVuc.Name = "btnXoaKhuVuc";
            this.btnXoaKhuVuc.Size = new System.Drawing.Size(61, 26);
            this.btnXoaKhuVuc.TabIndex = 16;
            this.btnXoaKhuVuc.Text = "Xóa";
            this.btnXoaKhuVuc.Click += new System.EventHandler(this.btnXoaKhuVuc_Click);
            // 
            // btnCapNhatKhuVuc
            // 
            this.btnCapNhatKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatKhuVuc.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatKhuVuc.Location = new System.Drawing.Point(170, 442);
            this.btnCapNhatKhuVuc.Name = "btnCapNhatKhuVuc";
            this.btnCapNhatKhuVuc.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatKhuVuc.TabIndex = 12;
            this.btnCapNhatKhuVuc.Text = "Cập Nhật";
            this.btnCapNhatKhuVuc.Click += new System.EventHandler(this.btnCapNhatKhuVuc_Click);
            // 
            // btnThemKhuVuc
            // 
            this.btnThemKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemKhuVuc.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemKhuVuc.Location = new System.Drawing.Point(104, 442);
            this.btnThemKhuVuc.Name = "btnThemKhuVuc";
            this.btnThemKhuVuc.Size = new System.Drawing.Size(60, 26);
            this.btnThemKhuVuc.TabIndex = 11;
            this.btnThemKhuVuc.Text = "Thêm";
            this.btnThemKhuVuc.Click += new System.EventHandler(this.btnThemKhuVuc_Click);
            // 
            // UCtrlQLDanhSachBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemBanAn);
            this.Controls.Add(this.btnThemKhuVuc);
            this.Controls.Add(this.btnThemLoaiBA);
            this.Controls.Add(this.btnCapNhatBanAn);
            this.Controls.Add(this.btnCapNhatKhuVuc);
            this.Controls.Add(this.btnCapNhatLoaiBA);
            this.Controls.Add(this.btnXoaKhuVuc);
            this.Controls.Add(this.btnXoaBanAn);
            this.Controls.Add(this.btnXoaLoaiBA);
            this.Controls.Add(this.groupKhuVuc);
            this.Controls.Add(this.groupBanAn);
            this.Controls.Add(this.groupLoaiBA);
            this.Controls.Add(this.btnInDSBA);
            this.Name = "UCtrlQLDanhSachBanAn";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlQLDanhSachBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LoaiBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBanAn)).EndInit();
            this.groupBanAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiBA)).EndInit();
            this.groupLoaiBA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupKhuVuc)).EndInit();
            this.groupKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_KhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton btnThemBanAn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiBA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LoaiBanAn;
        private DevExpress.XtraGrid.GridControl gridLoaiBA;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatBanAn;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiBA;
        private DevExpress.XtraEditors.SimpleButton btnXoaBanAn;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiBA;
        private DevExpress.XtraEditors.GroupControl groupBanAn;
        private DevExpress.XtraGrid.GridControl gridBanAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_BanAn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.GroupControl groupLoaiBA;
        private DevExpress.XtraEditors.SimpleButton btnInDSBA;
        private DevExpress.XtraEditors.GroupControl groupKhuVuc;
        private DevExpress.XtraGrid.GridControl gridKhuVuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_KhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btnXoaKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btnThemKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;



    }
}
