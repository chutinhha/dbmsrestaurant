namespace GUI.ThuNgan
{
    partial class frmGhepBan
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
            this.cbboxChuyenVaoBan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listViewDSBanGhep = new System.Windows.Forms.ListView();
            this.banghep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaygiosudung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mahd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listViewDSBanDangDung = new System.Windows.Forms.ListView();
            this.ban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaygio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxChuyenVaoBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDongY);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.cbboxChuyenVaoBan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(584, 362);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(408, 318);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 30;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(497, 318);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbboxChuyenVaoBan
            // 
            this.cbboxChuyenVaoBan.Location = new System.Drawing.Point(404, 269);
            this.cbboxChuyenVaoBan.Name = "cbboxChuyenVaoBan";
            this.cbboxChuyenVaoBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbboxChuyenVaoBan.Size = new System.Drawing.Size(123, 20);
            this.cbboxChuyenVaoBan.TabIndex = 14;
            this.cbboxChuyenVaoBan.SelectedIndexChanged += new System.EventHandler(this.cbboxChuyenVaoBan_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(319, 272);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Chuyển Vào Bàn";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.down_32;
            this.pictureEdit1.Location = new System.Drawing.Point(404, 194);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(41, 58);
            this.pictureEdit1.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Image = global::GUI.Properties.Resources.right_32;
            this.simpleButton1.Location = new System.Drawing.Point(223, 58);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(45, 42);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton4.Image = global::GUI.Properties.Resources.left_32;
            this.simpleButton4.Location = new System.Drawing.Point(223, 106);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(45, 42);
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listViewDSBanGhep);
            this.groupControl2.Location = new System.Drawing.Point(283, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(289, 176);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Danh Sách Bàn Ghép";
            // 
            // listViewDSBanGhep
            // 
            this.listViewDSBanGhep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.banghep,
            this.ngaygiosudung,
            this.mahd});
            this.listViewDSBanGhep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDSBanGhep.FullRowSelect = true;
            this.listViewDSBanGhep.GridLines = true;
            this.listViewDSBanGhep.Location = new System.Drawing.Point(2, 22);
            this.listViewDSBanGhep.Name = "listViewDSBanGhep";
            this.listViewDSBanGhep.Size = new System.Drawing.Size(285, 152);
            this.listViewDSBanGhep.TabIndex = 1;
            this.listViewDSBanGhep.UseCompatibleStateImageBehavior = false;
            this.listViewDSBanGhep.View = System.Windows.Forms.View.Details;
            // 
            // banghep
            // 
            this.banghep.Text = "Bàn";
            // 
            // ngaygiosudung
            // 
            this.ngaygiosudung.Text = "Thời gian bắt đầu";
            this.ngaygiosudung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ngaygiosudung.Width = 160;
            // 
            // mahd
            // 
            this.mahd.Text = "Hoá đơn";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listViewDSBanDangDung);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(193, 338);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Bàn Đang Sử Dụng";
            // 
            // listViewDSBanDangDung
            // 
            this.listViewDSBanDangDung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ban,
            this.ngaygio});
            this.listViewDSBanDangDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDSBanDangDung.FullRowSelect = true;
            this.listViewDSBanDangDung.GridLines = true;
            this.listViewDSBanDangDung.Location = new System.Drawing.Point(2, 22);
            this.listViewDSBanDangDung.Name = "listViewDSBanDangDung";
            this.listViewDSBanDangDung.Size = new System.Drawing.Size(189, 314);
            this.listViewDSBanDangDung.TabIndex = 0;
            this.listViewDSBanDangDung.UseCompatibleStateImageBehavior = false;
            this.listViewDSBanDangDung.View = System.Windows.Forms.View.Details;
            this.listViewDSBanDangDung.DoubleClick += new System.EventHandler(this.listViewDSBanDangDung_DoubleClick);
            // 
            // ban
            // 
            this.ban.Text = "Bàn";
            this.ban.Width = 65;
            // 
            // ngaygio
            // 
            this.ngaygio.Text = "Thời gian bắt đầu";
            this.ngaygio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ngaygio.Width = 120;
            // 
            // frmGhepBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGhepBan";
            this.Text = "Gộp Bàn";
            this.Load += new System.EventHandler(this.frmGhepBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxChuyenVaoBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbboxChuyenVaoBan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.ListView listViewDSBanGhep;
        private System.Windows.Forms.ListView listViewDSBanDangDung;
        private System.Windows.Forms.ColumnHeader ban;
        private System.Windows.Forms.ColumnHeader ngaygio;
        private System.Windows.Forms.ColumnHeader banghep;
        private System.Windows.Forms.ColumnHeader ngaygiosudung;
        private System.Windows.Forms.ColumnHeader mahd;
    }
}