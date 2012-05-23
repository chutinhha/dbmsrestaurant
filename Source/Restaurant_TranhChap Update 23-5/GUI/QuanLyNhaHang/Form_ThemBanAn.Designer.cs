namespace GUI.QuanLyNhaHang
{
    partial class Form_ThemBanAn
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
            this.cbbNhaHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbSucChua = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbbKhuVuc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNhaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNhaHang
            // 
            this.cbbNhaHang.Location = new System.Drawing.Point(152, 151);
            this.cbbNhaHang.Name = "cbbNhaHang";
            this.cbbNhaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNhaHang.Size = new System.Drawing.Size(100, 20);
            this.cbbNhaHang.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Nhà Hàng";
            // 
            // cbbSucChua
            // 
            this.cbbSucChua.Location = new System.Drawing.Point(152, 111);
            this.cbbSucChua.Name = "cbbSucChua";
            this.cbbSucChua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbSucChua.Size = new System.Drawing.Size(100, 20);
            this.cbbSucChua.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Sức Chứa";
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.Location = new System.Drawing.Point(152, 69);
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbKhuVuc.Size = new System.Drawing.Size(100, 20);
            this.cbbKhuVuc.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Khu Vực";
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(152, 28);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(100, 20);
            this.txtMaBan.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Mã Bàn";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.close_16;
            this.btnThoat.Location = new System.Drawing.Point(170, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 30);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::GUI.Properties.Resources.add_16;
            this.btnOK.Location = new System.Drawing.Point(35, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 30);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Đồng Ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form_ThemBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(308, 281);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbbNhaHang);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbbSucChua);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbbKhuVuc);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form_ThemBanAn";
            this.Text = "Form_ThemBanAn";
            this.Load += new System.EventHandler(this.Form_ThemBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNhaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.ComboBoxEdit cbbNhaHang;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbbSucChua;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbbKhuVuc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaBan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}