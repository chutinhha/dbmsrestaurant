namespace GUI.TiepTan
{
    partial class FrmCapNhatBanDat
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
            this.calcEdit_ThoiGianDen = new DevExpress.XtraEditors.DateEdit();
            this.cbbHienTrang = new System.Windows.Forms.ComboBox();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.cbbBanAn = new System.Windows.Forms.ComboBox();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_ThoiGianDen.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_ThoiGianDen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.calcEdit_ThoiGianDen);
            this.panelControl1.Controls.Add(this.cbbHienTrang);
            this.panelControl1.Controls.Add(this.cbbKhachHang);
            this.panelControl1.Controls.Add(this.cbbBanAn);
            this.panelControl1.Controls.Add(this.btnDongY);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(347, 201);
            this.panelControl1.TabIndex = 1;
            // 
            // calcEdit_ThoiGianDen
            // 
            this.calcEdit_ThoiGianDen.EditValue = null;
            this.calcEdit_ThoiGianDen.Location = new System.Drawing.Point(195, 101);
            this.calcEdit_ThoiGianDen.Name = "calcEdit_ThoiGianDen";
            this.calcEdit_ThoiGianDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit_ThoiGianDen.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.calcEdit_ThoiGianDen.Size = new System.Drawing.Size(121, 20);
            this.calcEdit_ThoiGianDen.TabIndex = 30;
            // 
            // cbbHienTrang
            // 
            this.cbbHienTrang.FormattingEnabled = true;
            this.cbbHienTrang.Items.AddRange(new object[] {
            "Đã đến ăn",
            "Chưa đến ăn"});
            this.cbbHienTrang.Location = new System.Drawing.Point(28, 100);
            this.cbbHienTrang.Name = "cbbHienTrang";
            this.cbbHienTrang.Size = new System.Drawing.Size(121, 21);
            this.cbbHienTrang.TabIndex = 29;
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(195, 35);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cbbKhachHang.TabIndex = 29;
            // 
            // cbbBanAn
            // 
            this.cbbBanAn.FormattingEnabled = true;
            this.cbbBanAn.Location = new System.Drawing.Point(28, 35);
            this.cbbBanAn.Name = "cbbBanAn";
            this.cbbBanAn.Size = new System.Drawing.Size(121, 21);
            this.cbbBanAn.TabIndex = 29;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(155, 157);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 28;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(244, 157);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(28, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Hiện Trạng";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(195, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Thời Gian Đến";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(195, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Khách Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bàn Ăn";
            // 
            // FrmCapNhatBanDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 201);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCapNhatBanDat";
            this.Text = "FrmCapNhatBanDat";
            this.Load += new System.EventHandler(this.FrmCapNhatBanDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_ThoiGianDen.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_ThoiGianDen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbbHienTrang;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.ComboBox cbbBanAn;
        private DevExpress.XtraEditors.DateEdit calcEdit_ThoiGianDen;

    }
}