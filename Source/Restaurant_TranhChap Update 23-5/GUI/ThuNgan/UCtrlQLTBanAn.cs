using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BUS;
using DTO;
namespace GUI.ThuNgan
{
    public partial class UCtrlQLTBanAn : DevExpress.XtraEditors.XtraUserControl
    {
        public int Mode;
        List<BanAn_DTO> lsBanAn;
        int indexBanAn;
        
        List<ChiTietHoaDon_DTO> lsCTHD;
        DataTable dtCTHD;
        int indexCTHD;

        int maHD;
        int maBan;
        public UCtrlQLTBanAn()
        {
            InitializeComponent();
            lsBanAn = new List<BanAn_DTO>();
            indexBanAn = -1;

            lsCTHD = new List<ChiTietHoaDon_DTO>();
            dtCTHD = new DataTable();
            indexCTHD = -1;
            maHD = -1;
            maBan = -1;
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (maHD != -1)
            {
                frmThemMonAn _frmThemMonAn = new frmThemMonAn();
                _frmThemMonAn.Mode = Mode;
                _frmThemMonAn.reloadGridViewCTHD = new frmThemMonAn.common_void_delegate(load_GridviewCTHD);
                _frmThemMonAn.maHD = maHD;
                _frmThemMonAn.Show();
            }
            else
                MessageBox.Show("Vui long chon ban an de them mon an.");
        }

        private void UCtrlQLTBanAn_Load(object sender, EventArgs e)
        {
            load_ListBoxBanAn();

            dtCTHD.Columns.Clear();
            dtCTHD.Columns.Add("Mã món", System.Type.GetType("System.Int32"));
            dtCTHD.Columns.Add("Tên món", System.Type.GetType("System.String"));
            dtCTHD.Columns.Add("Giá", System.Type.GetType("System.Double"));
            dtCTHD.Columns.Add("Đơn vị", System.Type.GetType("System.String"));
            dtCTHD.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dtCTHD.Columns.Add("Thành tiền", System.Type.GetType("System.Double"));
            
        }


        private void listBoxBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBanAn.SelectedItems.Count > 0)
            {
                indexBanAn = listBoxBanAn.SelectedIndex;
                maBan = lsBanAn[indexBanAn].MaBan;
                maHD = HoaDon_BUS.SelectMaHoaDonTheoBan(maBan);
                load_GridviewCTHD();
                textEditGiamGia.Text = "0";
            }
        }
        private void load_GridviewCTHD()
        {
            dtCTHD.Rows.Clear();
            if (maHD == -1) return;
            lsCTHD = ChiTietHoaDon_BUS.SelectCTHDtheoMaHD(maHD, Mode);
            int n = lsCTHD.Count;
            double TongTienMonAn = 0;
            for (int i = 0; i < n; i++)
            {
                DataRow row = dtCTHD.NewRow();
                row[0] = lsCTHD[i].MaMon;
                row[1] = lsCTHD[i].TenMon;
                row[2] = lsCTHD[i].Gia;
                row[3] = lsCTHD[i].Donvitinh;
                row[4] = lsCTHD[i].Soluong;
                row[5] = lsCTHD[i].Soluong * lsCTHD[i].Gia;
                dtCTHD.Rows.Add(row);
                TongTienMonAn += (double)row[5];
            }
            gridDSMon.DataSource = dtCTHD;
            textEditTT1.Text = String.Format("{0:n}", TongTienMonAn);
            textEditTT2.Text = ((double.Parse(textEditVAT.Text) / 100) * TongTienMonAn).ToString();
            textEditTT3.Text = ((double.Parse(textEditGiamGia.Text) / 100) * TongTienMonAn).ToString();
            TextEditTongTien.Text = String.Format("{0:n}", TongTienMonAn + double.Parse(textEditTT2.Text) - double.Parse(textEditTT3.Text));

        }
        public void load_ListBoxBanAn()
        {
            lsBanAn = BanAn_BUS.selectBanAnTheoTrangThai(1, int.Parse(frmMain.nhanVien.MaNH.Trim()), Mode);
            
            listBoxBanAn.Items.Clear();
            int sl = lsBanAn.Count;
            for (int i = 0; i < sl; i++)
            {
                listBoxBanAn.Items.Add("Bàn " + lsBanAn[i].MaBan);
            }
            load_GridviewCTHD();
        }
        
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dtCTHD.Rows[indexChiTiet];
                int mamon = (int)row.ItemArray[0];
                ChiTietHoaDon_BUS.DeleteCTHD(maHD, mamon);
                dtCTHD.Rows.RemoveAt(indexChiTiet);

                load_GridviewCTHD();
            }
            catch(Exception ex){}
        }

        int indexChiTiet = -1;
        
        private void GridView_DSMon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (GridView_DSMon.GetSelectedRows().Length > 0)
            {
                indexChiTiet = GridView_DSMon.GetSelectedRows()[0];
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //xoa va chen moi
            if (maHD != -1)
            {
                DataRow row = dtCTHD.Rows[indexChiTiet];
                int mamon = (int)row.ItemArray[0];
                ChiTietHoaDon_BUS.UpdateSoLuongCTHD(maHD, mamon, 1, Mode);
                load_GridviewCTHD();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (maHD != -1)
            {
                DataRow row = dtCTHD.Rows[indexChiTiet];
                int mamon = (int)row.ItemArray[0];
                ChiTietHoaDon_BUS.UpdateSoLuongCTHD(maHD, mamon, -1, Mode);
                load_GridviewCTHD();
            }
        }

        private void textEditGiamGia_EditValueChanged(object sender, EventArgs e)
        {
            double tt = double.Parse(textEditTT1.Text);
            textEditTT2.Text = ((double.Parse(textEditVAT.Text) / 100) * tt).ToString();
            textEditTT3.Text = ((double.Parse(textEditGiamGia.Text) / 100) * tt).ToString();
            TextEditTongTien.Text = String.Format("{0:n}", tt + double.Parse(textEditTT2.Text) - double.Parse(textEditTT3.Text));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DateTime tgketthuc = DateTime.Now;
            float tt;
            float.TryParse(TextEditTongTien.Text, out tt);
            if (maBan != -1)
            {
                HoaDon_BUS.UpdateKetThucHoaDon(maHD, tt, tgketthuc);
                BanAn_BUS.UpdateTrangThaiBanAn(maBan, 0);
                maBan = -1;
                maHD = -1;
                UCtrlQLTBanAn_Load(null, null);
                load_GridviewCTHD();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            String header = "Bàn " + maBan + "\n\n";
            header += "Danh sách món ăn:";
            String footer = "\n\nSố tiền: \t" + textEditTT1.Text + " VNĐ";
            footer += "\nVAT: \t\t" + textEditVAT.Text + "%";
            footer += "\nGiảm giá: \t" + textEditGiamGia.Text + "%";
            footer += "\nThành tiền: \t" + TextEditTongTien.Text + " VNĐ";

            printableComponentLink2.RtfReportHeader = header;
            printableComponentLink2.RtfReportFooter = footer;
            printableComponentLink2.CreateDocument();
            printingSystem2.PreviewRibbonFormEx.Show();
        }

        public void ShowFormChuyenBan(){
            frmChuyenBan _frmchuyenban = new frmChuyenBan();
            _frmchuyenban.Mode = Mode;
            _frmchuyenban.reloadListboxBanAn = new frmChuyenBan.common_void_delegate(load_ListBoxBanAn);
            _frmchuyenban.Show();
            //duoc goi tu frmMain
        }

        public void ShowFormGhepBan(){
            frmGhepBan _frmGhepBan = new frmGhepBan();
            _frmGhepBan.Mode = Mode;
            _frmGhepBan.reloadListboxBanAn = new frmGhepBan.common_void_delegate(load_ListBoxBanAn);
            _frmGhepBan.Show();
        }
    }
}
