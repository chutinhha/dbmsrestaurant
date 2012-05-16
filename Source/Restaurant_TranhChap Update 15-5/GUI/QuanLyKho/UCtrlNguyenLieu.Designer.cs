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
            this.btnThemNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.clDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.gridNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gvNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDanhMucNL = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNguyenLieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).BeginInit();
            this.groupNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clTenNL
            // 
            this.clTenNL.Caption = "Tên Nguyên Liệu";
            this.clTenNL.FieldName = "TenNL";
            this.clTenNL.Name = "clTenNL";
            this.clTenNL.Visible = true;
            this.clTenNL.VisibleIndex = 1;
            this.clTenNL.Width = 122;
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieu.Image = global::GUI.Properties.Resources.add_16;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(541, 442);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(60, 26);
            this.btnThemNguyenLieu.TabIndex = 19;
            this.btnThemNguyenLieu.Text = "Thêm";
            this.btnThemNguyenLieu.Click += new System.EventHandler(this.btnThemNguyenLieu_Click);
            // 
            // btnCapNhatNguyenLieu
            // 
            this.btnCapNhatNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatNguyenLieu.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhatNguyenLieu.Location = new System.Drawing.Point(607, 442);
            this.btnCapNhatNguyenLieu.Name = "btnCapNhatNguyenLieu";
            this.btnCapNhatNguyenLieu.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhatNguyenLieu.TabIndex = 22;
            this.btnCapNhatNguyenLieu.Text = "Cập Nhật";
            this.btnCapNhatNguyenLieu.Click += new System.EventHandler(this.btnCapNhatNguyenLieu_Click);
            // 
            // clDonVi
            // 
            this.clDonVi.Caption = "Đơn Vị";
            this.clDonVi.FieldName = "DonVi";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.Visible = true;
            this.clDonVi.VisibleIndex = 2;
            this.clDonVi.Width = 122;
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
            this.gridNguyenLieu.MainView = this.gvNguyenLieu;
            this.gridNguyenLieu.Name = "gridNguyenLieu";
            this.gridNguyenLieu.Size = new System.Drawing.Size(539, 400);
            this.gridNguyenLieu.TabIndex = 0;
            this.gridNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguyenLieu});
            // 
            // gvNguyenLieu
            // 
            this.gvNguyenLieu.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gvNguyenLieu.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clTenNL,
            this.clDonVi,
            this.clSoLuongTon});
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
            // clSoLuongTon
            // 
            this.clSoLuongTon.Caption = "Số Lượng Tồn";
            this.clSoLuongTon.FieldName = "SoLuongTon";
            this.clSoLuongTon.Name = "clSoLuongTon";
            this.clSoLuongTon.Visible = true;
            this.clSoLuongTon.VisibleIndex = 3;
            this.clSoLuongTon.Width = 125;
            // 
            // btnXoaNguyenLieu
            // 
            this.btnXoaNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNguyenLieu.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoaNguyenLieu.Location = new System.Drawing.Point(702, 442);
            this.btnXoaNguyenLieu.Name = "btnXoaNguyenLieu";
            this.btnXoaNguyenLieu.Size = new System.Drawing.Size(61, 26);
            this.btnXoaNguyenLieu.TabIndex = 24;
            this.btnXoaNguyenLieu.Text = "Xóa";
            this.btnXoaNguyenLieu.Click += new System.EventHandler(this.btnXoaNguyenLieu_Click);
            // 
            // btnInDanhMucNL
            // 
            this.btnInDanhMucNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDanhMucNL.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDanhMucNL.Location = new System.Drawing.Point(769, 442);
            this.btnInDanhMucNL.Name = "btnInDanhMucNL";
            this.btnInDanhMucNL.Size = new System.Drawing.Size(106, 26);
            this.btnInDanhMucNL.TabIndex = 23;
            this.btnInDanhMucNL.Text = "In Danh Sách";
            this.btnInDanhMucNL.Click += new System.EventHandler(this.btnInDanhMucNL_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Nguyên Liệu";
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(117, 47);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(173, 20);
            this.txtTenNguyenLieu.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(75, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Đơn Vị";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(117, 79);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(173, 20);
            this.txtDonVi.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(37, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Số Lượng  Tồn";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(117, 111);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Properties.Mask.EditMask = "f0";
            this.txtSoLuongTon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoLuongTon.Size = new System.Drawing.Size(173, 20);
            this.txtSoLuongTon.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSoLuongTon);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDonVi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtTenNguyenLieu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(323, 159);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Thông Tin Nguyên Liệu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh16;
            this.btnRefresh.Location = new System.Drawing.Point(424, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 26);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCtrlNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThemNguyenLieu);
            this.Controls.Add(this.btnCapNhatNguyenLieu);
            this.Controls.Add(this.groupNguyenLieu);
            this.Controls.Add(this.btnXoaNguyenLieu);
            this.Controls.Add(this.btnInDanhMucNL);
            this.Name = "UCtrlNguyenLieu";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupNguyenLieu)).EndInit();
            this.groupNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn clTenNL;
        private DevExpress.XtraEditors.SimpleButton btnThemNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn clDonVi;
        private DevExpress.XtraEditors.GroupControl groupNguyenLieu;
        private DevExpress.XtraGrid.GridControl gridNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnXoaNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton btnInDanhMucNL;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenNguyenLieu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSoLuongTon;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}
