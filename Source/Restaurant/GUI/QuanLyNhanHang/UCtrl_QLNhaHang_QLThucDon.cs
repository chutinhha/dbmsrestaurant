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
        bool flagMode;//flag:binh thường, true:xảy ra tranh chấp
        IsolationLevel iso;

        private void KiemTra()
        {
            if (flagMode == false)
            {
                cbbIsolation.Enabled = false;
                btCommit.Enabled = false;
                btRollBack.Enabled = false;
            }
            else
            {
                cbbIsolation.Enabled = true;
                btCommit.Enabled = true;
                btRollBack.Enabled = true;
            }
        }
        
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
            cbbMode.SelectedIndex = 0;
            cbbIsolation.SelectedIndex = 1;
            KiemTra();

            flagMode = false;
            iso = IsolationLevel.ReadCommitted; //chế độ mặt định của SQLServer
            loaiMonAn = new LoaiMonAn_BUS();
            monAn = new MonAn_BUS();
        }

        private void cbbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMode.SelectedIndex == 0)
                flagMode = false;
            else
                flagMode = true;
            KiemTra();
        }

        private void cbbIsolation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbIsolation.SelectedIndex == 0)
                iso = IsolationLevel.ReadUncommitted;
            if (cbbIsolation.SelectedIndex == 1)
                iso = IsolationLevel.ReadCommitted;
            if (cbbIsolation.SelectedIndex == 2)
                iso = IsolationLevel.RepeatableRead;
            if (cbbIsolation.SelectedIndex == 3)
                iso = IsolationLevel.Serializable;
        }

      

       

        


      
    }
}
