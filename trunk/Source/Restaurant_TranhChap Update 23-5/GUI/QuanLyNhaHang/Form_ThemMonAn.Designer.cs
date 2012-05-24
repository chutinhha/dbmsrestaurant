namespace GUI.QuanLyNhaHang
{
    partial class Form_ThemMonAn
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
            this.txtDonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.cbbLoaiMonAn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenMonAn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lcTenMonAn = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiMonAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonAn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(148, 156);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(93, 20);
            this.txtDonViTinh.TabIndex = 20;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(148, 120);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(93, 20);
            this.txtGia.TabIndex = 19;
            // 
            // cbbLoaiMonAn
            // 
            this.cbbLoaiMonAn.Location = new System.Drawing.Point(148, 81);
            this.cbbLoaiMonAn.Name = "cbbLoaiMonAn";
            this.cbbLoaiMonAn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiMonAn.Size = new System.Drawing.Size(147, 20);
            this.cbbLoaiMonAn.TabIndex = 18;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(148, 45);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(147, 20);
            this.txtTenMonAn.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Đơn Vị Tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Loại Món Ăn";
            // 
            // lcTenMonAn
            // 
            this.lcTenMonAn.Location = new System.Drawing.Point(52, 48);
            this.lcTenMonAn.Name = "lcTenMonAn";
            this.lcTenMonAn.Size = new System.Drawing.Size(57, 13);
            this.lcTenMonAn.TabIndex = 12;
            this.lcTenMonAn.Text = "Tên Món Ăn";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.delete_16;
            this.btnThoat.Location = new System.Drawing.Point(199, 213);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 29);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Image = global::GUI.Properties.Resources.add_16;
            this.btnDongY.Location = new System.Drawing.Point(52, 213);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(106, 29);
            this.btnDongY.TabIndex = 22;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // Form_ThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(347, 271);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.cbbLoaiMonAn);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lcTenMonAn);
            this.Name = "Form_ThemMonAn";
            this.Text = "Form_ThemMonAn";
            this.Load += new System.EventHandler(this.Form_ThemMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiMonAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMonAn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.TextEdit txtDonViTinh;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private DevExpress.XtraEditors.ComboBoxEdit cbbLoaiMonAn;
        private DevExpress.XtraEditors.TextEdit txtTenMonAn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lcTenMonAn;
    }
}