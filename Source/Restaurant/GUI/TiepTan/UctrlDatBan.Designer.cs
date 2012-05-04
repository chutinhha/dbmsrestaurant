namespace GUI.TiepTan
{
    partial class UctrlDatBan
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
            this.btnKhongDatBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.gridView_BanDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_DatBan = new DevExpress.XtraGrid.GridControl();
            this.groupTTDatBan = new DevExpress.XtraEditors.GroupControl();
            this.txtThoiGianDen = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_BanTrong = new DevExpress.XtraGrid.GridControl();
            this.gridView_BanTrong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDatBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyDatBan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTDatBan)).BeginInit();
            this.groupTTDatBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BanTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhongDatBan
            // 
            this.btnKhongDatBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhongDatBan.Image = global::GUI.Properties.Resources.close_24;
            this.btnKhongDatBan.Location = new System.Drawing.Point(774, 440);
            this.btnKhongDatBan.Name = "btnKhongDatBan";
            this.btnKhongDatBan.Size = new System.Drawing.Size(75, 32);
            this.btnKhongDatBan.TabIndex = 10;
            this.btnKhongDatBan.Text = "Hủy";
            this.btnKhongDatBan.Click += new System.EventHandler(this.btnKhongDatBan_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChapNhan.Image = global::GUI.Properties.Resources.ok_24;
            this.btnChapNhan.Location = new System.Drawing.Point(643, 440);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(109, 32);
            this.btnChapNhan.TabIndex = 11;
            this.btnChapNhan.Text = "Đặt Bàn";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // gridView_BanDat
            // 
            this.gridView_BanDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn9,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView_BanDat.GridControl = this.gridControl_DatBan;
            this.gridView_BanDat.Name = "gridView_BanDat";
            this.gridView_BanDat.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Bàn";
            this.gridColumn5.FieldName = "MaBan";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Vị Trí";
            this.gridColumn9.FieldName = "ViTri";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên Khách Hàng";
            this.gridColumn6.FieldName = "TenKhachHang";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Sdt";
            this.gridColumn7.FieldName = "Sdt";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Thời Gian Đến";
            this.gridColumn8.FieldName = "ThoiGianDen";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridControl_DatBan
            // 
            this.gridControl_DatBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DatBan.Location = new System.Drawing.Point(2, 22);
            this.gridControl_DatBan.MainView = this.gridView_BanDat;
            this.gridControl_DatBan.Name = "gridControl_DatBan";
            this.gridControl_DatBan.Size = new System.Drawing.Size(401, 187);
            this.gridControl_DatBan.TabIndex = 1;
            this.gridControl_DatBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_BanDat});
            // 
            // groupTTDatBan
            // 
            this.groupTTDatBan.Controls.Add(this.txtThoiGianDen);
            this.groupTTDatBan.Controls.Add(this.labelControl3);
            this.groupTTDatBan.Controls.Add(this.txtSoDienThoai);
            this.groupTTDatBan.Controls.Add(this.labelControl2);
            this.groupTTDatBan.Controls.Add(this.txtTenKhachHang);
            this.groupTTDatBan.Controls.Add(this.labelControl1);
            this.groupTTDatBan.Location = new System.Drawing.Point(446, 21);
            this.groupTTDatBan.Name = "groupTTDatBan";
            this.groupTTDatBan.Size = new System.Drawing.Size(350, 184);
            this.groupTTDatBan.TabIndex = 5;
            this.groupTTDatBan.Text = "Thông Tin Đặt Bàn";
            // 
            // txtThoiGianDen
            // 
            this.txtThoiGianDen.EditValue = null;
            this.txtThoiGianDen.Location = new System.Drawing.Point(108, 126);
            this.txtThoiGianDen.Name = "txtThoiGianDen";
            this.txtThoiGianDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThoiGianDen.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtThoiGianDen.Size = new System.Drawing.Size(217, 20);
            this.txtThoiGianDen.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Thời Gian Đến";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(108, 80);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(217, 20);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số Điện Thoại";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(108, 36);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(217, 20);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Khách Hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gridControl_DatBan);
            this.groupControl2.Location = new System.Drawing.Point(446, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(405, 211);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Danh Sách Bàn Đặt";
            // 
            // gridControl_BanTrong
            // 
            this.gridControl_BanTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_BanTrong.Location = new System.Drawing.Point(2, 22);
            this.gridControl_BanTrong.MainView = this.gridView_BanTrong;
            this.gridControl_BanTrong.Name = "gridControl_BanTrong";
            this.gridControl_BanTrong.Size = new System.Drawing.Size(382, 387);
            this.gridControl_BanTrong.TabIndex = 0;
            this.gridControl_BanTrong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_BanTrong});
            // 
            // gridView_BanTrong
            // 
            this.gridView_BanTrong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView_BanTrong.GridControl = this.gridControl_BanTrong;
            this.gridView_BanTrong.Name = "gridView_BanTrong";
            this.gridView_BanTrong.OptionsSelection.MultiSelect = true;
            this.gridView_BanTrong.OptionsView.ShowGroupPanel = false;
            this.gridView_BanTrong.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_BanTrong_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Bàn";
            this.gridColumn1.FieldName = "MaBan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 38;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Khu Vực";
            this.gridColumn2.FieldName = "TenKhuVuc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 82;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vị Trí";
            this.gridColumn3.FieldName = "ViTri";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sức Chứa";
            this.gridColumn4.FieldName = "SucChua";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 60;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.gridControl_BanTrong);
            this.groupControl1.Location = new System.Drawing.Point(3, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 411);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Danh Sách Bàn";
            // 
            // btnDatBan
            // 
            this.btnDatBan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDatBan.Image = global::GUI.Properties.Resources.right_32;
            this.btnDatBan.Location = new System.Drawing.Point(395, 282);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(45, 42);
            this.btnDatBan.TabIndex = 13;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyDatBan
            // 
            this.btnHuyDatBan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHuyDatBan.Image = global::GUI.Properties.Resources.left_32;
            this.btnHuyDatBan.Location = new System.Drawing.Point(395, 330);
            this.btnHuyDatBan.Name = "btnHuyDatBan";
            this.btnHuyDatBan.Size = new System.Drawing.Size(45, 42);
            this.btnHuyDatBan.TabIndex = 12;
            this.btnHuyDatBan.Click += new System.EventHandler(this.btnHuyDatBan_Click);
            // 
            // UctrlDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnHuyDatBan);
            this.Controls.Add(this.btnKhongDatBan);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.groupTTDatBan);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UctrlDatBan";
            this.Size = new System.Drawing.Size(861, 480);
            this.Load += new System.EventHandler(this.UctrlDatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTDatBan)).EndInit();
            this.groupTTDatBan.ResumeLayout(false);
            this.groupTTDatBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_BanTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_BanTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKhongDatBan;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_BanDat;
        private DevExpress.XtraGrid.GridControl gridControl_DatBan;
        private DevExpress.XtraEditors.GroupControl groupTTDatBan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtThoiGianDen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl_BanTrong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_BanTrong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDatBan;
        private DevExpress.XtraEditors.SimpleButton btnHuyDatBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
