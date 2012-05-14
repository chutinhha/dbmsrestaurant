namespace GUI.TiepTan
{
    partial class UCtrlDSDatBan
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbB_LoaiBan = new System.Windows.Forms.ComboBox();
            this.lb_LoaiBan = new DevExpress.XtraEditors.LabelControl();
            this.cbB_TinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbKhuVuc = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_KhuVuc = new DevExpress.XtraEditors.LabelControl();
            this.cbB_MaBan = new System.Windows.Forms.ComboBox();
            this.lb_MaBan = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridDSDatBan = new DevExpress.XtraGrid.GridControl();
            this.gridView_DatBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDatBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbB_LoaiBan);
            this.groupControl2.Controls.Add(this.lb_LoaiBan);
            this.groupControl2.Controls.Add(this.cbB_TinhTrang);
            this.groupControl2.Controls.Add(this.cbbKhuVuc);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.lb_KhuVuc);
            this.groupControl2.Controls.Add(this.cbB_MaBan);
            this.groupControl2.Controls.Add(this.lb_MaBan);
            this.groupControl2.Location = new System.Drawing.Point(3, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(435, 127);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tùy Chọn";
            // 
            // cbB_LoaiBan
            // 
            this.cbB_LoaiBan.FormattingEnabled = true;
            this.cbB_LoaiBan.Location = new System.Drawing.Point(294, 81);
            this.cbB_LoaiBan.Name = "cbB_LoaiBan";
            this.cbB_LoaiBan.Size = new System.Drawing.Size(121, 21);
            this.cbB_LoaiBan.TabIndex = 1;
            this.cbB_LoaiBan.SelectedIndexChanged += new System.EventHandler(this.cbB_LoaiBan_SelectedIndexChanged);
            // 
            // lb_LoaiBan
            // 
            this.lb_LoaiBan.Location = new System.Drawing.Point(231, 84);
            this.lb_LoaiBan.Name = "lb_LoaiBan";
            this.lb_LoaiBan.Size = new System.Drawing.Size(47, 13);
            this.lb_LoaiBan.TabIndex = 0;
            this.lb_LoaiBan.Text = "Sức Chứa";
            // 
            // cbB_TinhTrang
            // 
            this.cbB_TinhTrang.FormattingEnabled = true;
            this.cbB_TinhTrang.Location = new System.Drawing.Point(294, 41);
            this.cbB_TinhTrang.Name = "cbB_TinhTrang";
            this.cbB_TinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cbB_TinhTrang.TabIndex = 1;
            this.cbB_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbB_TinhTrang_SelectedIndexChanged);
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.FormattingEnabled = true;
            this.cbbKhuVuc.Location = new System.Drawing.Point(80, 81);
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cbbKhuVuc.TabIndex = 1;
            this.cbbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbbKhuVuc_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(231, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tình Trạng";
            // 
            // lb_KhuVuc
            // 
            this.lb_KhuVuc.Location = new System.Drawing.Point(17, 85);
            this.lb_KhuVuc.Name = "lb_KhuVuc";
            this.lb_KhuVuc.Size = new System.Drawing.Size(39, 13);
            this.lb_KhuVuc.TabIndex = 0;
            this.lb_KhuVuc.Text = "Khu Vực";
            // 
            // cbB_MaBan
            // 
            this.cbB_MaBan.FormattingEnabled = true;
            this.cbB_MaBan.Location = new System.Drawing.Point(80, 42);
            this.cbB_MaBan.Name = "cbB_MaBan";
            this.cbB_MaBan.Size = new System.Drawing.Size(70, 21);
            this.cbB_MaBan.TabIndex = 1;
            this.cbB_MaBan.SelectedIndexChanged += new System.EventHandler(this.cbB_MaBan_SelectedIndexChanged);
            // 
            // lb_MaBan
            // 
            this.lb_MaBan.Location = new System.Drawing.Point(17, 46);
            this.lb_MaBan.Name = "lb_MaBan";
            this.lb_MaBan.Size = new System.Drawing.Size(35, 13);
            this.lb_MaBan.TabIndex = 0;
            this.lb_MaBan.Text = "Mã Bàn";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridDSDatBan);
            this.groupControl1.Location = new System.Drawing.Point(3, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 291);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh Sách Đặt Bàn";
            // 
            // gridDSDatBan
            // 
            this.gridDSDatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSDatBan.Location = new System.Drawing.Point(2, 22);
            this.gridDSDatBan.MainView = this.gridView_DatBan;
            this.gridDSDatBan.Name = "gridDSDatBan";
            this.gridDSDatBan.Size = new System.Drawing.Size(870, 267);
            this.gridDSDatBan.TabIndex = 0;
            this.gridDSDatBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_DatBan});
            // 
            // gridView_DatBan
            // 
            this.gridView_DatBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn8});
            this.gridView_DatBan.GridControl = this.gridDSDatBan;
            this.gridView_DatBan.Name = "gridView_DatBan";
            this.gridView_DatBan.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView_DatBan.OptionsBehavior.Editable = false;
            this.gridView_DatBan.OptionsSelection.MultiSelect = true;
            this.gridView_DatBan.OptionsView.ShowGroupPanel = false;
            this.gridView_DatBan.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_DatBan_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Bàn";
            this.gridColumn1.FieldName = "MaBan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 40;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Khách Hàng";
            this.gridColumn2.FieldName = "TenKhachHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 115;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Khu Vực";
            this.gridColumn3.FieldName = "TenKhuVuc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 115;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Vị Trí";
            this.gridColumn4.FieldName = "ViTri";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 115;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sức Chứa";
            this.gridColumn5.FieldName = "SucChua";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 115;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Thời Gian Đặt";
            this.gridColumn6.FieldName = "ThoiGianDat";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 115;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Thời Gian Đến";
            this.gridColumn7.FieldName = "ThoiGianDen";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 115;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "gridColumn9";
            this.gridColumn9.FieldName = "MaKhachHang";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tình Trạng";
            this.gridColumn8.FieldName = "TrangThai";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // btnDatBan
            // 
            this.btnDatBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatBan.Image = global::GUI.Properties.Resources.add_16;
            this.btnDatBan.Location = new System.Drawing.Point(479, 440);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(94, 26);
            this.btnDatBan.TabIndex = 16;
            this.btnDatBan.Text = "Đặt Bàn";
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Image = global::GUI.Properties.Resources.save_16;
            this.btnCapNhat.Location = new System.Drawing.Point(581, 440);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(89, 26);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Thay Đổi";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::GUI.Properties.Resources.delete_16;
            this.btnXoa.Location = new System.Drawing.Point(679, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 26);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh16;
            this.btnRefresh.Location = new System.Drawing.Point(781, 440);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 26);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UCtrlDSDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupControl2);
            this.Name = "UCtrlDSDatBan";
            this.Size = new System.Drawing.Size(880, 480);
            this.Load += new System.EventHandler(this.UCtrlDSDatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_DatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox cbB_LoaiBan;
        private DevExpress.XtraEditors.LabelControl lb_LoaiBan;
        private System.Windows.Forms.ComboBox cbB_TinhTrang;
        private System.Windows.Forms.ComboBox cbbKhuVuc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_KhuVuc;
        private System.Windows.Forms.ComboBox cbB_MaBan;
        private DevExpress.XtraEditors.LabelControl lb_MaBan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDatBan;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridDSDatBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_DatBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
