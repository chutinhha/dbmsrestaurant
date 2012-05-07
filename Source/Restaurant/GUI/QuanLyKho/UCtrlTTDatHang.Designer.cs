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
            this.gridNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gvNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).BeginInit();
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
            this.groupThongTinDatHang.Controls.Add(this.gridNguyenLieu);
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
            // gridNguyenLieu
            // 
            this.gridNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.gridNguyenLieu.MainView = this.gvNguyenLieu;
            this.gridNguyenLieu.Name = "gridNguyenLieu";
            this.gridNguyenLieu.Size = new System.Drawing.Size(539, 400);
            this.gridNguyenLieu.TabIndex = 1;
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
            this.clGia,
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
            // clTenNL
            // 
            this.clTenNL.Caption = "Tên Nguyên Liệu";
            this.clTenNL.FieldName = "TenNL";
            this.clTenNL.Name = "clTenNL";
            this.clTenNL.Visible = true;
            this.clTenNL.VisibleIndex = 1;
            this.clTenNL.Width = 122;
            // 
            // clGia
            // 
            this.clGia.Caption = "Giá";
            this.clGia.FieldName = "Gia";
            this.clGia.Name = "clGia";
            this.clGia.Visible = true;
            this.clGia.VisibleIndex = 2;
            this.clGia.Width = 122;
            // 
            // clDonVi
            // 
            this.clDonVi.Caption = "Đơn Vị";
            this.clDonVi.FieldName = "DonVi";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.Visible = true;
            this.clDonVi.VisibleIndex = 3;
            this.clDonVi.Width = 122;
            // 
            // clSoLuongTon
            // 
            this.clSoLuongTon.Caption = "Số Lượng Tồn";
            this.clSoLuongTon.FieldName = "SoLuongTon";
            this.clSoLuongTon.Name = "clSoLuongTon";
            this.clSoLuongTon.Visible = true;
            this.clSoLuongTon.VisibleIndex = 4;
            this.clSoLuongTon.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuyDatHang;
        private DevExpress.XtraEditors.SimpleButton btnDatHang;
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
        private DevExpress.XtraGrid.GridControl gridNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNL;
        private DevExpress.XtraGrid.Columns.GridColumn clGia;
        private DevExpress.XtraGrid.Columns.GridColumn clDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongTon;


    }
}
