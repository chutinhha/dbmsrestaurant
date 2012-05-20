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
namespace GUI.QuanLyKho
{
    public partial class frmLapPhieuNhapKho : DevExpress.XtraEditors.XtraForm
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
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
        public frmLapPhieuNhapKho()
        {
            InitializeComponent();

            busDatHang = new VDatHang_BUS();
            busChiTietDatHang = new VChiTietDatHang_BUS();
            busNguyenLieu = new VNguyenLieu_BUS();

            lsDatHang = new List<VDatHang_DTO>();
            dtDatHang = new DataTable();
            dtDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtDatHang.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtDatHang.Columns.Add("TongTien", System.Type.GetType("System.Double"));
            dtDatHang.Columns.Add("ThoiGianDat", System.Type.GetType("System.DateTime"));

            lsChiTietDH = new List<VChiTietDatHang_DTO>();
            dtChiTietDH = new DataTable();
            dtChiTietDH.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtChiTietDH.Columns.Add("TenNL", System.Type.GetType("System.String"));
            dtChiTietDH.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
            dtChiTietDH.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
        }
        #region "Event Control"
        private void frmLapPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadDSDatHang();
        }

        private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                indexDH = gvDatHang.GetSelectedRows()[0];
                sttDH = int.Parse(gvDatHang.GetDataRow(indexDH)["STT"].ToString());
                LoadChiTietDH(lsDatHang[sttDH - 1].MaHoaDon);
            }
            catch (Exception) { sttDH = -1; }
        }
        #endregion 
        #region "Cac ham xu ly"

        public void LoadDSDatHang()
        {
            gridDatHang.DataSource = null;
            dtDatHang.Rows.Clear();
            lsDatHang = busDatHang.SelectDatHang_TinhTrang(mode, maNH, "Chưa Giao");
            for (int i = 0; i < lsDatHang.Count; i++)
            {
                DataRow row = dtDatHang.NewRow();
                row["STT"] = i + 1;
                row["TenNCC"] = lsDatHang[i].TenNCC;
                row["TongTien"] = lsDatHang[i].TongTien;
                row["ThoiGianDat"] = lsDatHang[i].ThoiGianDat;
                dtDatHang.Rows.Add(row);
            }
            gridDatHang.DataSource = dtDatHang;
        }
        public void LoadChiTietDH(int MaHoaDon)
        {
            gridChiTietDH.DataSource = null;
            dtChiTietDH.Rows.Clear();
            lsChiTietDH = busChiTietDatHang.SelectChiTietDatHang(mode, MaHoaDon);
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
        #endregion

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            try
            {
                if (busDatHang.UpdateTinhTrangDatHang(mode, lsDatHang[sttDH - 1].MaHoaDon, "Đã Giao") == 1)
                {

                    DevExpress.XtraEditors.XtraMessageBox.Show("Lập hóa đơn đặt hàng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lập hóa đơn đặt hàng thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
              
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);                                
              
            }
                         
        }

    }
}