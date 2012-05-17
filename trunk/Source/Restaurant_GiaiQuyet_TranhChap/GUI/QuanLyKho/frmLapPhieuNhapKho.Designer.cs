namespace GUI.QuanLyKho
{
    partial class frmLapPhieuNhapKho
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
            this.groupDSDatHang = new DevExpress.XtraEditors.GroupControl();
            this.gridDSDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.btnNhapHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieuNhapKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).BeginInit();
            this.groupDSDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).BeginInit();
            this.groupDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDSDatHang
            // 
            this.groupDSDatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDSDatHang.Controls.Add(this.gridDSDatHang);
            this.groupDSDatHang.Location = new System.Drawing.Point(245, 12);
            this.groupDSDatHang.Name = "groupDSDatHang";
            this.groupDSDatHang.Size = new System.Drawing.Size(627, 405);
            this.groupDSDatHang.TabIndex = 0;
            this.groupDSDatHang.Text = "Danh Sách Đặt Hàng Chưa Giao";
            // 
            // gridDSDatHang
            // 
            this.gridDSDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSDatHang.Location = new System.Drawing.Point(2, 22);
            this.gridDSDatHang.MainView = this.gridView1;
            this.gridDSDatHang.Name = "gridDSDatHang";
            this.gridDSDatHang.Size = new System.Drawing.Size(623, 381);
            this.gridDSDatHang.TabIndex = 0;
            this.gridDSDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridDSDatHang;
            this.gridView1.Name = "gridView1";
            // 
            // groupDSNCC
            // 
            this.groupDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDSNCC.Controls.Add(this.listBoxControl1);
            this.groupDSNCC.Location = new System.Drawing.Point(12, 12);
            this.groupDSNCC.Name = "groupDSNCC";
            this.groupDSNCC.Size = new System.Drawing.Size(227, 405);
            this.groupDSNCC.TabIndex = 1;
            this.groupDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.listBoxControl1.Location = new System.Drawing.Point(2, 22);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(223, 381);
            this.listBoxControl1.TabIndex = 0;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.Image = global::GUI.Properties.Resources.ok_24;
            this.btnNhapHang.Location = new System.Drawing.Point(421, 423);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(175, 32);
            this.btnNhapHang.TabIndex = 2;
            this.btnNhapHang.Text = "Nhập Hàng";
            // 
            // btnLapPhieuNhapKho
            // 
            this.btnLapPhieuNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapPhieuNhapKho.Image = global::GUI.Properties.Resources.save_24;
            this.btnLapPhieuNhapKho.Location = new System.Drawing.Point(602, 423);
            this.btnLapPhieuNhapKho.Name = "btnLapPhieuNhapKho";
            this.btnLapPhieuNhapKho.Size = new System.Drawing.Size(175, 32);
            this.btnLapPhieuNhapKho.TabIndex = 2;
            this.btnLapPhieuNhapKho.Text = "Lập Phiếu Nhập Kho";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(783, 423);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            // 
            // frmLapPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLapPhieuNhapKho);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.groupDSNCC);
            this.Controls.Add(this.groupDSDatHang);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "frmLapPhieuNhapKho";
            this.Text = "flrmLapPhieuNhapKho";
            ((System.ComponentModel.ISupportInitialize)(this.groupDSDatHang)).EndInit();
            this.groupDSDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).EndInit();
            this.groupDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDSDatHang;
        private DevExpress.XtraGrid.GridControl gridDSDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupDSNCC;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnNhapHang;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuNhapKho;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}