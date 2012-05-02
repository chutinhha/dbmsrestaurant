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
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNCC = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNhaCungCap = new DevExpress.XtraEditors.GroupControl();
            this.gridNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaNCC = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDSNCC = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupNhaCungCap)).BeginInit();
            this.groupNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            // btnThemNCC
            // 
            this.btnThemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNCC.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNCC.Location = new System.Drawing.Point(543, 442);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(60, 26);
            this.btnThemNCC.TabIndex = 19;
            this.btnThemNCC.Text = "Thêm";
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
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Nhà Hàng";
            this.gridColumn8.FieldName = "TenNH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại Món";
            this.gridColumn4.FieldName = "TenLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // groupNhaCungCap
            // 
            this.groupNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNhaCungCap.Controls.Add(this.gridNhaCungCap);
            this.groupNhaCungCap.Location = new System.Drawing.Point(3, 12);
            this.groupNhaCungCap.Name = "groupNhaCungCap";
            this.groupNhaCungCap.Size = new System.Drawing.Size(874, 424);
            this.groupNhaCungCap.TabIndex = 17;
            this.groupNhaCungCap.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // gridNhaCungCap
            // 
            this.gridNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhaCungCap.Location = new System.Drawing.Point(2, 22);
            this.gridNhaCungCap.MainView = this.gridView2;
            this.gridNhaCungCap.Name = "gridNhaCungCap";
            this.gridNhaCungCap.Size = new System.Drawing.Size(870, 400);
            this.gridNhaCungCap.TabIndex = 0;
            this.gridNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gridNhaCungCap;
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
            // btnXoaNCC
            // 
            this.btnXoaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNCC.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNCC.Location = new System.Drawing.Point(704, 442);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNCC.TabIndex = 24;
            this.btnXoaNCC.Text = "Xóa";
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
            // 
            // UCtrlNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnCapNhatNCC);
            this.Controls.Add(this.groupNhaCungCap);
            this.Controls.Add(this.btnXoaNCC);
            this.Controls.Add(this.btnInDSNCC);
            this.Name = "UCtrlNhaCungCap";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.groupNhaCungCap)).EndInit();
            this.groupNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnThemNCC;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupNhaCungCap;
        private DevExpress.XtraGrid.GridControl gridNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnXoaNCC;
        private DevExpress.XtraEditors.SimpleButton btnInDSNCC;
    }
}
