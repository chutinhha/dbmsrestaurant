using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.ThuNgan
{
    public partial class UCtrlQLTBanAn : DevExpress.XtraEditors.XtraUserControl
    {
        public UCtrlQLTBanAn()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemMonAn _frmThemMonAn = new frmThemMonAn();
            _frmThemMonAn.Show();
        }
    }
}
