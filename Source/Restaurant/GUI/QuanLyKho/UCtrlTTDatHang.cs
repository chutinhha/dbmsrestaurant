using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.QuanLyKho
{
    public partial class UCtrlTTDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        frmDatHang _frmDatHang ;
        public UCtrlTTDatHang()
        {
            InitializeComponent();
            _frmDatHang = new frmDatHang();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            _frmDatHang.Show();
        }
    }
}
