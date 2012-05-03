using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TiepTan.UCtrlXepBan UCtrl_TiepTan_XepBan;
        TiepTan.UCtrlDSDatBan UCtrl_TiepTan_DSDatBan;
        TiepTan.UctrlDatBan UCtrl_TiepTan_DatBan;
        ThuNgan.UCtrlQLTBanAn UCtrl_ThuNgan_QLBanAn;
        ThuNgan.UCtrlThongKe UCtrl_ThuNgan_ThongKe;
        QuanLyKho.UCtrlTTDatHang UCtrl_QLKho_DatHang;
        QuanLyKho.UCtrlNhapKho UCtrl_QLKho_NhapKho;
        QuanLyKho.UCtrlNhaCungCap UCtrl_QLKho_NCC;
        QuanLyKho.UCtrlNguyenLieu UCtrl_QLKho_NguyenLieu;
        QuanLyNhaHang.UCtrlQLThucDon UCtrl_QLNH_QLThucDon;
        QuanLyNhaHang.UCtrlQLNhanVien UCtrl_QLNH_QLNhanVien;
        QuanLyNhaHang.UCtrlQLDanhSachBanAn UCtrl_QLNH_QLDSBanAn;
        QuanLyNhaHang.UCtrlThongKeDoanhThu UCtrl_QLNH_ThongKeDoanhThu;
        QuanTri.UCtrlCoSoDuLieu UCtrl_QuanTri_CoSoDuLieu;
        QuanTri.UCtrlPhanQuyen UCtrl_QuanTtri_PhanQuyen;
        QuanTri.UCtrlQuanTriNguoiDung UCtrl_QuanTri_QTNguoiDung;
        QuanTri.UCtrlThuVienAnh UCtrl_QuanTri_QTThuVienAnh;
        String strGiaoDien = "";
        public frmMain()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinGallery(rbGalleryBarItem_TuyChon_GiaoDien);
            //---------
            Random rdSkin = new Random();
            int iSkin = rdSkin.Next(1, 5);
            switch (iSkin)
            {
                case 1 :
                    strGiaoDien = "Seven";
                    break;
                case 2 :
                    strGiaoDien = "Seven Classic";
                    break;
                case 3 :
                    strGiaoDien = "VS2010";
                    break;
                case 4 :
                    strGiaoDien = "The Asphalt World";
                    break;
            }
            //
            //
            //strGiaoDien = "Summer 2008";
            //
            MybarAndDockingController.LookAndFeel.SkinName = strGiaoDien;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = strGiaoDien;
            //-------------
            //Thread UCtrl_TiepTan_XepBan = new Thread(new ThreadStart(ThreadRun));
            //UCtrl_TiepTan_XepBan.Start(UCtrl_TiepTan_XepBan);
            //Thread.Sleep(1000);
            UCtrl_TiepTan_XepBan = new TiepTan.UCtrlXepBan();
            UCtrl_TiepTan_DSDatBan = new TiepTan.UCtrlDSDatBan();
            UCtrl_TiepTan_DatBan = new TiepTan.UctrlDatBan();
            UCtrl_ThuNgan_QLBanAn = new ThuNgan.UCtrlQLTBanAn();
            UCtrl_ThuNgan_ThongKe = new ThuNgan.UCtrlThongKe();
            UCtrl_QLKho_DatHang = new QuanLyKho.UCtrlTTDatHang();
            UCtrl_QLKho_NhapKho = new QuanLyKho.UCtrlNhapKho();
            UCtrl_QLKho_NCC = new QuanLyKho.UCtrlNhaCungCap();
            UCtrl_QLKho_NguyenLieu = new QuanLyKho.UCtrlNguyenLieu();
            UCtrl_QLNH_QLThucDon = new QuanLyNhaHang.UCtrlQLThucDon();
            UCtrl_QLNH_QLNhanVien = new QuanLyNhaHang.UCtrlQLNhanVien();
            UCtrl_QLNH_QLDSBanAn = new QuanLyNhaHang.UCtrlQLDanhSachBanAn();
            UCtrl_QLNH_ThongKeDoanhThu = new QuanLyNhaHang.UCtrlThongKeDoanhThu();

            //--------------------
            UCtrl_TiepTan_DSDatBan.DatBan = new TiepTan.UCtrlDSDatBan.deleDatBan(DatBan);

        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_XepBan);
        }
        private void Add_UserControl(Control Panel, Control UCtrl)
        {
            panelCtrl_Main.Controls.Clear();
            UCtrl.Dock = DockStyle.Fill;

            Panel.Controls.Add(UCtrl);
        }

        private void ThreadRun(Object Uctrl)
        {
            UCtrl_TiepTan_XepBan = new TiepTan.UCtrlXepBan();
        }

        #region " Tiep Tan "
        private void barBtn_TiepTan_XepBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_XepBan);
        }
        private void barBtn_TiepTan_DatBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TiepTan.frmDatBan _frmDatBan = new TiepTan.frmDatBan();
            //_frmDatBan.Show();
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_DatBan);
        }

        private void barBtn_TiepTan_DSDatBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_DSDatBan);
        }
        //------------
        private void DatBan()
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_DatBan);
        }
        #endregion

        #region " Thu Ngan "
        private void barBtn_ThuNgan_QLBanAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_ThuNgan_QLBanAn);
        }

        private void barBtn_ThuNgan_ChuyenBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNgan.frmChuyenBan _frmChuyenBan = new ThuNgan.frmChuyenBan();
            _frmChuyenBan.Show();
        }

        private void barBtn_ThuNgan_GhepBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThuNgan.frmGhepBan _frmGhepBan = new ThuNgan.frmGhepBan();
            _frmGhepBan.Show();
        }

        private void barBtn_ThuNgan_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_ThuNgan_ThongKe);
        }

#endregion

        #region " Quan Ly Kho "
        private void barBtn_QLKho_DatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_DatHang);
        }
        private void barBtn_NhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_NhapKho);
        }
        private void barBtn_QLKho_QLNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_NCC);
        }
        private void barBtn_QLNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_NguyenLieu);
        }
        #endregion

        #region " Quan Ly Nha Hang "
        private void barBtn_QLNhaHang_ThucDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLNH_QLThucDon);
        }
        private void barBtn_QLNhaHang_DSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLNH_QLNhanVien);           
        }

        private void barBtn_QLNhaHang_DSBanAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLNH_QLDSBanAn);
        }
        private void barBtn_QLNhaHang_ThongKeDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QLNH_ThongKeDoanhThu);
        }
        #endregion

        #region " Tong Quan Ly "

        #endregion

        #region " Quan Tri "
        private void barBrn_QuanTriNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region " Tuy Chon "
        private void barBtn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void rbGalleryBarItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            MybarAndDockingController.LookAndFeel.SkinName = e.Item.Tag.ToString();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = e.Item.Tag.ToString();
        }
        #endregion



    }
}
