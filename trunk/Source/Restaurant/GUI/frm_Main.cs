using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;

namespace GUI
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinGallery(rbGalleryBarItem_TuyChon_GiaoDien);
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            UCtrl_TiepTan_DatBan UCtrl = new UCtrl_TiepTan_DatBan();
            Add_UserControl(panelCtrl_Main, UCtrl);
        }
        private void Add_UserControl(Control Panel, Control UCtrl)
        {
            panelCtrl_Main.Controls.Clear();
            UCtrl.Dock = DockStyle.Fill;
            Panel.Controls.Add(UCtrl);
        }

        #region " Tiep Tan "
        private void barBtn_TiepTan_DanhMucKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_TiepTan_DanhMucKhachHang UCtrl = new UCtrl_TiepTan_DanhMucKhachHang();
            Add_UserControl(panelCtrl_Main, UCtrl);
        }
        private void barBtn_TiepTan_DatBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_TiepTan_DatBan UCtrl = new UCtrl_TiepTan_DatBan();
            Add_UserControl(panelCtrl_Main, UCtrl);
        }
        #endregion

        #region " Thu Ngan "
#endregion

        #region " Quan Ly Kho "
        private void barBtn_NhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtn_QLNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region " Quan Ly Nha Hang "
        private void barBtn_QLNhaHang_ThucDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_QLNhaHang_QLThucDon UCtrl = new UCtrl_QLNhaHang_QLThucDon();
            Add_UserControl(panelCtrl_Main, UCtrl);
        }
        private void barBtn_QLNhaHang_DSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_QLNhaHang_QLNhanVien UCtrl = new UCtrl_QLNhaHang_QLNhanVien();
            Add_UserControl(panelCtrl_Main, UCtrl);
           
        }

        private void barBtn_QLNhaHang_DSBanAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCtrl_QLNhaHang_DSBanAn UCtrl= new UCtrl_QLNhaHang_DSBanAn();
            Add_UserControl(panelCtrl_Main, UCtrl);
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
