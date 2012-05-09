namespace GUI.QuanLyKho
{
    partial class frmDatHang_ChonNCC
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.groupDMNguyenLieu = new DevExpress.XtraEditors.GroupControl();
            this.lvNguyenLieu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupDSNCC = new DevExpress.XtraEditors.GroupControl();
            this.lvNCC = new System.Windows.Forms.ListView();
            this.cl_STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DiemUuTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).BeginInit();
            this.groupDMNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).BeginInit();
            this.groupDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnDongY);
            this.panelControl1.Controls.Add(this.groupDMNguyenLieu);
            this.panelControl1.Controls.Add(this.groupDSNCC);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(689, 433);
            this.panelControl1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(598, 390);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(509, 390);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 39;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // groupDMNguyenLieu
            // 
            this.groupDMNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDMNguyenLieu.Controls.Add(this.lvNguyenLieu);
            this.groupDMNguyenLieu.Location = new System.Drawing.Point(375, 11);
            this.groupDMNguyenLieu.Name = "groupDMNguyenLieu";
            this.groupDMNguyenLieu.Size = new System.Drawing.Size(300, 373);
            this.groupDMNguyenLieu.TabIndex = 35;
            this.groupDMNguyenLieu.Text = "Danh Mục Nguyên Liệu Từ Nhà Cung Cấp";
            // 
            // lvNguyenLieu
            // 
            this.lvNguyenLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvNguyenLieu.FullRowSelect = true;
            this.lvNguyenLieu.GridLines = true;
            this.lvNguyenLieu.Location = new System.Drawing.Point(2, 22);
            this.lvNguyenLieu.MultiSelect = false;
            this.lvNguyenLieu.Name = "lvNguyenLieu";
            this.lvNguyenLieu.Size = new System.Drawing.Size(296, 349);
            this.lvNguyenLieu.TabIndex = 2;
            this.lvNguyenLieu.UseCompatibleStateImageBehavior = false;
            this.lvNguyenLieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nguyên Liệu";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá Nguyên Liệu";
            this.columnHeader3.Width = 99;
            // 
            // groupDSNCC
            // 
            this.groupDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDSNCC.Controls.Add(this.lvNCC);
            this.groupDSNCC.Location = new System.Drawing.Point(13, 11);
            this.groupDSNCC.Name = "groupDSNCC";
            this.groupDSNCC.Size = new System.Drawing.Size(300, 373);
            this.groupDSNCC.TabIndex = 36;
            this.groupDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // lvNCC
            // 
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_STT,
            this.cl_NCC,
            this.cl_DiemUuTien});
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.GridLines = true;
            this.lvNCC.Location = new System.Drawing.Point(2, 22);
            this.lvNCC.MultiSelect = false;
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(296, 349);
            this.lvNCC.TabIndex = 2;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            this.lvNCC.SelectedIndexChanged += new System.EventHandler(this.lvNCC_SelectedIndexChanged);
            // 
            // cl_STT
            // 
            this.cl_STT.Text = "STT";
            this.cl_STT.Width = 30;
            // 
            // cl_NCC
            // 
            this.cl_NCC.Text = "Nhà Cung Cấp";
            this.cl_NCC.Width = 184;
            // 
            // cl_DiemUuTien
            // 
            this.cl_DiemUuTien.Text = "Điểm Ưu Tiên";
            this.cl_DiemUuTien.Width = 76;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEdit1.EditValue = global::GUI.Properties.Resources.navigate_right48;
            this.pictureEdit1.Location = new System.Drawing.Point(321, 160);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 66);
            this.pictureEdit1.TabIndex = 37;
            // 
            // frmDatHang_ChonNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatHang_ChonNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDMNguyenLieu)).EndInit();
            this.groupDMNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDSNCC)).EndInit();
            this.groupDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.GroupControl groupDMNguyenLieu;
        private System.Windows.Forms.ListView lvNguyenLieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevExpress.XtraEditors.GroupControl groupDSNCC;
        private System.Windows.Forms.ListView lvNCC;
        private System.Windows.Forms.ColumnHeader cl_STT;
        private System.Windows.Forms.ColumnHeader cl_NCC;
        private System.Windows.Forms.ColumnHeader cl_DiemUuTien;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;



    }
}