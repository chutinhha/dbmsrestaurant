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
        DataTable dtDatHang;
        List<DatHang_DTO> lsDatHang;
        String _MaNH;
        int index_DatHang;
        public String MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        public UCtrlTTDatHang()
        {
            InitializeComponent();

            dtDatHang = new DataTable();
            dtDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtDatHang.Columns.Add("NCC", System.Type.GetType("System.String"));
            dtDatHang.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
            dtDatHang.Columns.Add("ThoiGianDat", System.Type.GetType("System.DateTime"));
            dtDatHang.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));
            dtDatHang.Columns.Add("TinhTrang", System.Type.GetType("System.String"));
        }
        #region "Control Event"
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
            dtDatHang.Clear();
            lsDatHang = BUS.DatHang_BUS.SelectDatHang(_MaNH);
            
            for (int i = 0; i < lsDatHang.Count; i++)
            {
                DataRow row = dtDatHang.NewRow();
                row["Stt"] = i + 1;
                row["NCC"] = lsDatHang[i].TenNCC;
                row["ThanhTien"] = lsDatHang[i].ThanhTien;
                row["ThoiGianDat"] = lsDatHang[i].ThoiGianDat;
                row["ThoiGianGiao"] = lsDatHang[i].ThoiGianGiao;
                row["TinhTrang"] = lsDatHang[i].TinhTrang;
                dtDatHang.Rows.Add(row);
            }
            gridDatHang.DataSource = dtDatHang;
        }
        public void LoadNguyenLieu(int MaHoaDon)
        {
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

        private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index_DatHang = gvDatHang.GetSelectedRows()[0];
            LoadNguyenLieu(lsDatHang[index_DatHang].MaHoaDon);
        }
    }
}
