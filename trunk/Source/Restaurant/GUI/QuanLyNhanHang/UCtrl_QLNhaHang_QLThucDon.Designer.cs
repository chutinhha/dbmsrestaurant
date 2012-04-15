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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.vButton2 = new vButton.vButton();
            this.vButton1 = new vButton.vButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
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
            this.gridView2.Name = "gridView2";
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(422, 47);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Thêm Món Ăn";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(509, 47);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(96, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Cập Nhật Món Ăn";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(618, 47);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Xóa Món Ăn";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(257, 47);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(66, 23);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Xóa Loại";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(171, 47);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "Cập Nhật Loại";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(100, 47);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(62, 23);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Thêm Loại";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(94, 7);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit1.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.vButton2);
            this.panelControl1.Controls.Add(this.vButton1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.comboBoxEdit2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.comboBoxEdit1);
            this.panelControl1.Location = new System.Drawing.Point(3, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 34);
            this.panelControl1.TabIndex = 0;
            // 
            // vButton2
            // 
            this.vButton2.BackColor = System.Drawing.Color.Transparent;
            this.vButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vButton2.BackgroundImage")));
            this.vButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vButton2.ButtonStyles = vButton.vButton.BtnType.Adobe;
            this.vButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.vButton2.FlatAppearance.BorderSize = 0;
            this.vButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.vButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vButton2.ForeColor = System.Drawing.Color.White;
            this.vButton2.Location = new System.Drawing.Point(633, 6);
            this.vButton2.Name = "vButton2";
            this.vButton2.Size = new System.Drawing.Size(138, 23);
            this.vButton2.TabIndex = 13;
            this.vButton2.Text = "Commit";
            this.vButton2.UseVisualStyleBackColor = false;
            // 
            // vButton1
            // 
            this.vButton1.BackColor = System.Drawing.Color.Transparent;
            this.vButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vButton1.BackgroundImage")));
            this.vButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vButton1.ButtonStyles = vButton.vButton.BtnType.Adobe;
            this.vButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.vButton1.FlatAppearance.BorderSize = 0;
            this.vButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.vButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.vButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vButton1.ForeColor = System.Drawing.Color.White;
            this.vButton1.Location = new System.Drawing.Point(460, 6);
            this.vButton1.Name = "vButton1";
            this.vButton1.Size = new System.Drawing.Size(138, 23);
            this.vButton1.TabIndex = 12;
            this.vButton1.Text = "RollBack";
            this.vButton1.UseVisualStyleBackColor = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(254, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Isolation :";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(306, 7);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEdit2.TabIndex = 10;
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
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.spbDocLoaiMonAn);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.spbDocMonAn);
            this.Controls.Add(this.simpleButton1);
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
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private vButton.vButton vButton2;
        private vButton.vButton vButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
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
