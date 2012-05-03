namespace GUI.TiepTan
{
    partial class frmDatBan
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupTTDatBan = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.lstDSBan = new System.Windows.Forms.ListView();
            this.lstDSBanDat = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTDatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.groupTTDatBan);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 462);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Image = global::GUI.Properties.Resources.close_24;
            this.simpleButton3.Location = new System.Drawing.Point(797, 418);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 32);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Hủy";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Image = global::GUI.Properties.Resources.ok_24;
            this.simpleButton2.Location = new System.Drawing.Point(666, 418);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(109, 32);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Đặt Bàn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Image = global::GUI.Properties.Resources.right_32;
            this.simpleButton1.Location = new System.Drawing.Point(386, 256);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(45, 42);
            this.simpleButton1.TabIndex = 9;
            // 
            // groupTTDatBan
            // 
            this.groupTTDatBan.Location = new System.Drawing.Point(448, 12);
            this.groupTTDatBan.Name = "groupTTDatBan";
            this.groupTTDatBan.Size = new System.Drawing.Size(395, 184);
            this.groupTTDatBan.TabIndex = 5;
            this.groupTTDatBan.Text = "Thông Tin Đặt Bàn";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.lstDSBanDat);
            this.groupControl2.Location = new System.Drawing.Point(448, 214);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(424, 198);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Danh Sách Bàn Đặt";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.lstDSBan);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 400);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Danh Sách Bàn";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton4.Image = global::GUI.Properties.Resources.left_32;
            this.simpleButton4.Location = new System.Drawing.Point(386, 304);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(45, 42);
            this.simpleButton4.TabIndex = 8;
            // 
            // lstDSBan
            // 
            this.lstDSBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDSBan.GridLines = true;
            this.lstDSBan.Location = new System.Drawing.Point(2, 22);
            this.lstDSBan.Name = "lstDSBan";
            this.lstDSBan.Size = new System.Drawing.Size(352, 376);
            this.lstDSBan.TabIndex = 1;
            this.lstDSBan.UseCompatibleStateImageBehavior = false;
            // 
            // lstDSBanDat
            // 
            this.lstDSBanDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDSBanDat.GridLines = true;
            this.lstDSBanDat.Location = new System.Drawing.Point(2, 22);
            this.lstDSBanDat.Name = "lstDSBanDat";
            this.lstDSBanDat.Size = new System.Drawing.Size(420, 174);
            this.lstDSBanDat.TabIndex = 1;
            this.lstDSBanDat.UseCompatibleStateImageBehavior = false;
            // 
            // frmDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.panelControl1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmDatBan";
            this.Text = "frmDatBan";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTTDatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupTTDatBan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.ListView lstDSBanDat;
        private System.Windows.Forms.ListView lstDSBan;

    }
}