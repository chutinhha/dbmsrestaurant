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
            loaiMonAn = new LoaiMonAn_BUS();
            monAn = new MonAn_BUS();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
            gridLoaiMonAn.DataSource = loaiMonAn.DocLoaiMonAn();
            gridMonAn.DataSource = monAn.DocMonAn();
        }   
              
    }
}
