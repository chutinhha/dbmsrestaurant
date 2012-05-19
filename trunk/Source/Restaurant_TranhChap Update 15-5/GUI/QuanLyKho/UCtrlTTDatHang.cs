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
            int sttDH;
            int indexDH;
            String maNH;

            public String MaNH
            {
                get { return maNH; }
                set { maNH = value; }
            }
            public List<VDatHang_DTO> LsDatHang
            {
                get { return lsDatHang; }
                set { lsDatHang = value; }
            }
            public int SttDH
            {
                get { return sttDH; }
                set { sttDH = value; }
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
               try 
	            {	        
		            indexDH = gvDatHang.GetSelectedRows()[0];
                    sttDH = int.Parse(gvDatHang.GetDataRow(indexDH)["STT"].ToString());
                    LoadChiTietDH(lsDatHang[sttDH-1].MaHoaDon);
	            }
	            catch (Exception){ sttDH =-1;}
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
                gridChiTietDH.DataSource = null;
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
                gridChiTietDH.DataSource = dtChiTietDH;
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

                    frmDatHang.LoadDuLieu(1);

                    if (frmDatHang.ShowDialog() == DialogResult.OK)     //Mo form chon nguyen lieu va thong tin dat hang
                    {
                        try
                        {
                            int MaHD = busDatHang.InsertDatHang(frmDatHang.ThongTinDH,frmDatHang.DtChiTietDatHang);
                            if (MaHD == -1)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Đặt hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                LoadDSDatHang();
                                if (dtDatHang.Rows.Count > 0)
                                    gvDatHang.SelectRow(0);
                                DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm đơn đặt hàng mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Đặt hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                }
            }
            public void CapNhatHDDatHang()
            {
                if (sttDH != -1)
                {
                    if (lsDatHang[sttDH - 1].TinhTrang == "Đã Giao" || lsDatHang[sttDH - 1].TinhTrang == "Hủy")
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Không thể cập nhật đơn đặt hàng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        frmDatHang frmDatHang = new frmDatHang();
                        frmDatHang.ThongTinDH = lsDatHang[sttDH - 1];
                        frmDatHang.LoadThongTinDatHang();

                        frmDatHang.LoadDuLieu(2);

                        if (frmDatHang.ShowDialog() == DialogResult.OK)
                        {
                            
                            try
                            {
                                int result = busDatHang.UpdateDatHang(frmDatHang.ThongTinDH, frmDatHang.DtChiTietDatHang);
                                if (result == -1)
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thông tin đặt hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    LoadDSDatHang();
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã cập nhật đơn đặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thông tin đặt hàng thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            public void XoaDatHang()
            {
                if (sttDH != -1)
                {
                    if (lsDatHang[sttDH - 1].TinhTrang == "Chưa Giao")
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Đơn đặt hàng chưa giao không thể xóa \n Bạn phải hủy đơn đặt hàng này mới được xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int MaHD = lsDatHang[sttDH - 1].MaHoaDon;
                        if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc là xóa đơn đặt hàng này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (busDatHang.DeleteDatHang(MaHD) == 1)
                            {
                                LoadDSDatHang();
                                if (dtDatHang.Rows.Count == 0)
                                    dtChiTietDH.Clear();
                                DevExpress.XtraEditors.XtraMessageBox.Show("Đã xóa đơn đặt hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa đặt hàng không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            public void HuyDatHang()
            {
                if (sttDH != -1)
                {
                    if (lsDatHang[sttDH-1].TinhTrang != "Hủy")
                    {
                        if (lsDatHang[sttDH-1].TinhTrang == "Đã Giao")
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Không thể Hủy đơn đặt hàng này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc là hủy đơn đặt hàng này không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (busDatHang.UpdateTinhTrangDatHang(lsDatHang[sttDH - 1].MaHoaDon, "Hủy") == 1)
                                {
                                    LoadDSDatHang();
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã hủy đơn đặt hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Hủy đặt hàng không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
                            }
                        }
                    }
                }
            }
           
        #endregion
      
    }
}
