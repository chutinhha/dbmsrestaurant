namespace GUI
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.rbPage_TiepTan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPage_ThuNgan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPage_QuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPageGroup_QLMonAn = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPage_QLKho = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MyBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.MyxtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.MyapplicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyxtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyapplicationMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPage_TiepTan,
            this.rbPage_ThuNgan,
            this.rbPage_QuanLy,
            this.rbPage_QLKho});
            this.ribbonControl1.Size = new System.Drawing.Size(905, 147);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = global::GUI.Properties.Resources.Perspective_Button___Stop;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = global::GUI.Properties.Resources.Perspective_Button___Stop;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = global::GUI.Properties.Resources.Perspective_Button___Stop;
            this.barButtonItem3.LargeGlyphDisabled = global::GUI.Properties.Resources.Perspective_Button___Stop;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // rbPage_TiepTan
            // 
            this.rbPage_TiepTan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbPage_TiepTan.Name = "rbPage_TiepTan";
            this.rbPage_TiepTan.Text = "Tiếp Tân";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // rbPage_ThuNgan
            // 
            this.rbPage_ThuNgan.Name = "rbPage_ThuNgan";
            this.rbPage_ThuNgan.Text = "Thu Ngân";
            // 
            // rbPage_QuanLy
            // 
            this.rbPage_QuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPageGroup_QLMonAn,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.rbPage_QuanLy.Name = "rbPage_QuanLy";
            this.rbPage_QuanLy.Text = "Quản Lý";
            // 
            // rbPageGroup_QLMonAn
            // 
            this.rbPageGroup_QLMonAn.ItemLinks.Add(this.barButtonItem1);
            this.rbPageGroup_QLMonAn.ItemLinks.Add(this.barButtonItem2);
            this.rbPageGroup_QLMonAn.Name = "rbPageGroup_QLMonAn";
            this.rbPageGroup_QLMonAn.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbPage_QLKho
            // 
            this.rbPage_QLKho.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbPage_QLKho.Name = "rbPage_QLKho";
            this.rbPage_QLKho.Text = "Quản Lý Kho";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // MyxtraTabbedMdiManager1
            // 
            this.MyxtraTabbedMdiManager1.MdiParent = this;
            // 
            // MyapplicationMenu
            // 
            this.MyapplicationMenu.Name = "MyapplicationMenu";
            this.MyapplicationMenu.Ribbon = this.ribbonControl1;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 498);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Nhà Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyxtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyapplicationMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPage_TiepTan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.DefaultBarAndDockingController MyBarAndDockingController1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MyxtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu MyapplicationMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPage_ThuNgan;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPage_QuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPageGroup_QLMonAn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPage_QLKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}

