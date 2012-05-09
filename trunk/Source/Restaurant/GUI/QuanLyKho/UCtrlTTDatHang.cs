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
namespace GUI.QuanLyKho
{
    public partial class UCtrlTTDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        #region " Thuoc tinh && Properties "
            DataTable dtDatHang;
            DataTable dtChiTietDH;
            List<DatHang_DTO> lsDatHang;
            List<ChiTietDatHang_DTO> lsChiTietDH;
            int index_DatHang;

            String _MaNH;
            public String MaNH
            {
                get { return _MaNH; }
                set { _MaNH = value; }
            }
        #endregion

        #region " Khoi tao "
            public UCtrlTTDatHang()
            {
                InitializeComponent();
                lsDatHang = new List<DatHang_DTO>();
                dtDatHang = new DataTable();
                dtDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtDatHang.Columns.Add("TenNCC", System.Type.GetType("System.String"));
                dtDatHang.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
                dtDatHang.Columns.Add("ThoiGianDat", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("TinhTrang", System.Type.GetType("System.String"));

                lsChiTietDH = new List<ChiTietDatHang_DTO>();
                dtChiTietDH = new DataTable();
                dtChiTietDH.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtChiTietDH.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("Gia", System.Type.GetType("System.Double"));
            }
        #endregion

        #region "Control Event"
            private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                index_DatHang = gvDatHang.GetSelectedRows()[0];
                LoadChiTietDH(lsDatHang[index_DatHang].MaHoaDon);
            }
            private void btnDatHang_Click(object sender, EventArgs e)
            {
                frmDatHang _frmDatHang = new frmDatHang();
                _frmDatHang.Show();
            }

            private void btnCapNhatDatHang_Click(object sender, EventArgs e)
            {

            }

            private void btnXoaDatHang_Click(object sender, EventArgs e)
            {

            }

            private void btnHuyDatHang_Click(object sender, EventArgs e)
            {

            }
        #endregion

        #region " Cac ham xu ly"
            public void LoadDSDatHang()
            {
                gridDatHang.DataSource = null;
                dtDatHang.Rows.Clear();
                lsDatHang = BUS.DatHang_BUS.SelectDatHang(_MaNH);
            
                for (int i = 0; i < lsDatHang.Count; i++)
                {
                    DataRow row = dtDatHang.NewRow();
                    row["STT"] = i + 1;
                    row["TenNCC"] = lsDatHang[i].TenNCC;
                    row["ThanhTien"] = lsDatHang[i].ThanhTien;
                    row["ThoiGianDat"] = lsDatHang[i].ThoiGianDat;
                    row["ThoiGianGiao"] = lsDatHang[i].ThoiGianGiao;
                    row["TinhTrang"] = lsDatHang[i].TinhTrang;
                    dtDatHang.Rows.Add(row);
                }
                gridDatHang.DataSource = dtDatHang;
            }
            public void LoadChiTietDH(int MaHoaDon)
            {
                gridChiTietHD.DataSource = null;
                dtChiTietDH.Rows.Clear();
                lsChiTietDH = BUS.ChiTietDatHang_BUS.SelectChiTietDatHang(MaHoaDon);

                for (int i = 0; i < lsChiTietDH.Count; i++)
                {
                    DataRow row = dtChiTietDH.NewRow();
                    row["STT"] = i + 1;
                    row["TenNL"] = lsChiTietDH[i].TenNL;
                    row["SoLuong"] = lsChiTietDH[i].SoLuong;
                    row["Gia"] = lsChiTietDH[i].Gia;
                    dtChiTietDH.Rows.Add(row);
                }
                gridChiTietHD.DataSource = dtChiTietDH;
            }
            public void ThemHDDatHang()
            {
            }
            public void XoaHDDatHang()
            {
            }
            public void CapNhatHDDatHang()
            {
            }
        #endregion

       
    }
}
