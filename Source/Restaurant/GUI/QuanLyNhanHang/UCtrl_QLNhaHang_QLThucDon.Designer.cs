namespace GUI
{
    partial class UCtrl_QLNhaHang_QLThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCtrl_QLNhaHang_QLThucDon));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcMonAn = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcLoaiMonAn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spbThemMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.smbCapNhatMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.spbXoaMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.spBXoaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.spbCapNhatLoai = new DevExpress.XtraEditors.SimpleButton();
            this.spbThemLoai = new DevExpress.XtraEditors.SimpleButton();
            this.cbbMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btCommit = new vButton.vButton();
            this.btRollBack = new vButton.vButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbbIsolation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spbDocLoaiMonAn = new DevExpress.XtraEditors.SimpleButton();
            this.spbDocMonAn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsolation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcMonAn);
            this.groupControl1.Location = new System.Drawing.Point(334, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(540, 400);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Món Ăn";
            // 
            // gcMonAn
            // 
            this.gcMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMonAn.Location = new System.Drawing.Point(2, 22);
            this.gcMonAn.MainView = this.gridView2;
            this.gcMonAn.Name = "gcMonAn";
            this.gcMonAn.Size = new System.Drawing.Size(536, 376);
            this.gcMonAn.TabIndex = 0;
            this.gcMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.gridView2.GridControl = this.gcMonAn;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "TenNhaHang", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Món";
            this.gridColumn3.FieldName = "TenMon";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại Món";
            this.gridColumn4.FieldName = "TenLoai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá";
            this.gridColumn5.FieldName = "Gia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Đơn Vị Tính";
            this.gridColumn6.FieldName = "DonViTinh";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Nhà Hàng";
            this.gridColumn8.FieldName = "TenNH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.gcLoaiMonAn);
            this.groupControl2.Location = new System.Drawing.Point(3, 76);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(325, 400);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Loại Món Ăn";
            // 
            // gcLoaiMonAn
            // 
            this.gcLoaiMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiMonAn.Location = new System.Drawing.Point(2, 22);
            this.gcLoaiMonAn.MainView = this.gridView1;
            this.gcLoaiMonAn.Name = "gcLoaiMonAn";
            this.gcLoaiMonAn.Size = new System.Drawing.Size(321, 376);
            this.gcLoaiMonAn.TabIndex = 0;
            this.gcLoaiMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gcLoaiMonAn;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Loại";
            this.gridColumn1.FieldName = "MaLoai";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Loại";
            this.gridColumn2.FieldName = "TenLoai";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // spbThemMonAn
            // 
            this.spbThemMonAn.Location = new System.Drawing.Point(422, 47);
            this.spbThemMonAn.Name = "spbThemMonAn";
            this.spbThemMonAn.Size = new System.Drawing.Size(75, 23);
            this.spbThemMonAn.TabIndex = 2;
            this.spbThemMonAn.Text = "Thêm Món Ăn";
            // 
            // smbCapNhatMonAn
            // 
            this.smbCapNhatMonAn.Location = new System.Drawing.Point(509, 47);
            this.smbCapNhatMonAn.Name = "smbCapNhatMonAn";
            this.smbCapNhatMonAn.Size = new System.Drawing.Size(96, 23);
            this.smbCapNhatMonAn.TabIndex = 3;
            this.smbCapNhatMonAn.Text = "Cập Nhật Món Ăn";
            // 
            // spbXoaMonAn
            // 
            this.spbXoaMonAn.Location = new System.Drawing.Point(618, 47);
            this.spbXoaMonAn.Name = "spbXoaMonAn";
            this.spbXoaMonAn.Size = new System.Drawing.Size(75, 23);
            this.spbXoaMonAn.TabIndex = 4;
            this.spbXoaMonAn.Text = "Xóa Món Ăn";
            // 
            // spBXoaLoai
            // 
            this.spBXoaLoai.Location = new System.Drawing.Point(257, 47);
            this.spBXoaLoai.Name = "spBXoaLoai";
            this.spBXoaLoai.Size = new System.Drawing.Size(66, 23);
            this.spBXoaLoai.TabIndex = 7;
            this.spBXoaLoai.Text = "Xóa Loại";
            // 
            // spbCapNhatLoai
            // 
            this.spbCapNhatLoai.Location = new System.Drawing.Point(171, 47);
            this.spbCapNhatLoai.Name = "spbCapNhatLoai";
            this.spbCapNhatLoai.Size = new System.Drawing.Size(75, 23);
            this.spbCapNhatLoai.TabIndex = 6;
            this.spbCapNhatLoai.Text = "Cập Nhật Loại";
            // 
            // spbThemLoai
            // 
            this.spbThemLoai.Location = new System.Drawing.Point(100, 47);
            this.spbThemLoai.Name = "spbThemLoai";
            this.spbThemLoai.Size = new System.Drawing.Size(62, 23);
            this.spbThemLoai.TabIndex = 5;
            this.spbThemLoai.Text = "Thêm Loại";
            // 
            // cbbMode
            // 
            this.cbbMode.Location = new System.Drawing.Point(79, 7);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbMode.Properties.Items.AddRange(new object[] {
            "Bình Thường",
            "Xảy Ra Tranh Chấp"});
            this.cbbMode.Size = new System.Drawing.Size(121, 20);
            this.cbbMode.TabIndex = 8;
            this.cbbMode.SelectedIndexChanged += new System.EventHandler(this.cbbMode_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btCommit);
            this.panelControl1.Controls.Add(this.btRollBack);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cbbIsolation);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cbbMode);
            this.panelControl1.Location = new System.Drawing.Point(3, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 34);
            this.panelControl1.TabIndex = 0;
            // 
            // btCommit
            // 
            this.btCommit.BackColor = System.Drawing.Color.Transparent;
            this.btCommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCommit.BackgroundImage")));
            this.btCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCommit.ButtonStyles = vButton.vButton.BtnType.Adobe;
            this.btCommit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCommit.FlatAppearance.BorderSize = 0;
            this.btCommit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCommit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCommit.ForeColor = System.Drawing.Color.White;
            this.btCommit.Location = new System.Drawing.Point(633, 6);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(138, 23);
            this.btCommit.TabIndex = 13;
            this.btCommit.Text = "Commit";
            this.btCommit.UseVisualStyleBackColor = false;
            // 
            // btRollBack
            // 
            this.btRollBack.BackColor = System.Drawing.Color.Transparent;
            this.btRollBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRollBack.BackgroundImage")));
            this.btRollBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRollBack.ButtonStyles = vButton.vButton.BtnType.Adobe;
            this.btRollBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btRollBack.FlatAppearance.BorderSize = 0;
            this.btRollBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btRollBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRollBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRollBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRollBack.ForeColor = System.Drawing.Color.White;
            this.btRollBack.Location = new System.Drawing.Point(460, 6);
            this.btRollBack.Name = "btRollBack";
            this.btRollBack.Size = new System.Drawing.Size(138, 23);
            this.btRollBack.TabIndex = 12;
            this.btRollBack.Text = "RollBack";
            this.btRollBack.UseVisualStyleBackColor = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(254, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Isolation :";
            // 
            // cbbIsolation
            // 
            this.cbbIsolation.Location = new System.Drawing.Point(306, 7);
            this.cbbIsolation.Name = "cbbIsolation";
            this.cbbIsolation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbIsolation.Properties.Items.AddRange(new object[] {
            "Read Uncommitted",
            "Read Committed",
            "Repeatable Read",
            "Serializable"});
            this.cbbIsolation.Size = new System.Drawing.Size(116, 20);
            this.cbbIsolation.TabIndex = 10;
            this.cbbIsolation.SelectedIndexChanged += new System.EventHandler(this.cbbIsolation_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Mode :";
            // 
            // spbDocLoaiMonAn
            // 
            this.spbDocLoaiMonAn.Location = new System.Drawing.Point(4, 47);
            this.spbDocLoaiMonAn.Name = "spbDocLoaiMonAn";
            this.spbDocLoaiMonAn.Size = new System.Drawing.Size(87, 23);
            this.spbDocLoaiMonAn.TabIndex = 6;
            this.spbDocLoaiMonAn.Text = "Đọc Loại Món Ăn";
            this.spbDocLoaiMonAn.Click += new System.EventHandler(this.spbDocLoaiMonAn_Click);
            // 
            // spbDocMonAn
            // 
            this.spbDocMonAn.Location = new System.Drawing.Point(334, 47);
            this.spbDocMonAn.Name = "spbDocMonAn";
            this.spbDocMonAn.Size = new System.Drawing.Size(75, 23);
            this.spbDocMonAn.TabIndex = 2;
            this.spbDocMonAn.Text = "Đọc Món Ăn";
            this.spbDocMonAn.Click += new System.EventHandler(this.spbDocMonAn_Click);
            // 
            // UCtrl_QLNhaHang_QLThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spbThemLoai);
            this.Controls.Add(this.spbDocLoaiMonAn);
            this.Controls.Add(this.spbCapNhatLoai);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.spBXoaLoai);
            this.Controls.Add(this.spbXoaMonAn);
            this.Controls.Add(this.smbCapNhatMonAn);
            this.Controls.Add(this.spbDocMonAn);
            this.Controls.Add(this.spbThemMonAn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCtrl_QLNhaHang_QLThucDon";
            this.Size = new System.Drawing.Size(877, 483);
            this.Load += new System.EventHandler(this.UCtrl_QLNhaHang_QLThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIsolation.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton spbThemMonAn;
        private DevExpress.XtraEditors.SimpleButton smbCapNhatMonAn;
        private DevExpress.XtraEditors.SimpleButton spbXoaMonAn;
        private DevExpress.XtraEditors.SimpleButton spBXoaLoai;
        private DevExpress.XtraEditors.SimpleButton spbCapNhatLoai;
        private DevExpress.XtraEditors.SimpleButton spbThemLoai;
        private DevExpress.XtraEditors.ComboBoxEdit cbbMode;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private vButton.vButton btCommit;
        private vButton.vButton btRollBack;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbbIsolation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton spbDocLoaiMonAn;
        private DevExpress.XtraGrid.GridControl gcLoaiMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gcMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton spbDocMonAn;

    }
}
