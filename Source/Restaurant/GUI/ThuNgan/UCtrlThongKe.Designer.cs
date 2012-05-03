namespace GUI.ThuNgan
{
    partial class UCtrlThongKe
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listView2 = new System.Windows.Forms.ListView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.listView3 = new System.Windows.Forms.ListView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.listView1);
            this.groupControl1.Location = new System.Drawing.Point(3, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 164);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Bàn Ăn";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(2, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 140);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listView2);
            this.groupControl2.Location = new System.Drawing.Point(5, 182);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(320, 249);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông Tin Sử Dụng";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(2, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(316, 225);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.listView3);
            this.groupControl3.Location = new System.Drawing.Point(331, 185);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(544, 246);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Thông Tin Chi Tiết";
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(2, 22);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(540, 222);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::GUI.Properties.Resources.print_24;
            this.simpleButton1.Location = new System.Drawing.Point(737, 439);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(136, 32);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "In Danh Sách";
            // 
            // UCtrlThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCtrlThongKe";
            this.Size = new System.Drawing.Size(880, 480);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView listView2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ListView listView3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
