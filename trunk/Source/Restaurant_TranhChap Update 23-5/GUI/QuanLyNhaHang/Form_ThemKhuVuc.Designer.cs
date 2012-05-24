namespace GUI.QuanLyNhaHang
{
    partial class Form_ThemKhuVuc
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
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaKV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(155, 122);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(118, 20);
            this.txtViTri.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Vị Trí";
            // 
            // txtTenKV
            // 
            this.txtTenKV.Location = new System.Drawing.Point(155, 72);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(118, 20);
            this.txtTenKV.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Tên Khu Vực";
            // 
            // txtMaKV
            // 
            this.txtMaKV.Location = new System.Drawing.Point(155, 26);
            this.txtMaKV.Name = "txtMaKV";
            this.txtMaKV.Size = new System.Drawing.Size(118, 20);
            this.txtMaKV.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Mã Khu Vực";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.close_16;
            this.btnThoat.Location = new System.Drawing.Point(186, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 29);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::GUI.Properties.Resources.add_16;
            this.btnOK.Location = new System.Drawing.Point(65, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 29);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Đồng Ý";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form_ThemKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(326, 243);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTenKV);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaKV);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form_ThemKhuVuc";
            this.Text = "Form_ThemKhuVuc";
            this.Load += new System.EventHandler(this.Form_ThemKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.TextEdit txtViTri;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenKV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaKV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}