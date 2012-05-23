namespace GUI.QuanLyKho
{
    partial class frmNhaCungCap_Them_CapNhat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNL = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNL = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lvNguyenLieuChon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lvNguyenLieu = new System.Windows.Forms.ListView();
            this.cl_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_nguyenlieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiemUuTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemUuTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDongY);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnThemNL);
            this.panelControl1.Controls.Add(this.btnXoaNL);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(664, 512);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(475, 468);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 32;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(564, 468);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            // 
            // btnThemNL
            // 
            this.btnThemNL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThemNL.Image = global::GUI.Properties.Resources.right_32;
            this.btnThemNL.Location = new System.Drawing.Point(310, 240);
            this.btnThemNL.Name = "btnThemNL";
            this.btnThemNL.Size = new System.Drawing.Size(45, 42);
            this.btnThemNL.TabIndex = 13;
            this.btnThemNL.Click += new System.EventHandler(this.btnThemNL_Click);
            // 
            // btnXoaNL
            // 
            this.btnXoaNL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnXoaNL.Image = global::GUI.Properties.Resources.left_32;
            this.btnXoaNL.Location = new System.Drawing.Point(310, 288);
            this.btnXoaNL.Name = "btnXoaNL";
            this.btnXoaNL.Size = new System.Drawing.Size(45, 42);
            this.btnXoaNL.TabIndex = 12;
            this.btnXoaNL.Click += new System.EventHandler(this.btnXoaNL_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lvNguyenLieuChon);
            this.groupControl2.Location = new System.Drawing.Point(376, 131);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(265, 324);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Nguyên Liệu Từ Nhà Cung Cấp";
            // 
            // lvNguyenLieuChon
            // 
            this.lvNguyenLieuChon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvNguyenLieuChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNguyenLieuChon.FullRowSelect = true;
            this.lvNguyenLieuChon.GridLines = true;
            this.lvNguyenLieuChon.Location = new System.Drawing.Point(2, 22);
            this.lvNguyenLieuChon.MultiSelect = false;
            this.lvNguyenLieuChon.Name = "lvNguyenLieuChon";
            this.lvNguyenLieuChon.Size = new System.Drawing.Size(261, 300);
            this.lvNguyenLieuChon.TabIndex = 1;
            this.lvNguyenLieuChon.UseCompatibleStateImageBehavior = false;
            this.lvNguyenLieuChon.View = System.Windows.Forms.View.Details;
            this.lvNguyenLieuChon.DoubleClick += new System.EventHandler(this.lvNguyenLieuChon_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nguyên Liệu";
            this.columnHeader2.Width = 219;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lvNguyenLieu);
            this.groupControl3.Location = new System.Drawing.Point(25, 131);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(265, 324);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh Mục Nguyên Liệu";
            // 
            // lvNguyenLieu
            // 
            this.lvNguyenLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_STT,
            this.cl_nguyenlieu});
            this.lvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNguyenLieu.FullRowSelect = true;
            this.lvNguyenLieu.GridLines = true;
            this.lvNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.lvNguyenLieu.MultiSelect = false;
            this.lvNguyenLieu.Name = "lvNguyenLieu";
            this.lvNguyenLieu.Size = new System.Drawing.Size(261, 300);
            this.lvNguyenLieu.TabIndex = 1;
            this.lvNguyenLieu.UseCompatibleStateImageBehavior = false;
            this.lvNguyenLieu.View = System.Windows.Forms.View.Details;
            this.lvNguyenLieu.DoubleClick += new System.EventHandler(this.lvNguyenLieu_DoubleClick);
            // 
            // cl_STT
            // 
            this.cl_STT.Text = "STT";
            this.cl_STT.Width = 30;
            // 
            // cl_nguyenlieu
            // 
            this.cl_nguyenlieu.Text = "Nguyên Liệu";
            this.cl_nguyenlieu.Width = 209;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDiemUuTien);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSoDienThoai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTenNCC);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(24, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(617, 106);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txtDiemUuTien
            // 
            this.txtDiemUuTien.Location = new System.Drawing.Point(471, 68);
            this.txtDiemUuTien.Name = "txtDiemUuTien";
            this.txtDiemUuTien.Properties.Mask.EditMask = "f0";
            this.txtDiemUuTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiemUuTien.Size = new System.Drawing.Size(125, 20);
            this.txtDiemUuTien.TabIndex = 1;
            this.txtDiemUuTien.TextChanged += new System.EventHandler(this.txtDiemUuTien_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(397, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Điểm Ưu Tiên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 68);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(261, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Địa Chỉ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(471, 37);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(125, 20);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(397, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số Điện Thoại";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(112, 37);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(261, 20);
            this.txtTenNCC.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Nhà Cung Cấp";
            // 
            // frmNhaCungCap_Them_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(664, 512);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhaCungCap_Them_CapNhat";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Them_CapNhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemUuTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDiemUuTien;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenNCC;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnThemNL;
        private DevExpress.XtraEditors.SimpleButton btnXoaNL;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView lvNguyenLieuChon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvNguyenLieu;
        private System.Windows.Forms.ColumnHeader cl_STT;
        private System.Windows.Forms.ColumnHeader cl_nguyenlieu;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuy;

    }
}