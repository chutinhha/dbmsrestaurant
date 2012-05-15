using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

using System.Data.SqlClient;
using DTO;
using BUS;
using DevExpress.XtraEditors.Controls;

namespace GUI.ThuNgan
{
    public partial class frmChuyenBan : DevExpress.XtraEditors.XtraForm
    {
        List<BanAn_DTO> lsBanDangAn;
        int indexBanDangAn;
        List<BanAn_DTO> lsBanTrong;
        int indexBanTrong;

        public frmChuyenBan()
        {
            InitializeComponent();
        }
        public delegate void common_void_delegate();
        public common_void_delegate reloadListboxBanAn;
        
        private void frmChuyenBan_Load(object sender, EventArgs e)
        {
            lsBanDangAn = BanAn_BUS.selectBanAnTheoTrangThai(1, 1);
            ComboBoxItemCollection coll = cbbox_BanCanChuyen.Properties.Items;
            coll.BeginUpdate();

            foreach (BanAn_DTO ban in lsBanDangAn)
            {
                String content = "Bàn " + ban.MaBan;
                coll.Add(content);
                coll.EndUpdate();
            }

            lsBanTrong = BanAn_BUS.selectBanAnTheoTrangThai(0, 1);
            ComboBoxItemCollection coll2 = cbbox_ChuyenSangBan.Properties.Items;
            coll2.BeginUpdate();

            foreach (BanAn_DTO ban in lsBanTrong)
            {
                String content = "Bàn " + ban.MaBan;
                coll2.Add(content);
                coll2.EndUpdate();
            }
            indexBanDangAn = indexBanTrong = -1;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int mabanOLD = lsBanDangAn[indexBanDangAn].MaBan;
            int mabanNEW = lsBanTrong[indexBanTrong].MaBan;

            int mahd = HoaDon_BUS.SelectMaHoaDonTheoBan(mabanOLD);
            
            int kq = HoaDon_BUS.ChuyenBan(mabanOLD, mabanNEW, mahd);

            reloadListboxBanAn();
            if (kq == 0)
                MessageBox.Show("Chuyen ban that bai vi ban vua duoc su dung!");
            this.Close();
        }

        private void cbbox_BanCanChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBanDangAn = cbbox_BanCanChuyen.SelectedIndex;
        }

        private void cbbox_ChuyenSangBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBanTrong = cbbox_ChuyenSangBan.SelectedIndex;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}