namespace GUI.TiepTan
{
    partial class UCtrlXepBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCtrlXepBan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lv_BanAn = new System.Windows.Forms.ListView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lb_LoaiBan = new DevExpress.XtraEditors.LabelControl();
            this.lb_NhaHang = new DevExpress.XtraEditors.LabelControl();
            this.lb_KhuVuc = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaBan = new DevExpress.XtraEditors.LabelControl();
            this.btnXepBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateNow = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhaHang = new DevExpress.XtraEditors.TextEdit();
            this.txtBanAn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKhuVuc = new DevExpress.XtraEditors.TextEdit();
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lv_BanAn);
            this.groupControl1.Location = new System.Drawing.Point(415, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(459, 373);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh Sách Bàn Ăn";
            // 
            // lv_BanAn
            // 
            this.lv_BanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_BanAn.FullRowSelect = true;
            this.lv_BanAn.GridLines = true;
            this.lv_BanAn.LargeImageList = this.imageList1;
            this.lv_BanAn.Location = new System.Drawing.Point(2, 22);
            this.lv_BanAn.Name = "lv_BanAn";
            this.lv_BanAn.Size = new System.Drawing.Size(455, 349);
            this.lv_BanAn.TabIndex = 0;
            this.lv_BanAn.UseCompatibleStateImageBehavior = false;
            this.lv_BanAn.SelectedIndexChanged += new System.EventHandler(this.lv_BanAn_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtSucChua);
            this.groupControl2.Controls.Add(this.txtBanAn);
            this.groupControl2.Controls.Add(this.txtViTri);
            this.groupControl2.Controls.Add(this.txtKhuVuc);
            this.groupControl2.Controls.Add(this.txtNhaHang);
            this.groupControl2.Controls.Add(this.lb_LoaiBan);
            this.groupControl2.Controls.Add(this.lb_NhaHang);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.lb_KhuVuc);
            this.groupControl2.Controls.Add(this.lb_MaBan);
            this.groupControl2.Location = new System.Drawing.Point(5, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(406, 203);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Tùy Chọn";
            // 
            // lb_LoaiBan
            // 
            this.lb_LoaiBan.Location = new System.Drawing.Point(197, 100);
            this.lb_LoaiBan.Name = "lb_LoaiBan";
            this.lb_LoaiBan.Size = new System.Drawing.Size(45, 13);
            this.lb_LoaiBan.TabIndex = 0;
            this.lb_LoaiBan.Text = "Sức chứa";
            // 
            // lb_NhaHang
            // 
            this.lb_NhaHang.Location = new System.Drawing.Point(45, 45);
            this.lb_NhaHang.Name = "lb_NhaHang";
            this.lb_NhaHang.Size = new System.Drawing.Size(46, 13);
            this.lb_NhaHang.TabIndex = 0;
            this.lb_NhaHang.Text = "Nhà hàng";
            // 
            // lb_KhuVuc
            // 
            this.lb_KhuVuc.Location = new System.Drawing.Point(8, 164);
            this.lb_KhuVuc.Name = "lb_KhuVuc";
            this.lb_KhuVuc.Size = new System.Drawing.Size(39, 13);
            this.lb_KhuVuc.TabIndex = 0;
            this.lb_KhuVuc.Text = "Khu vực";
            // 
            // lb_MaBan
            // 
            this.lb_MaBan.Location = new System.Drawing.Point(8, 100);
            this.lb_MaBan.Name = "lb_MaBan";
            this.lb_MaBan.Size = new System.Drawing.Size(33, 13);
            this.lb_MaBan.TabIndex = 0;
            this.lb_MaBan.Text = "Bàn ăn";
            // 
            // btnXepBanAn
            // 
            this.btnXepBanAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXepBanAn.Appearance.Options.UseFont = true;
            this.btnXepBanAn.Location = new System.Drawing.Point(5, 270);
            this.btnXepBanAn.Name = "btnXepBanAn";
            this.btnXepBanAn.Size = new System.Drawing.Size(406, 83);
            this.btnXepBanAn.TabIndex = 5;
            this.btnXepBanAn.Text = "Xếp Bàn Ăn";
            this.btnXepBanAn.Click += new System.EventHandler(this.btnXepBanAn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(505, 433);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Bàn Trống";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.BanTrong_64;
            this.pictureEdit1.Location = new System.Drawing.Point(454, 419);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit1.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(641, 433);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Được Đặt ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(761, 433);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Đang Sử Dụng";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit3.EditValue = global::GUI.Properties.Resources.BanDangSuDung_64;
            this.pictureEdit3.Location = new System.Drawing.Point(710, 419);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit3.TabIndex = 14;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit2.EditValue = global::GUI.Properties.Resources.BanDuocDat_64;
            this.pictureEdit2.Location = new System.Drawing.Point(590, 419);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit2.TabIndex = 13;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BanTrong_64.png");
            this.imageList1.Images.SetKeyName(1, "BanDangSuDung_64.png");
            this.imageList1.Images.SetKeyName(2, "BanDuocDat_64.png");
            // 
            // dateNow
            // 
            this.dateNow.EditValue = null;
            this.dateNow.Location = new System.Drawing.Point(475, 16);
            this.dateNow.Name = "dateNow";
            this.dateNow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNow.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNow.Size = new System.Drawing.Size(163, 20);
            this.dateNow.TabIndex = 15;
            this.dateNow.EditValueChanged += new System.EventHandler(this.dateNow_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Location = new System.Drawing.Point(430, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 16);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Ngày";
            // 
            // txtNhaHang
            // 
            this.txtNhaHang.Location = new System.Drawing.Point(97, 42);
            this.txtNhaHang.Name = "txtNhaHang";
            this.txtNhaHang.Size = new System.Drawing.Size(260, 20);
            this.txtNhaHang.TabIndex = 1;
            // 
            // txtBanAn
            // 
            this.txtBanAn.Location = new System.Drawing.Point(58, 97);
            this.txtBanAn.Name = "txtBanAn";
            this.txtBanAn.Size = new System.Drawing.Size(120, 20);
            this.txtBanAn.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Vị trí";
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(58, 161);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(120, 20);
            this.txtKhuVuc.TabIndex = 1;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(224, 161);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(164, 20);
            this.txtViTri.TabIndex = 1;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(248, 97);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(140, 20);
            this.txtSucChua.TabIndex = 1;
            // 
            // UCtrlXepBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.btnXepBanAn);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCtrlXepBan";
            this.Size = new System.Drawing.Size(877, 473);
            this.Load += new System.EventHandler(this.UCtrlXepBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXepBanAn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.ListView lv_BanAn;
        private DevExpress.XtraEditors.LabelControl lb_LoaiBan;
        private DevExpress.XtraEditors.LabelControl lb_NhaHang;
        private DevExpress.XtraEditors.LabelControl lb_KhuVuc;
        private DevExpress.XtraEditors.LabelControl lb_MaBan;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.DateEdit dateNow;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSucChua;
        private DevExpress.XtraEditors.TextEdit txtBanAn;
        private DevExpress.XtraEditors.TextEdit txtViTri;
        private DevExpress.XtraEditors.TextEdit txtKhuVuc;
        private DevExpress.XtraEditors.TextEdit txtNhaHang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
