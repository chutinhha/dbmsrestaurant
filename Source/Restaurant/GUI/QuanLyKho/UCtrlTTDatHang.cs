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
                dtDatHang.Columns.Add("TongTien", System.Type.GetType("System.Double"));
                dtDatHang.Columns.Add("ThoiGianDat", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("TinhTrang", System.Type.GetType("System.String"));

                lsChiTietDH = new List<ChiTietDatHang_DTO>();
                dtChiTietDH = new DataTable();
                dtChiTietDH.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtChiTietDH.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
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
                ThemHDDatHang();
            }

            private void btnCapNhatDatHang_Click(object sender, EventArgs e)
            {
                CapNhatHDDatHang();
            }

            private void btnXoaDatHang_Click(object sender, EventArgs e)
            {
                XoaHDDatHang();
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
                    row["TongTien"] = lsDatHang[i].TongTien;
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
                    row["ThanhTien"] = lsChiTietDH[i].ThanhTien;
                    dtChiTietDH.Rows.Add(row);
                }
                gridChiTietHD.DataSource = dtChiTietDH;
            }
            public void ThemHDDatHang()
            {
                frmDatHang_ChonNCC _frmChonNCC = new frmDatHang_ChonNCC();
                _frmChonNCC.MaNH = _MaNH;
                
                _frmChonNCC.LoadDanhSachNCC();
                while (_frmChonNCC.ShowDialog() == DialogResult.OK)
                {
                    frmDatHang _frmDatHang = new frmDatHang();
                    _frmDatHang.ThongTinDH.MaNH = _MaNH;
                    _frmDatHang.ThongTinDH.MaNCC = _frmChonNCC.MaNCC;
                    _frmDatHang.LoadNguyenLieu();
                    _frmDatHang.TenNCC = _frmChonNCC.TenNCC;
                    if (_frmDatHang.ShowDialog() == DialogResult.OK)
                    {
                        int MaHD = BUS.DatHang_BUS.InsertDatHang(_frmDatHang.ThongTinDH);
                        for(int i = 0;i<_frmDatHang.lsDSDatHang.Count;i++)
                        {
                            _frmDatHang.lsDSDatHang[i].MaHoaDon = MaHD;
                            BUS.ChiTietDatHang_BUS.InsertChiTietDatHang(_frmDatHang.lsDSDatHang[i]);
                        }
                        LoadDSDatHang();
                        break;
                    }
                }
            }
            public void XoaHDDatHang()
            {
            }
            public void CapNhatHDDatHang()
            {
                frmDatHang _frmDatHang = new frmDatHang();
                _frmDatHang.ThongTinDH = lsDatHang[index_DatHang];
                _frmDatHang.LoadThongTinDatHang();
                _frmDatHang.lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_NotIn_ChiTietDatHang(lsDatHang[index_DatHang].MaHoaDon,lsDatHang[index_DatHang].MaNCC,_MaNH);
                _frmDatHang.lsDSDatHang = BUS.ChiTietDatHang_BUS.SelectChiTietDatHang(lsDatHang[index_DatHang].MaHoaDon);
                _frmDatHang.Load_gridDSDatHang();
                _frmDatHang.Load_lvNguyenLieu();

                if (_frmDatHang.ShowDialog() == DialogResult.OK)
                {
                    if(BUS.DatHang_BUS.UpdateDatHang(_frmDatHang.ThongTinDH)>0)
                    {
                        int MaHD = lsDatHang[index_DatHang].MaHoaDon;
                        BUS.ChiTietDatHang_BUS.DeleteChiTietDatHang(MaHD);
                        for (int i = 0; i < _frmDatHang.lsDSDatHang.Count; i++)
                        {
                            _frmDatHang.lsDSDatHang[i].MaHoaDon = MaHD;
                            BUS.ChiTietDatHang_BUS.InsertChiTietDatHang(_frmDatHang.lsDSDatHang[i]);
                        }
                        LoadDSDatHang();
                        LoadChiTietDH(MaHD);
                    }
                }
            }
        #endregion

       
    }
}
