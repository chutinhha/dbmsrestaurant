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
    public partial class UCtrlNhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        //Khai bao delegate
        public delegate void deleNhapKho();
        public deleNhapKho evenNhapKho;
        //---------------------------------------
        VDatHang_BUS busDatHang;
        VChiTietDatHang_BUS busChiTietDatHang;
        VNguyenLieu_BUS busNguyenLieu;

        DataTable dtHoaDon;
        DataTable dtChiTietHD;
        List<VDatHang_DTO> lsHoaDon;
        List<VChiTietDatHang_DTO> lsChiTietHD;
        int sttHD;
        int indexHD;
        String maNH;

        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        public UCtrlNhapKho()
        {
            InitializeComponent();

            busDatHang = new VDatHang_BUS();
            busChiTietDatHang = new VChiTietDatHang_BUS();
            busNguyenLieu = new VNguyenLieu_BUS();

            lsHoaDon = new List<VDatHang_DTO>();
            dtHoaDon = new DataTable();
            dtHoaDon.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtHoaDon.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtHoaDon.Columns.Add("TongTien", System.Type.GetType("System.Double"));
            dtHoaDon.Columns.Add("ThoiGianGiao", System.Type.GetType("System.DateTime"));

            lsChiTietHD = new List<VChiTietDatHang_DTO>();
            dtChiTietHD = new DataTable();
            dtChiTietHD.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtChiTietHD.Columns.Add("TenNL", System.Type.GetType("System.String"));
            dtChiTietHD.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
            dtChiTietHD.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
        }
        #region "Control Event"

        private void UCtrlNhapKho_Load(object sender, EventArgs e)
        {
            LoadDSHD();
        }
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapKho _frmLapPhieuNhapKho = new frmLapPhieuNhapKho();
            _frmLapPhieuNhapKho.MaNH = maNH;
            _frmLapPhieuNhapKho.Mode = mode;

           
            if (_frmLapPhieuNhapKho.ShowDialog() == DialogResult.OK)
            {
                LoadDSHD();
                LoadChiTietHD(lsHoaDon[sttHD - 1].MaHoaDon);
                //khoi dong su kien dat ban
                if (evenNhapKho != null)
                    evenNhapKho();
            }
        }

        private void gvDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                indexHD = gvHoaDon.GetSelectedRows()[0];
                sttHD = int.Parse(gvHoaDon.GetDataRow(indexHD)["STT"].ToString());
                LoadChiTietHD(lsHoaDon[sttHD - 1].MaHoaDon);
            }
            catch (Exception) { sttHD = -1; }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDSHD();
            LoadChiTietHD(lsHoaDon[sttHD - 1].MaHoaDon);
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink printLink = new DevExpress.XtraPrinting.PrintableComponentLink();
            try
            {
                //Set to landscape
                printingSystem1.PageSettings.Landscape = true;

                this.Cursor = Cursors.WaitCursor;
                printLink.Component = this.gridHoaDon;
                printLink.CreateDocument(printingSystem1);

                printingSystem1.PreviewRibbonFormEx.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
                printingSystem1.Dispose();
                printLink.Dispose();
            }
        }

        private void btnLapBieuDo_Click(object sender, EventArgs e)
        {
            frmNhapKho_ThongKe frmNhapKhoThongKe = new frmNhapKho_ThongKe();
            frmNhapKhoThongKe.Mode = mode;
            frmNhapKhoThongKe.MaNH = maNH;
            frmNhapKhoThongKe.ShowDialog();
        }

        #endregion

        #region "Cac ham xu ly "
        public void LoadDSHD()
        {
            gridHoaDon.DataSource = null;
            dtHoaDon.Rows.Clear();
            lsHoaDon = busDatHang.SelectDatHang_TinhTrang(mode, maNH, "Đã Giao");
            for (int i = 0; i < lsHoaDon.Count; i++)
            {
                DataRow row = dtHoaDon.NewRow();
                row["STT"] = i + 1;
                row["TenNCC"] = lsHoaDon[i].TenNCC;
                row["TongTien"] = lsHoaDon[i].TongTien;
                row["ThoiGianGiao"] = lsHoaDon[i].ThoiGianGiao;
                dtHoaDon.Rows.Add(row);
            }
            gridHoaDon.DataSource = dtHoaDon;
        }
        public void LoadChiTietHD(int MaHoaDon)
        {
            gridChiTietHD.DataSource = null;
            dtChiTietHD.Rows.Clear();
            lsChiTietHD = busChiTietDatHang.SelectChiTietDatHang(mode, MaHoaDon);
            for (int i = 0; i < lsChiTietHD.Count; i++)
            {
                DataRow row = dtChiTietHD.NewRow();
                row["STT"] = i + 1;
                row["TenNL"] = lsChiTietHD[i].TenNL;
                row["SoLuong"] = lsChiTietHD[i].SoLuong;
                row["ThanhTien"] = lsChiTietHD[i].ThanhTien;
                dtChiTietHD.Rows.Add(row);
            }
            gridChiTietHD.DataSource = dtChiTietHD;
        }
        #endregion


    }

}
