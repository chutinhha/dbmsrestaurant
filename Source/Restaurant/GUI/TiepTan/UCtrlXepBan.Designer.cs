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
            this.btnDocBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.btnDocDatBan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDocBanAn_begin = new DevExpress.XtraEditors.SimpleButton();
            this.btnXepBanAn_Commit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.txtBanAn.Location = new System.Drawing.Point(58, 97);
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
            this.txtKhuVuc.Location = new System.Drawing.Point(58, 161);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(120, 20);
            this.txtKhuVuc.TabIndex = 1;
            // 
            // txtNhaHang
            // 
            this.txtNhaHang.Location = new System.Drawing.Point(97, 42);
            this.txtNhaHang.Name = "txtNhaHang";
            this.txtNhaHang.Size = new System.Drawing.Size(260, 20);
            this.txtNhaHang.TabIndex = 1;
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(196, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Vị trí";
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
            this.btnXepBanAn.Location = new System.Drawing.Point(7, 345);
            this.btnXepBanAn.Name = "btnXepBanAn";
            this.btnXepBanAn.Size = new System.Drawing.Size(130, 86);
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
            // btnDocBanAn
            // 
            this.btnDocBanAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocBanAn.Appearance.Options.UseFont = true;
            this.btnDocBanAn.Location = new System.Drawing.Point(8, 49);
            this.btnDocBanAn.Name = "btnDocBanAn";
            this.btnDocBanAn.Size = new System.Drawing.Size(113, 32);
            this.btnDocBanAn.TabIndex = 5;
            this.btnDocBanAn.Text = "Đọc Bàn Ăn";
            this.btnDocBanAn.Click += new System.EventHandler(this.btnDocBanAn_Click);
            // 
            // btnDocDatBan
            // 
            this.btnDocDatBan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocDatBan.Appearance.Options.UseFont = true;
            this.btnDocDatBan.Location = new System.Drawing.Point(8, 5);
            this.btnDocDatBan.Name = "btnDocDatBan";
            this.btnDocDatBan.Size = new System.Drawing.Size(113, 32);
            this.btnDocDatBan.TabIndex = 5;
            this.btnDocDatBan.Text = "Đọc Đặt Bàn";
            this.btnDocDatBan.Click += new System.EventHandler(this.btnDocDatBan_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDocBanAn_begin);
            this.panelControl2.Controls.Add(this.btnXepBanAn_Commit);
            this.panelControl2.Location = new System.Drawing.Point(143, 345);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(128, 86);
            this.panelControl2.TabIndex = 19;
            // 
            // btnDocBanAn_begin
            // 
            this.btnDocBanAn_begin.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocBanAn_begin.Appearance.Options.UseFont = true;
            this.btnDocBanAn_begin.Location = new System.Drawing.Point(8, 5);
            this.btnDocBanAn_begin.Name = "btnDocBanAn_begin";
            this.btnDocBanAn_begin.Size = new System.Drawing.Size(113, 32);
            this.btnDocBanAn_begin.TabIndex = 5;
            this.btnDocBanAn_begin.Text = "Đọc Bàn Ăn";
            this.btnDocBanAn_begin.Click += new System.EventHandler(this.btnDocBanAn_begin_Click);
            // 
            // btnXepBanAn_Commit
            // 
            this.btnXepBanAn_Commit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXepBanAn_Commit.Appearance.Options.UseFont = true;
            this.btnXepBanAn_Commit.Location = new System.Drawing.Point(8, 49);
            this.btnXepBanAn_Commit.Name = "btnXepBanAn_Commit";
            this.btnXepBanAn_Commit.Size = new System.Drawing.Size(113, 32);
            this.btnXepBanAn_Commit.TabIndex = 5;
            this.btnXepBanAn_Commit.Text = "Xếp Bàn Ăn";
            this.btnXepBanAn_Commit.Click += new System.EventHandler(this.btnXepBanAn_Commit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDocDatBan);
            this.panelControl1.Controls.Add(this.btnDocBanAn);
            this.panelControl1.Location = new System.Drawing.Point(285, 345);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(128, 86);
            this.panelControl1.TabIndex = 19;
            // 
            // UCtrlXepBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton btnDocBanAn;
        private DevExpress.XtraEditors.SimpleButton btnDocDatBan;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDocBanAn_begin;
        private DevExpress.XtraEditors.SimpleButton btnXepBanAn_Commit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
