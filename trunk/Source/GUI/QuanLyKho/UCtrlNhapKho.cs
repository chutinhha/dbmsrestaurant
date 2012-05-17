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
    public partial class UCtrlNhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        public UCtrlNhapKho()
        {
            InitializeComponent();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapKho _frmLapPhieuNhapKho = new frmLapPhieuNhapKho();
            _frmLapPhieuNhapKho.Show();
        }
    }
}
