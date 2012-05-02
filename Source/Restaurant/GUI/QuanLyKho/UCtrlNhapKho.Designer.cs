namespace GUI.QuanLyKho
{
    partial class UCtrlNhapKho
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
            this.btnDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.cboNguyenLieu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbNguyenLieu = new DevExpress.XtraEditors.LabelControl();
            this.cboNCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupTuyChon = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lbNgayNhap = new DevExpress.XtraEditors.LabelControl();
            this.lbNCC = new DevExpress.XtraEditors.LabelControl();
            this.groupThongTinDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridDSPhieuNhapKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnInDSNV = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTuyChon)).BeginInit();
            this.groupTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).BeginInit();
            this.groupThongTinDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSPhieuNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatHang
            // 
            this.btnDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatHang.Image = global::GUI.Properties.Resources.add_16;
            this.btnDatHang.Location = new System.Drawing.Point(456, 442);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(168, 26);
            this.btnDatHang.TabIndex = 27;
            this.btnDatHang.Text = "Thêm Phiếu Nhập Kho";
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.Location = new System.Drawing.Point(366, 33);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguyenLieu.Size = new System.Drawing.Size(198, 20);
            this.cboNguyenLieu.TabIndex = 1;
            // 
            // lbNguyenLieu
            // 
            this.lbNguyenLieu.Location = new System.Drawing.Point(294, 37);
            this.lbNguyenLieu.Name = "lbNguyenLieu";
            this.lbNguyenLieu.Size = new System.Drawing.Size(59, 13);
            this.lbNguyenLieu.TabIndex = 0;
            this.lbNguyenLieu.Text = "Nguyên Liệu";
            // 
            // cboNCC
            // 
            this.cboNCC.Location = new System.Drawing.Point(83, 33);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNCC.Size = new System.Drawing.Size(198, 20);
            this.cboNCC.TabIndex = 1;
            // 
            // groupTuyChon
            // 
            this.groupTuyChon.Controls.Add(this.dateEdit1);
            this.groupTuyChon.Controls.Add(this.lbNgayNhap);
            this.groupTuyChon.Controls.Add(this.cboNguyenLieu);
            this.groupTuyChon.Controls.Add(this.lbNguyenLieu);
            this.groupTuyChon.Controls.Add(this.cboNCC);
            this.groupTuyChon.Controls.Add(this.lbNCC);
            this.groupTuyChon.Location = new System.Drawing.Point(8, 12);
            this.groupTuyChon.Name = "groupTuyChon";
            this.groupTuyChon.Size = new System.Drawing.Size(851, 68);
            this.groupTuyChon.TabIndex = 26;
            this.groupTuyChon.Text = "Tùy Chọn";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(643, 33);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(189, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.Location = new System.Drawing.Point(577, 37);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(53, 13);
            this.lbNgayNhap.TabIndex = 0;
            this.lbNgayNhap.Text = "Ngày Nhập";
            // 
            // lbNCC
            // 
            this.lbNCC.Location = new System.Drawing.Point(7, 36);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(69, 13);
            this.lbNCC.TabIndex = 0;
            this.lbNCC.Text = "Nhà Cung Cấp";
            // 
            // groupThongTinDatHang
            // 
            this.groupThongTinDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTinDatHang.Controls.Add(this.gridDSPhieuNhapKho);
            this.groupThongTinDatHang.Location = new System.Drawing.Point(8, 88);
            this.groupThongTinDatHang.Name = "groupThongTinDatHang";
            this.groupThongTinDatHang.Size = new System.Drawing.Size(869, 348);
            this.groupThongTinDatHang.TabIndex = 25;
            this.groupThongTinDatHang.Text = "Danh Sách Phiếu Nhập Kho";
            // 
            // gridDSPhieuNhapKho
            // 
            this.gridDSPhieuNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSPhieuNhapKho.Location = new System.Drawing.Point(2, 22);
            this.gridDSPhieuNhapKho.MainView = this.gridView1;
            this.gridDSPhieuNhapKho.Name = "gridDSPhieuNhapKho";
            this.gridDSPhieuNhapKho.Size = new System.Drawing.Size(865, 324);
            this.gridDSPhieuNhapKho.TabIndex = 0;
            this.gridDSPhieuNhapKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridDSPhieuNhapKho;
            this.gridView1.Name = "gridView1";
            // 
            // btnInDSNV
            // 
            this.btnInDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSNV.Image = global::GUI.Properties.Resources.print_24;
            this.btnInDSNV.Location = new System.Drawing.Point(630, 442);
            this.btnInDSNV.Name = "btnInDSNV";
            this.btnInDSNV.Size = new System.Drawing.Size(106, 26);
            this.btnInDSNV.TabIndex = 28;
            this.btnInDSNV.Text = "In Danh Sách";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::GUI.Properties.Resources.BieuDo_16;
            this.simpleButton1.Location = new System.Drawing.Point(742, 442);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(133, 26);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "Biểu Đồ Thống Kê";
            // 
            // UCtrlNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnInDSNV);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.groupTuyChon);
            this.Controls.Add(this.groupThongTinDatHang);
            this.Name = "UCtrlNhapKho";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.cboNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTuyChon)).EndInit();
            this.groupTuyChon.ResumeLayout(false);
            this.groupTuyChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinDatHang)).EndInit();
            this.groupThongTinDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSPhieuNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDatHang;
        private DevExpress.XtraEditors.ComboBoxEdit cboNguyenLieu;
        private DevExpress.XtraEditors.LabelControl lbNguyenLieu;
        private DevExpress.XtraEditors.ComboBoxEdit cboNCC;
        private DevExpress.XtraEditors.GroupControl groupTuyChon;
        private DevExpress.XtraEditors.LabelControl lbNCC;
        private DevExpress.XtraEditors.GroupControl groupThongTinDatHang;
        private DevExpress.XtraEditors.SimpleButton btnInDSNV;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridDSPhieuNhapKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbNgayNhap;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}
