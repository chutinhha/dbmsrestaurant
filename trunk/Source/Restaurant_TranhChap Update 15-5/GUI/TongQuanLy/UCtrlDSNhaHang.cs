using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.TongQuanLy
{
    public partial class UCtrlDSNhaHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UCtrlDSNhaHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaHang _frmThemNH = new frmThemNhaHang();
            _frmThemNH.Show();
        }
    }
}
