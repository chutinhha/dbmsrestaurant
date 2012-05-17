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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtSucChua = new DevExpress.XtraEditors.TextEdit();
            this.txtBanAn = new DevExpress.XtraEditors.TextEdit();
            this.txtViTri = new DevExpress.XtraEditors.TextEdit();
            this.txtKhuVuc = new DevExpress.XtraEditors.TextEdit();
            this.txtNhaHang = new DevExpress.XtraEditors.TextEdit();
            this.lb_LoaiBan = new DevExpress.XtraEditors.LabelControl();
            this.lb_NhaHang = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_KhuVuc = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaBan = new DevExpress.XtraEditors.LabelControl();
            this.btnXepBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.dateNow = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cbbSucChua = new System.Windows.Forms.ComboBox();
            this.cbbKhuVuc = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lv_BanDat = new System.Windows.Forms.ListView();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lv_BanAn);
            this.groupControl1.Location = new System.Drawing.Point(413, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(464, 250);
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
            this.lv_BanAn.Size = new System.Drawing.Size(460, 226);
            this.lv_BanAn.TabIndex = 0;
            this.lv_BanAn.UseCompatibleStateImageBehavior = false;
            this.lv_BanAn.SelectedIndexChanged += new System.EventHandler(this.lv_BanAn_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BanTrong_64.png");
            this.imageList1.Images.SetKeyName(1, "BanDangSuDung_64.png");
            this.imageList1.Images.SetKeyName(2, "BanDuocDat_64.png");
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
            this.groupControl2.Location = new System.Drawing.Point(7, 136);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(406, 203);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thông Tin Bàn Ăn";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(248, 97);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(140, 20);
            this.txtSucChua.TabIndex = 1;
            // 
            // txtBanAn
            // 
            this.txtBanAn.Location = new System.Drawing.Point(60, 97);
            this.txtBanAn.Name = "txtBanAn";
            this.txtBanAn.Size = new System.Drawing.Size(120, 20);
            this.txtBanAn.TabIndex = 1;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(248, 161);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(140, 20);
            this.txtViTri.TabIndex = 1;
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(60, 161);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(120, 20);
            this.txtKhuVuc.TabIndex = 1;
            // 
            // txtNhaHang
            // 
            this.txtNhaHang.Location = new System.Drawing.Point(60, 42);
            this.txtNhaHang.Name = "txtNhaHang";
            this.txtNhaHang.Size = new System.Drawing.Size(328, 20);
            this.txtNhaHang.TabIndex = 1;
            // 
            // lb_LoaiBan
            // 
            this.lb_LoaiBan.Location = new System.Drawing.Point(191, 100);
            this.lb_LoaiBan.Name = "lb_LoaiBan";
            this.lb_LoaiBan.Size = new System.Drawing.Size(45, 13);
            this.lb_LoaiBan.TabIndex = 0;
            this.lb_LoaiBan.Text = "Sức chứa";
            // 
            // lb_NhaHang
            // 
            this.lb_NhaHang.Location = new System.Drawing.Point(8, 45);
            this.lb_NhaHang.Name = "lb_NhaHang";
            this.lb_NhaHang.Size = new System.Drawing.Size(46, 13);
            this.lb_NhaHang.TabIndex = 0;
            this.lb_NhaHang.Text = "Nhà hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(191, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Vị trí bàn ăn";
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
            this.btnXepBanAn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXepBanAn.Appearance.Options.UseFont = true;
            this.btnXepBanAn.Appearance.Options.UseForeColor = true;
            this.btnXepBanAn.ImageIndex = 0;
            this.btnXepBanAn.ImageList = this.imageList2;
            this.btnXepBanAn.Location = new System.Drawing.Point(53, 345);
            this.btnXepBanAn.Name = "btnXepBanAn";
            this.btnXepBanAn.Size = new System.Drawing.Size(143, 41);
            this.btnXepBanAn.TabIndex = 5;
            this.btnXepBanAn.Text = "Xếp Bàn Ăn";
            this.btnXepBanAn.Click += new System.EventHandler(this.btnXepBanAn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(468, 405);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Bàn Trống";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.BanTrong_64;
            this.pictureEdit1.Location = new System.Drawing.Point(417, 391);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit1.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(604, 405);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Được Đặt ";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(724, 405);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Đang Sử Dụng";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit3.EditValue = global::GUI.Properties.Resources.BanDangSuDung_64;
            this.pictureEdit3.Location = new System.Drawing.Point(673, 391);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit3.TabIndex = 14;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit2.EditValue = global::GUI.Properties.Resources.BanDuocDat_64;
            this.pictureEdit2.Location = new System.Drawing.Point(553, 391);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(40, 40);
            this.pictureEdit2.TabIndex = 13;
            // 
            // dateNow
            // 
            this.dateNow.EditValue = null;
            this.dateNow.Location = new System.Drawing.Point(248, 16);
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
            this.labelControl9.Location = new System.Drawing.Point(203, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 16);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Ngày";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cbbSucChua);
            this.groupControl3.Controls.Add(this.cbbKhuVuc);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Location = new System.Drawing.Point(7, 42);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(404, 88);
            this.groupControl3.TabIndex = 17;
            this.groupControl3.Text = "Tùy Chọn";
            // 
            // cbbSucChua
            // 
            this.cbbSucChua.FormattingEnabled = true;
            this.cbbSucChua.Location = new System.Drawing.Point(263, 45);
            this.cbbSucChua.Name = "cbbSucChua";
            this.cbbSucChua.Size = new System.Drawing.Size(121, 21);
            this.cbbSucChua.TabIndex = 3;
            this.cbbSucChua.SelectedIndexChanged += new System.EventHandler(this.cbbSucChua_SelectedIndexChanged);
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.FormattingEnabled = true;
            this.cbbKhuVuc.Location = new System.Drawing.Point(68, 45);
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Size = new System.Drawing.Size(121, 21);
            this.cbbKhuVuc.TabIndex = 3;
            this.cbbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbbKhuVuc_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Khu vực";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(212, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Sức chứa";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.lv_BanDat);
            this.groupControl4.Location = new System.Drawing.Point(415, 259);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(462, 129);
            this.groupControl4.TabIndex = 18;
            this.groupControl4.Text = "Danh Sách Bàn Đặt";
            // 
            // lv_BanDat
            // 
            this.lv_BanDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_BanDat.FullRowSelect = true;
            this.lv_BanDat.GridLines = true;
            this.lv_BanDat.LargeImageList = this.imageList1;
            this.lv_BanDat.Location = new System.Drawing.Point(2, 22);
            this.lv_BanDat.Name = "lv_BanDat";
            this.lv_BanDat.Size = new System.Drawing.Size(458, 105);
            this.lv_BanDat.TabIndex = 0;
            this.lv_BanDat.UseCompatibleStateImageBehavior = false;
            this.lv_BanDat.SelectedIndexChanged += new System.EventHandler(this.lv_BanDat_SelectedIndexChanged);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh24;
            this.btnRefresh.Location = new System.Drawing.Point(219, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 41);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "BanDangSuDung_64.png");
            // 
            // UCtrlXepBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
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
            this.Size = new System.Drawing.Size(877, 444);
            this.Load += new System.EventHandler(this.UCtrlXepBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSucChua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbbSucChua;
        private System.Windows.Forms.ComboBox cbbKhuVuc;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.ListView lv_BanDat;
        private DevExpress.XtraEditors.LabelControl lb_LoaiBan;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ImageList imageList2;
    }
}
