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
using DTO;
namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region "Thuoc Tinh"
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
        TongQuanLy.UCtrlDSNhaHang UCtrl_TongQL_DSNhaHang;
        TongQuanLy.UCtrlQLNhanVien UCtrl_TongQL_DSNhanVien;
        TongQuanLy.UCtrlTongHopDoanhThu UCtrl_TongQL_TongHopDoanhThu;
        //-----------------------------------------------------------
        String strGiaoDien = "";
        int mode =0; //default
        //-------------------------------------
        NhanVien_DTO nhanVien;
        #endregion

        #region "Properties"
        public NhanVien_DTO NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }
        #endregion

        #region " Khoi tao form & Load "
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
            MybarAndDockingController.LookAndFeel.SkinName = strGiaoDien;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = strGiaoDien;
        }
       
        private void frm_Main_Load(object sender, EventArgs e)
        {
            //Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_XepBan);
            switch (nhanVien.MaLoaiNhanVien.Trim())
            {
                case "1":
                    rbPage_QLNhaHang.Visible = true;
                    rbPage_QLKho.Visible = true;
                    rbPage_TiepTan.Visible = true;
                    rbPage_ThuNgan.Visible = true;
                    Add_UserControl(panelCtrl_Main, UCtrl_QLNH_QLThucDon);
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[3];
                    
                    break;
                case "2":
                    rbPage_QLKho.Visible = true;
                    UCtrl_QLKho_DatHang.MaNH = nhanVien.MaNH;
                    Add_UserControl(panelCtrl_Main, UCtrl_QLKho_DatHang);
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[2];
                    break;
                case "3":
                    rbPage_TiepTan.Visible = true;
                    Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_XepBan);
                    UCtrl_TiepTan_XepBan.LoadForm();
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[0];
                    break;
                case "4":
                    rbPage_ThuNgan.Visible = true;
                    Add_UserControl(panelCtrl_Main, UCtrl_ThuNgan_QLBanAn);
                    UCtrl_ThuNgan_QLBanAn.load_ListBoxBanAn();
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[1];
                    break;
                case "7":
                    rbPage_TongQuanLy.Visible = true;
                    rbPage_QLNhaHang.Visible = true;
                    rbPage_QLKho.Visible = true;
                    rbPage_TiepTan.Visible = true;
                    rbPage_ThuNgan.Visible = true;
                    Add_UserControl(panelCtrl_Main, UCtrl_TongQL_DSNhaHang);
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[4];
                    break;
                case "6":
                    rbPage_QuanTri.Visible = true;
                    Add_UserControl(panelCtrl_Main, UCtrl_QuanTri_QTNguoiDung);
                    rbControl_Main.SelectedPage = rbControl_Main.Pages[5];
                    break;
                default: break;
            }
            rbPage_TuyChon.Visible = true;
        }
        #endregion

        #region "Cac ham xu ly"
        public void KhoiTaoUserControl()
            {
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
                UCtrl_TongQL_DSNhaHang = new TongQuanLy.UCtrlDSNhaHang();
                UCtrl_TongQL_DSNhanVien = new TongQuanLy.UCtrlQLNhanVien();
                UCtrl_TongQL_TongHopDoanhThu = new TongQuanLy.UCtrlTongHopDoanhThu();
                UCtrl_QuanTri_QTNguoiDung = new QuanTri.UCtrlQuanTriNguoiDung();
                UCtrl_QuanTtri_PhanQuyen = new QuanTri.UCtrlPhanQuyen();
                UCtrl_QuanTri_CoSoDuLieu = new QuanTri.UCtrlCoSoDuLieu();
                //--------------------
                //--------------------
                UCtrl_TiepTan_DSDatBan.DatBan = new TiepTan.UCtrlDSDatBan.deleDatBan(DatBan);
                UCtrl_QLKho_NhapKho.evenNhapKho = new QuanLyKho.UCtrlNhapKho.deleNhapKho(evenNhapKho);
            }
            private void Add_UserControl(Control Panel, Control UCtrl)
            {
                    Panel.Controls.Clear();
                    UCtrl.Dock = DockStyle.Fill;
                    Panel.Controls.Add(UCtrl);
            }
        #endregion

        #region " Tiep Tan "
        private void barBtn_TiepTan_XepBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_XepBan);
            UCtrl_TiepTan_XepBan.LoadForm();
        }
        private void barBtn_TiepTan_DatBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TiepTan.frmDatBan _frmDatBan = new TiepTan.frmDatBan();
            //_frmDatBan.Show();
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_DatBan);
            UCtrl_TiepTan_DatBan.LoadForm();
        }

        private void barBtn_TiepTan_DSDatBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TiepTan_DSDatBan);
            UCtrl_TiepTan_DSDatBan.LoadForm();
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
            UCtrl_ThuNgan_QLBanAn.load_ListBoxBanAn();
        }

        private void barBtn_ThuNgan_ChuyenBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ThuNgan.frmChuyenBan _frmChuyenBan = new ThuNgan.frmChuyenBan();
            //_frmChuyenBan.Show();
            UCtrl_ThuNgan_QLBanAn.ShowFormChuyenBan();
        }

        private void barBtn_ThuNgan_GhepBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_ThuNgan_QLBanAn.ShowFormGhepBan();
        }

        private void barBtn_ThuNgan_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_ThuNgan_ThongKe);
        }

#endregion

        #region " Quan Ly Kho "
        private void barBtn_QLKho_DatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_QLKho_DatHang.MaNH = nhanVien.MaNH;
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_DatHang);
            
        }
        private void barBtn_NhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCtrl_QLKho_NhapKho.MaNH = nhanVien.MaNH;
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_NhapKho);
        }
        private void barBtn_QLKho_QLNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_QLKho_NCC.MaNH = nhanVien.MaNH;
            Add_UserControl(panelCtrl_Main, UCtrl_QLKho_NCC);
            
        }
        private void barBtn_QLNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UCtrl_QLKho_NguyenLieu.MaNH = nhanVien.MaNH;
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
        private void barBtn_TongQL_DanhSachNhaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TongQL_DSNhaHang);
        }

        private void barBtn_TongQL_QLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TongQL_DSNhanVien);
        }

        private void barBtn_TongQL_TongHopDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_TongQL_TongHopDoanhThu);
        }
        #endregion

        #region " Quan Tri "
        private void barBtn_QuanTri_QuanTriNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QuanTri_QTNguoiDung);
        }

        private void barBtn_QuanTri_PhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QuanTtri_PhanQuyen);
        }

        private void barBtn_QuanTri_QuantrCoSoDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_UserControl(panelCtrl_Main, UCtrl_QuanTri_CoSoDuLieu);
        }

        #endregion

        #region " Tuy Chon "
        private void barBtn_TuyChon_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtn_TuyChon_TroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtn_TuyChon_GioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void barBtn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void rbGalleryBarItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            MybarAndDockingController.LookAndFeel.SkinName = e.Item.Tag.ToString();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = e.Item.Tag.ToString();
        }
        #endregion

        #region "Even delegate"
        public void evenNhapKho()
        {
            UCtrl_QLKho_DatHang.LoadDSDatHang();
            UCtrl_QLKho_DatHang.LoadChiTietDH(UCtrl_QLKho_DatHang.LsDatHang[UCtrl_QLKho_DatHang.SttDH - 1].MaHoaDon);

            UCtrl_QLKho_NguyenLieu.LoadNguyenLieu();
        }
        #endregion

        private void barDefault_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barDefault.Checked == true)
            {
                mode = 0;
                changeMode();
                this.Text = "Quản Lý Nhà Hàng - Default";
                MessageBox.Show("Chế độ bình thường");
                barError.Checked = false;
                barXuLy.Checked = false;
            }
        }

        private void barError_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barError.Checked == true)
            {
                mode = 1;
                changeMode();
                this.Text = "Quản Lý Nhà Hàng - Error";
                MessageBox.Show("Chế độ giả lập tranh chấp với waitfor delay");
                barDefault.Checked = false;
                barXuLy.Checked = false;
            }
        }

        private void barFix_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barXuLy.Checked == true)
            {
                mode = 2;
                changeMode();
                this.Text = "Quản Lý Nhà Hàng - Fix";
                MessageBox.Show("Chế độ fix lỗi xung đột ");
                barError.Checked = false;
                barDefault.Checked = false;
            }
        }
        private void changeMode()
        {
            UCtrl_QLKho_DatHang.Mode = mode;
            UCtrl_QLKho_NCC.Mode = mode;
            UCtrl_QLKho_NguyenLieu.Mode = mode;
            UCtrl_QLKho_NhapKho.Mode = mode;
        }


    }
}
