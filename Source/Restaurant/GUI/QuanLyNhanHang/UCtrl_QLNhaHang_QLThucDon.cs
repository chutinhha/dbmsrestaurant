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

namespace GUI
{
    public partial class UCtrl_QLNhaHang_QLThucDon : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiMonAn_BUS loaiMonAn;
        MonAn_BUS monAn;
        
        public UCtrl_QLNhaHang_QLThucDon()
        {
            InitializeComponent();
        }

        private void spbDocLoaiMonAn_Click(object sender, EventArgs e)
        {
            DataTable tb = loaiMonAn.DocLoaiMonAn();
            gcLoaiMonAn.DataSource = tb;
        }

        private void spbDocMonAn_Click(object sender, EventArgs e)
        {
            gcMonAn.DataSource = monAn.DocMonAn();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
            loaiMonAn = new LoaiMonAn_BUS();
            monAn = new MonAn_BUS();
        }

        


      
    }
}
