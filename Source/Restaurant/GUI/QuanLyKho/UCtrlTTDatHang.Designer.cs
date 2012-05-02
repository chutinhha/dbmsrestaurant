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
            this.btnHuyDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridThongTinDatHang = new DevExpress.XtraGrid.GridControl();
            this.btnCapNhatDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongTinDatHang = new DevExpress.XtraEditors.GroupControl();
            this.groupTuyChon = new DevExpress.XtraEditors.GroupControl();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.cboTinhTrang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbTuNgay = new DevExpress.XtraEditors.LabelControl();
            this.cboNguyenLieu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbNguyenLieu = new DevExpress.XtraEditors.LabelControl();
            this.cboNCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbNCC = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).BeginInit();
            this.groupThongTinDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTuyChon)).BeginInit();
            this.groupTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).BeginInit();
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridThongTinDatHang;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridThongTinDatHang
            // 
            this.gridThongTinDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridThongTinDatHang.Location = new System.Drawing.Point(2, 22);
            this.gridThongTinDatHang.MainView = this.gridView2;
            this.gridThongTinDatHang.Name = "gridThongTinDatHang";
            this.gridThongTinDatHang.Size = new System.Drawing.Size(539, 400);
            this.gridThongTinDatHang.TabIndex = 0;
            this.gridThongTinDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            // 
            // groupThongTinDatHang
            // 
            this.groupThongTinDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTinDatHang.Controls.Add(this.gridThongTinDatHang);
            this.groupThongTinDatHang.Location = new System.Drawing.Point(334, 12);
            this.groupThongTinDatHang.Name = "groupThongTinDatHang";
            this.groupThongTinDatHang.Size = new System.Drawing.Size(543, 424);
            this.groupThongTinDatHang.TabIndex = 19;
            this.groupThongTinDatHang.Text = "Thông Tin Đặt Hàng";
            // 
            // groupTuyChon
            // 
            this.groupTuyChon.Controls.Add(this.dateDenNgay);
            this.groupTuyChon.Controls.Add(this.dateTuNgay);
            this.groupTuyChon.Controls.Add(this.cboTinhTrang);
            this.groupTuyChon.Controls.Add(this.labelControl5);
            this.groupTuyChon.Controls.Add(this.labelControl4);
            this.groupTuyChon.Controls.Add(this.lbTuNgay);
            this.groupTuyChon.Controls.Add(this.cboNguyenLieu);
            this.groupTuyChon.Controls.Add(this.lbNguyenLieu);
            this.groupTuyChon.Controls.Add(this.cboNCC);
            this.groupTuyChon.Controls.Add(this.lbNCC);
            this.groupTuyChon.Location = new System.Drawing.Point(3, 12);
            this.groupTuyChon.Name = "groupTuyChon";
            this.groupTuyChon.Size = new System.Drawing.Size(325, 253);
            this.groupTuyChon.TabIndex = 20;
            this.groupTuyChon.Text = "Tùy Chọn";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(102, 165);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDenNgay.Size = new System.Drawing.Size(198, 20);
            this.dateDenNgay.TabIndex = 2;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(102, 124);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTuNgay.Size = new System.Drawing.Size(198, 20);
            this.dateTuNgay.TabIndex = 2;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.Location = new System.Drawing.Point(102, 205);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTinhTrang.Size = new System.Drawing.Size(198, 20);
            this.cboTinhTrang.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 209);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tình Trạng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Đến Ngày";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.Location = new System.Drawing.Point(26, 127);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(41, 13);
            this.lbTuNgay.TabIndex = 0;
            this.lbTuNgay.Text = "Từ Ngày";
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.Location = new System.Drawing.Point(102, 79);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguyenLieu.Size = new System.Drawing.Size(198, 20);
            this.cboNguyenLieu.TabIndex = 1;
            // 
            // lbNguyenLieu
            // 
            this.lbNguyenLieu.Location = new System.Drawing.Point(26, 86);
            this.lbNguyenLieu.Name = "lbNguyenLieu";
            this.lbNguyenLieu.Size = new System.Drawing.Size(59, 13);
            this.lbNguyenLieu.TabIndex = 0;
            this.lbNguyenLieu.Text = "Nguyên Liệu";
            // 
            // cboNCC
            // 
            this.cboNCC.Location = new System.Drawing.Point(102, 41);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNCC.Size = new System.Drawing.Size(198, 20);
            this.cboNCC.TabIndex = 1;
            // 
            // lbNCC
            // 
            this.lbNCC.Location = new System.Drawing.Point(26, 45);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(69, 13);
            this.lbNCC.TabIndex = 0;
            this.lbNCC.Text = "Nhà Cung Cấp";
            // 
            // UCtrlTTDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.btnCapNhatDatHang);
            this.Controls.Add(this.btnXoaDatHang);
            this.Controls.Add(this.groupThongTinDatHang);
            this.Controls.Add(this.groupTuyChon);
            this.Controls.Add(this.btnHuyDatHang);
            this.Name = "UCtrlTTDatHang";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongTinDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).EndInit();
            this.groupThongTinDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTuyChon)).EndInit();
            this.groupTuyChon.ResumeLayout(false);
            this.groupTuyChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuyDatHang;
        private DevExpress.XtraEditors.SimpleButton btnDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridThongTinDatHang;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDatHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaDatHang;
        private DevExpress.XtraEditors.GroupControl groupThongTinDatHang;
        private DevExpress.XtraEditors.GroupControl groupTuyChon;
        private DevExpress.XtraEditors.ComboBoxEdit cboTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbTuNgay;
        private DevExpress.XtraEditors.ComboBoxEdit cboNguyenLieu;
        private DevExpress.XtraEditors.LabelControl lbNguyenLieu;
        private DevExpress.XtraEditors.ComboBoxEdit cboNCC;
        private DevExpress.XtraEditors.LabelControl lbNCC;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;


    }
}
