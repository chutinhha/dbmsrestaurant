namespace GUI.QuanLyNhaHang
{
    partial class UCtrlQLThucDon
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridMonAn = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupLoaiMA = new DevExpress.XtraEditors.GroupControl();
            this.gridLoaiMonAn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaLoaiMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatLoaiMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDSMA = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiMA)).BeginInit();
            this.groupLoaiMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridMonAn);
            this.groupControl1.Location = new System.Drawing.Point(334, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(543, 424);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Món Ăn";
            // 
            // gridMonAn
            // 
            this.gridMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMonAn.Location = new System.Drawing.Point(2, 22);
            this.gridMonAn.MainView = this.gridView2;
            this.gridMonAn.Name = "gridMonAn";
            this.gridMonAn.Size = new System.Drawing.Size(539, 400);
            this.gridMonAn.TabIndex = 0;
            this.gridMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gridMonAn;
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
            // groupLoaiMA
            // 
            this.groupLoaiMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupLoaiMA.Controls.Add(this.gridLoaiMonAn);
            this.groupLoaiMA.Location = new System.Drawing.Point(3, 12);
            this.groupLoaiMA.Name = "groupLoaiMA";
            this.groupLoaiMA.Size = new System.Drawing.Size(325, 424);
            this.groupLoaiMA.TabIndex = 1;
            this.groupLoaiMA.Text = "Loại Món Ăn";
            // 
            // gridLoaiMonAn
            // 
            this.gridLoaiMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLoaiMonAn.Location = new System.Drawing.Point(2, 22);
            this.gridLoaiMonAn.MainView = this.gridView1;
            this.gridLoaiMonAn.Name = "gridLoaiMonAn";
            this.gridLoaiMonAn.Size = new System.Drawing.Size(321, 400);
            this.gridLoaiMonAn.TabIndex = 0;
            this.gridLoaiMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridLoaiMonAn;
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
            // btnXoaLoaiMA
            // 
            this.btnXoaLoaiMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaLoaiMA.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaLoaiMA.Location = new System.Drawing.Point(265, 442);
            this.btnXoaLoaiMA.Name = "btnXoaLoaiMA";
            this.btnXoaLoaiMA.Size = new System.Drawing.Size(61, 26);
            this.btnXoaLoaiMA.TabIndex = 7;
            this.btnXoaLoaiMA.Text = "Xóa";
            // 
            // btnCapNhatLoaiMA
            // 
            this.btnCapNhatLoaiMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhatLoaiMA.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatLoaiMA.Location = new System.Drawing.Point(170, 442);
            this.btnCapNhatLoaiMA.Name = "btnCapNhatLoaiMA";
            this.btnCapNhatLoaiMA.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatLoaiMA.TabIndex = 6;
            this.btnCapNhatLoaiMA.Text = "Cập Nhật";
            // 
            // btnThemLoaiMA
            // 
            this.btnThemLoaiMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemLoaiMA.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemLoaiMA.Location = new System.Drawing.Point(104, 442);
            this.btnThemLoaiMA.Name = "btnThemLoaiMA";
            this.btnThemLoaiMA.Size = new System.Drawing.Size(60, 26);
            this.btnThemLoaiMA.TabIndex = 5;
            this.btnThemLoaiMA.Text = "Thêm";
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMonAn.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaMonAn.Location = new System.Drawing.Point(702, 442);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(61, 26);
            this.btnXoaMonAn.TabIndex = 7;
            this.btnXoaMonAn.Text = "Xóa";
            // 
            // btnCapNhatMonAn
            // 
            this.btnCapNhatMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatMonAn.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatMonAn.Location = new System.Drawing.Point(607, 442);
            this.btnCapNhatMonAn.Name = "btnCapNhatMonAn";
            this.btnCapNhatMonAn.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatMonAn.TabIndex = 6;
            this.btnCapNhatMonAn.Text = "Cập Nhật";
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMonAn.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemMonAn.Location = new System.Drawing.Point(541, 442);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(60, 26);
            this.btnThemMonAn.TabIndex = 5;
            this.btnThemMonAn.Text = "Thêm";
            // 
            // btnInDSMA
            // 
            this.btnInDSMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSMA.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDSMA.Location = new System.Drawing.Point(769, 442);
            this.btnInDSMA.Name = "btnInDSMA";
            this.btnInDSMA.Size = new System.Drawing.Size(106, 26);
            this.btnInDSMA.TabIndex = 7;
            this.btnInDSMA.Text = "In Danh Sách";
            // 
            // UCtrlQLThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.btnThemLoaiMA);
            this.Controls.Add(this.btnCapNhatMonAn);
            this.Controls.Add(this.btnCapNhatLoaiMA);
            this.Controls.Add(this.btnInDSMA);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.btnXoaLoaiMA);
            this.Controls.Add(this.groupLoaiMA);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCtrlQLThucDon";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrl_QLNhaHang_QLThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoaiMA)).EndInit();
            this.groupLoaiMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupLoaiMA;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiMA;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatLoaiMA;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiMA;
        private DevExpress.XtraGrid.GridControl gridLoaiMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnXoaMonAn;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatMonAn;
        private DevExpress.XtraEditors.SimpleButton btnThemMonAn;
        private DevExpress.XtraEditors.SimpleButton btnInDSMA;

    }
}
