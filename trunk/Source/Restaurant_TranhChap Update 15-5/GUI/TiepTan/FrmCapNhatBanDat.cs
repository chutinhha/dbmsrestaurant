using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI.TiepTan
{
    public partial class FrmCapNhatBanDat : DevExpress.XtraEditors.XtraForm
    {
        public DatBan_DTO bandat = new DatBan_DTO();
        public int flag = 0;
        DatBan_BUS DatBan_BUS;
        public SqlCommand cm;
        int trangThaiOld;
        int trangThaiNew;

        public FrmCapNhatBanDat()
        {
            InitializeComponent();
        }

        private void FrmCapNhatBanDat_Load(object sender, EventArgs e)
        {
            DatBan_BUS = new DatBan_BUS(cm);
            DocKhachHang();
            DocBanAn();
            if (bandat!=null)
            {
                cbbKhachHang.SelectedValue = bandat.MaKhachHang;
                cbbBanAn.SelectedValue = bandat.MaBan;
                if (bandat.TrangThai == "Chưa đến ăn")
                {
                    cbbHienTrang.SelectedIndex = 1;
                    trangThaiOld = 0;
                }
                else
                {
                    cbbHienTrang.SelectedIndex = 0;
                    trangThaiOld = 1;
                }
                calcEdit_ThoiGianDen.Text = bandat.ThoiGianDen;
            }
        }
        private void DocKhachHang()
        {
            cbbKhachHang.DataSource = KhachHang_BUS.DocKhacHang();
            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "cmnd";
        }
        private void DocBanAn()
        {
            cbbBanAn.DataSource = DatBan_BUS.DocBanTrong(int.Parse(bandat.MaNH));
            cbbBanAn.DisplayMember = "MaBan";
            cbbBanAn.ValueMember = "MaBan";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string maBan = bandat.MaBan;
            string maNH = bandat.MaNH;
            string thoiGianDen = DateTime.Parse(bandat.ThoiGianDen).ToString("MM/dd/yyyy");
            bandat.MaBan = cbbBanAn.SelectedValue.ToString();
            bandat.MaKhachHang = cbbKhachHang.SelectedValue.ToString();
            bandat.TrangThai = cbbHienTrang.Text;
            if (cbbHienTrang.Text == "Đã đến ăn")
                trangThaiNew = 1;
            bandat.ThoiGianDen = DateTime.Parse( calcEdit_ThoiGianDen.Text).ToString("dd/MM/yyyy");
            bandat.TenKhachHang = cbbKhachHang.Text;
            DatBan_BUS datbancommit = new BUS.DatBan_BUS(cm);
            flag=datbancommit.UpdateDatBan(bandat,maBan,maNH,thoiGianDen);
            if (trangThaiOld == 0 && trangThaiNew == 1)
                HoaDon_BUS.ThemHoaDon(int.Parse(bandat.MaBan), 1);
            
        }
    }
}