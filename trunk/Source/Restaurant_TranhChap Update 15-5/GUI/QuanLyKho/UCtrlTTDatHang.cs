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
            VBus MyBus;
            VNhaCungCap_BUS busNhaCungCap;
            VDatHang_BUS busDatHang;
            VChiTietDatHang_BUS busChiTietDatHang;
            VNguyenLieu_BUS busNguyenLieu;

            DataTable dtDatHang;
            DataTable dtChiTietDH;
            List<VDatHang_DTO> lsDatHang;
            List<VChiTietDatHang_DTO> lsChiTietDH;
            int index_DatHang;

            String maNH;

            public String MaNH
            {
                get { return maNH; }
                set { maNH = value; }
            }
        #endregion

        #region " Khoi tao "
            public UCtrlTTDatHang()
            {
                InitializeComponent();

                MyBus = new VBus();
                busNhaCungCap = new VNhaCungCap_BUS();
                busDatHang = new VDatHang_BUS();
                busChiTietDatHang = new VChiTietDatHang_BUS();
                busNguyenLieu = new VNguyenLieu_BUS();

                lsDatHang = new List<VDatHang_DTO>();
                dtDatHang = new DataTable();
                dtDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtDatHang.Columns.Add("TenNCC", System.Type.GetType("System.String"));
                dtDatHang.Columns.Add("TongTien", System.Type.GetType("System.Double"));
                dtDatHang.Columns.Add("ThoiGianDat", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));
                dtDatHang.Columns.Add("TinhTrang", System.Type.GetType("System.String"));

                lsChiTietDH = new List<VChiTietDatHang_DTO>();
                dtChiTietDH = new DataTable();
                dtChiTietDH.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtChiTietDH.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtChiTietDH.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
            }
        #endregion

        #region "Control Event"
            private void UCtrlTTDatHang_Load(object sender, EventArgs e)
            {
                LoadDSDatHang();
            }
            private void btnRefresh_Click(object sender, EventArgs e)
            {
                LoadDSDatHang();
            }
            private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                if (gvDatHang.GetSelectedRows().Length > 0)
                {
                    index_DatHang = gvDatHang.GetSelectedRows()[0];
                    LoadChiTietDH(lsDatHang[index_DatHang].MaHoaDon);
                }
                else
                    index_DatHang = -1;
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
                XoaDatHang();
            }

            private void btnHuyDatHang_Click(object sender, EventArgs e)
            {
                HuyDatHang();
            }
        #endregion

        #region " Cac ham xu ly"
            public void LoadDSDatHang()
            {
                gridDatHang.DataSource = null;
                dtDatHang.Rows.Clear();
                lsDatHang = busDatHang.SelectDatHang(maNH);
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
                lsChiTietDH = busChiTietDatHang.SelectChiTietDatHang(MaHoaDon);
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
                frmDatHang_ChonNCC frmChonNCC = new frmDatHang_ChonNCC(); // khoi tao form chon nha cung cap
                frmChonNCC.MaNH = maNH;



                frmChonNCC.LoadDanhSachNCC();
                

                while (frmChonNCC.ShowDialog() == DialogResult.OK)  //Mo form chon Nha cung cap
                {
                    frmDatHang frmDatHang = new frmDatHang();
                    frmDatHang.ThongTinDH.MaNH = maNH;
                    frmDatHang.ThongTinDH.MaNCC = frmChonNCC.MaNCC;
                    frmDatHang.ThongTinDH.TenNCC = frmChonNCC.TenNCC;
                    frmDatHang.TenNCC = frmChonNCC.TenNCC;

                    frmDatHang.LoadNguyenLieu();

                    if (frmDatHang.ShowDialog() == DialogResult.OK)     //Mo form chon nguyen lieu va thong tin dat hang
                    {
                       // int MaHD = busDatHang.InsertDatHang(frmDatHang.ThongTinDH);
                        //for(int i = 0;i<frmDatHang.lsDSDatHang.Count;i++)
                        //{
                        //    frmDatHang.lsDSDatHang[i].MaHoaDon = MaHD;

                        //    if (i < frmDatHang.lsDSDatHang.Count - 1)
                        //        busChiTietDatHang.InsertChiTietDatHang(frmDatHang.lsDSDatHang[i]);
                        //    else
                        //       busChiTietDatHang.InsertChiTietDatHang(frmDatHang.lsDSDatHang[i]);
                        //}
                        busNhaCungCap = new VNhaCungCap_BUS();
                        busDatHang = new VDatHang_BUS();
                        busChiTietDatHang = new VChiTietDatHang_BUS();
                        busNguyenLieu = new VNguyenLieu_BUS();

                        LoadDSDatHang();
                        break;
                    }
                }
            }
            public void CapNhatHDDatHang()
            {
                if (index_DatHang != -1)
                {
                    if (lsDatHang[index_DatHang].TinhTrang == "Đã Giao" || lsDatHang[index_DatHang].TinhTrang == "Hủy")
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Không thể cập nhật đơn đặt hàng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frmDatHang _frmDatHang = new frmDatHang();
                        _frmDatHang.ThongTinDH = lsDatHang[index_DatHang];
                        _frmDatHang.LoadThongTinDatHang();


                        //_frmDatHang.lsNguyenLieu = busNguyenLieu.SelectNguyenLieu_NotIn_ChiTietDatHang(lsDatHang[index_DatHang].MaHoaDon, lsDatHang[index_DatHang].MaNCC, maNH);
                      //  _frmDatHang.lsDSDatHang = busChiTietDatHang.SelectChiTietDatHang(lsDatHang[index_DatHang].MaHoaDon);
                       
                       
                        _frmDatHang.Load_gridDSDatHang();
                        _frmDatHang.Load_lvNguyenLieu();

                        if (_frmDatHang.ShowDialog() == DialogResult.OK)
                        {
                            if (busDatHang.UpdateDatHang(_frmDatHang.ThongTinDH) > 0)
                            {
                                int MaHD = lsDatHang[index_DatHang].MaHoaDon;
                                busChiTietDatHang.DeleteChiTietDatHang(MaHD);
                                //for (int i = 0; i < _frmDatHang.lsDSDatHang.Count; i++)
                                //{
                                //    //_frmDatHang.lsDSDatHang[i].MaHoaDon = MaHD;
                                //    //BUS.ChiTietDatHang_BUS.InsertChiTietDatHang(_frmDatHang.lsDSDatHang[i]);
                                //}
                                LoadDSDatHang();
                                LoadChiTietDH(MaHD);
                            }
                        }
                    }
                }
            }
            public void XoaDatHang()
            {
                if (index_DatHang != -1)
                {
                    if (lsDatHang[index_DatHang].TinhTrang == "Chưa Giao")
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Đơn đặt hàng chưa giao không thể xóa \n Bạn phải hủy đơn đặt hàng này mới được xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int MaHD = lsDatHang[index_DatHang].MaHoaDon;
                        busDatHang.DeleteDatHang(MaHD);
                        LoadDSDatHang();
                        if (dtDatHang.Rows.Count == 0)
                            dtChiTietDH.Clear();
                    }
                }                   
            }
            public void HuyDatHang()
            {
                if (index_DatHang != -1)
                {
                    if (lsDatHang[index_DatHang].TinhTrang != "Hủy")
                    {
                        if (lsDatHang[index_DatHang].TinhTrang == "Đã Giao")
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Không thể Hủy đơn đặt hàng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc là hủy đơn đặt hàng này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                lsDatHang[index_DatHang].TinhTrang = "Hủy";
                                busDatHang.UpdateDatHang(lsDatHang[index_DatHang]);
                                LoadDSDatHang();
                            }
                        }
                    }
                }
            }
           
        #endregion
      
    }
}
