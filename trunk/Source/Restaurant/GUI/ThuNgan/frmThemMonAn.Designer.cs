namespace GUI.ThuNgan
{
    partial class frmThemMonAn
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
            this.textEditSL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCong = new DevExpress.XtraEditors.SimpleButton();
            this.cboLoaiMonAn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlChon = new DevExpress.XtraGrid.GridControl();
            this.gridViewChon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listViewDSMonAn = new System.Windows.Forms.ListView();
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiMonAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEditSL);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnCong);
            this.panelControl1.Controls.Add(this.cboLoaiMonAn);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnDongY);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(694, 422);
            this.panelControl1.TabIndex = 0;
            // 
            // textEditSL
            // 
            this.textEditSL.Location = new System.Drawing.Point(516, 9);
            this.textEditSL.Name = "textEditSL";
            this.textEditSL.Size = new System.Drawing.Size(102, 20);
            this.textEditSL.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(464, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Số lượng:";
            // 
            // btnCong
            // 
            this.btnCong.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 20F);
            this.btnCong.Appearance.Options.UseFont = true;
            this.btnCong.Location = new System.Drawing.Point(624, 6);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(58, 23);
            this.btnCong.TabIndex = 34;
            this.btnCong.Text = "+";
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // cboLoaiMonAn
            // 
            this.cboLoaiMonAn.Location = new System.Drawing.Point(81, 11);
            this.cboLoaiMonAn.Name = "cboLoaiMonAn";
            this.cboLoaiMonAn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiMonAn.Size = new System.Drawing.Size(131, 20);
            this.cboLoaiMonAn.TabIndex = 28;
            this.cboLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMonAn_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Loại Món Ăn";
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.Image = global::GUI.Properties.Resources.ok_24;
            this.btnDongY.Location = new System.Drawing.Point(526, 384);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 32);
            this.btnDongY.TabIndex = 26;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::GUI.Properties.Resources.close_24;
            this.btnHuy.Location = new System.Drawing.Point(607, 384);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gridControlChon);
            this.groupControl2.Location = new System.Drawing.Point(273, 44);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(409, 334);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Món Ăn Chọn";
            // 
            // gridControlChon
            // 
            this.gridControlChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChon.Location = new System.Drawing.Point(2, 22);
            this.gridControlChon.MainView = this.gridViewChon;
            this.gridControlChon.Name = "gridControlChon";
            this.gridControlChon.Size = new System.Drawing.Size(405, 310);
            this.gridControlChon.TabIndex = 0;
            this.gridControlChon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChon});
            // 
            // gridViewChon
            // 
            this.gridViewChon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewChon.GridControl = this.gridControlChon;
            this.gridViewChon.Name = "gridViewChon";
            this.gridViewChon.OptionsBehavior.Editable = false;
            this.gridViewChon.OptionsView.ShowGroupPanel = false;
            this.gridViewChon.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewChon_FocusedRowChanged);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton4.Image = global::GUI.Properties.Resources.left_32;
            this.simpleButton4.Location = new System.Drawing.Point(220, 212);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(47, 34);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Image = global::GUI.Properties.Resources.right_32;
            this.simpleButton1.Location = new System.Drawing.Point(220, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(47, 34);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.listViewDSMonAn);
            this.groupControl1.Location = new System.Drawing.Point(12, 44);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 334);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Danh Sách Món Ăn";
            // 
            // listViewDSMonAn
            // 
            this.listViewDSMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ten,
            this.gia});
            this.listViewDSMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDSMonAn.FullRowSelect = true;
            this.listViewDSMonAn.GridLines = true;
            this.listViewDSMonAn.Location = new System.Drawing.Point(2, 22);
            this.listViewDSMonAn.Name = "listViewDSMonAn";
            this.listViewDSMonAn.Size = new System.Drawing.Size(196, 310);
            this.listViewDSMonAn.TabIndex = 1;
            this.listViewDSMonAn.UseCompatibleStateImageBehavior = false;
            this.listViewDSMonAn.View = System.Windows.Forms.View.Details;
            this.listViewDSMonAn.DoubleClick += new System.EventHandler(this.listViewDSMonAn_DoubleClick);
            // 
            // ten
            // 
            this.ten.Text = "Tên";
            this.ten.Width = 120;
            // 
            // gia
            // 
            this.gia.Text = "Giá";
            this.gia.Width = 70;
            // 
            // frmThemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 422);
            this.Controls.Add(this.panelControl1);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmThemMonAn";
            this.Text = "Thêm Món Ăn";
            this.Load += new System.EventHandler(this.frmThemMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiMonAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiMonAn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlChon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChon;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListView listViewDSMonAn;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader gia;
        private DevExpress.XtraEditors.SimpleButton btnCong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditSL;


    }
}