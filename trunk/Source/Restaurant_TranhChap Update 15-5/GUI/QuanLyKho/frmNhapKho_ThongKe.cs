using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
//Imports System.Diagnostics

using DTO;
using BUS;
namespace GUI.QuanLyKho
{
    public partial class frmNhapKho_ThongKe : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtDS;
        List<VDatHang_DTO> lsHoaDon;
        String maNH;

        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        VDatHang_BUS busDatHang;

        public frmNhapKho_ThongKe()
        {
            InitializeComponent();

            busDatHang =new VDatHang_BUS();
            lsHoaDon = new List<VDatHang_DTO>();
            dtDS = new DataTable();

            dtDS.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtDS.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtDS.Columns.Add("TongTien", System.Type.GetType("System.Double"));
            dtDS.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));
        }
        public void LoadChar()
        {
            charCtrl_BieuDoNhapKho.Series.Clear();
            Series seri = new Series("", ViewType.Bar);
            charCtrl_BieuDoNhapKho.Series.Add(seri);
            charCtrl_BieuDoNhapKho.DataSource = dtDS; ;
            charCtrl_BieuDoNhapKho.SeriesDataMember = "ThoiGianGiao";
            charCtrl_BieuDoNhapKho.SeriesTemplate.ArgumentDataMember = "ThoiGianGiao";
            charCtrl_BieuDoNhapKho.SeriesTemplate.ValueDataMembers.AddRange(new String[] {"TongTien"});
            charCtrl_BieuDoNhapKho.Visible = true;

        }
        public void LoadDS()
        {
            dtDS.Rows.Clear();
            lsHoaDon = busDatHang.SelectDatHang_TinhTrang(maNH, "Đã Giao");
            for (int i = 0; i < lsHoaDon.Count; i++)
            {
                DataRow row = dtDS.NewRow();
                row["STT"] = i + 1;
                row["TenNCC"] = lsHoaDon[i].TenNCC;
                row["TongTien"] = lsHoaDon[i].TongTien;
                row["ThoiGianGiao"] = lsHoaDon[i].ThoiGianGiao;
                dtDS.Rows.Add(row);
            }
        }

        private void frmNhapKho_ThongKe_Load(object sender, EventArgs e)
        {
            LoadDS();
            LoadChar();
        }
    }
}