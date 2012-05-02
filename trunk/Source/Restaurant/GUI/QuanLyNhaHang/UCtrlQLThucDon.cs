using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlQLThucDon : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiMonAn_BUS loaiMonAn;
        MonAn_BUS monAn;
        
        public UCtrlQLThucDon()
        {
            InitializeComponent();
        }

        private void spbDocLoaiMonAn_Click(object sender, EventArgs e)
        {
            DataTable tb = loaiMonAn.DocLoaiMonAn();
            gridLoaiMonAn.DataSource = tb;
        }

        private void spbDocMonAn_Click(object sender, EventArgs e)
        {
            gridMonAn.DataSource = monAn.DocMonAn();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
            loaiMonAn = new LoaiMonAn_BUS();
            monAn = new MonAn_BUS();
        }   
              
    }
}
