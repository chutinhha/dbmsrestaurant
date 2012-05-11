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
    public partial class UCtrlNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        #region " Thuoc tinh && Properties "
            String _MaNH;
            public String MaNH
            {
                get { return _MaNH; }
                set { _MaNH = value; }
            }

            List<NhaCungCap_DTO> lsNCC;
            List<NguyenLieu_DTO> lsNguyenLieu;
            DataTable dtNCC;
            DataTable dtNL;
            int indexNCC ;
            int index_NL;
            BUS.NguyenLieu_BUS _NguyenLieuBUS;
        #endregion

        #region " Khoi tao "
            public UCtrlNhaCungCap()
            {
                _NguyenLieuBUS = new NguyenLieu_BUS();

                InitializeComponent();
                lsNCC = new List<NhaCungCap_DTO>();
                dtNCC = new DataTable();            
                indexNCC = -1;            
                dtNCC.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtNCC.Columns.Add("TenNCC", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("sdt", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("DiaChi", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("DiemUuTien", System.Type.GetType("System.Int32"));

                lsNguyenLieu = new List<NguyenLieu_DTO>();
                dtNL = new DataTable();
                index_NL = -1;
                dtNL.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtNL.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtNL.Columns.Add("Gia", System.Type.GetType("System.Double"));
            }
        #endregion

        #region " Event Control "

            private void UCtrlNhaCungCap_Load(object sender, EventArgs e)
            {
                LoadNhaCungCap();
            }
            private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                indexNCC = gvNCC.GetSelectedRows()[0];
                LoadNguyenLieu(lsNCC[indexNCC].MaNCC);
            }
            private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                if (gvNguyenLieu.GetSelectedRows().Length > 0)
                {
                    index_NL = gvNguyenLieu.GetSelectedRows()[0];
                    txtGia.Text = lsNguyenLieu[index_NL].Gia.ToString();
                }
               
            }
            private void btnThemNCC_Click(object sender, EventArgs e)
            {
                ThemNhaCungCap();
            }
            private void btnCapNhatNCC_Click(object sender, EventArgs e)
            {
                CapNhatNhaCungCap();
            }
            private void btnXoaNCC_Click(object sender, EventArgs e)
            {
                XoaNhaCungCap();
            }
            private void btnCapNhatGia_Click(object sender, EventArgs e)
            {
                BUS.ChiTietNCC_BUS.UpdateChiTietNCC(lsNguyenLieu[index_NL].MaNL, lsNCC[indexNCC].MaNCC, Double.Parse(txtGia.Text));
                LoadNguyenLieu(lsNCC[indexNCC].MaNCC);
            }
            private void btnRefresh_Click(object sender, EventArgs e)
            {
                LoadNhaCungCap();
            }
            private void txtGia_EditValueChanged(object sender, EventArgs e)
            {
                if (txtGia.Text.Trim().Length == 0)
                    txtGia.Text = "0";
            }
            private void btnInDSNCC_Click(object sender, EventArgs e)
            {
                InDSNCC();
            }
        #endregion

        #region "Cac ham xu ly "
            public void LoadNhaCungCap()
            {
                gridNCC.DataSource =null;
                dtNCC.Rows.Clear();
                lsNCC = NhaCungCap_BUS.SelectNhaCungCap();

                for (int i = 0; i < lsNCC.Count; i++)
                {
                    DataRow row = dtNCC.NewRow();
                    row["STT"] = i + 1;
                    row["TenNCC"] = lsNCC[i].TenNCC;
                    row["sdt"] = lsNCC[i].sdt;
                    row["DiaChi"] = lsNCC[i].DiaChi;
                    row["DiemUuTien"] = lsNCC[i].DiemUuTien;
                    dtNCC.Rows.Add(row);
                }
                gridNCC.DataSource = dtNCC;
            }
            public void LoadNguyenLieu(int MaNCC)
            {
                gridNguyenLieu.DataSource = null;
                dtNL.Rows.Clear();
                lsNguyenLieu = _NguyenLieuBUS.SelectNguyenLieu_fromNCC(2,-1,MaNCC,_MaNH);
                for (int i = 0; i < lsNguyenLieu.Count; i++)
                {
                    DataRow row = dtNL.NewRow();
                    row["Stt"] = i + 1;
                    row["TenNL"] = lsNguyenLieu[i].TenNL;
                    row["Gia"] = lsNguyenLieu[i].Gia;
                    dtNL.Rows.Add(row);
                }
                gridNguyenLieu.DataSource = dtNL;
            }
            public void ThemNhaCungCap()
            {
                frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
                _frm.lsNguyenLieuChon = new List<NguyenLieu_DTO>();
                _frm.Flag = 1;
                _frm.MaNH = _MaNH;
                _frm.LoadNguyenLieu(1);
                if(_frm.ShowDialog() == DialogResult.OK)
                {
                    DataRow row = dtNCC.NewRow();
                    row["STT"] = dtNCC.Rows.Count + 1;
                    row["TenNCC"] = _frm.NCC.TenNCC;
                    row["sdt"] = _frm.NCC.sdt;
                    row["DiaChi"] = _frm.NCC.DiaChi;
                    row["DiemUuTien"] = _frm.NCC.DiemUuTien;
                    dtNCC.Rows.Add(row);
                    lsNCC.Add(_frm.NCC);
                    gvNCC.FocusedRowHandle = dtNCC.Rows.Count - 1;
                }
            }
            public void CapNhatNhaCungCap()
            {
                frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
                _frm.Flag = 2;
                _frm.MaNH = _MaNH;
                _frm.NCC = lsNCC[indexNCC];
                _frm.lsNguyenLieuChon = lsNguyenLieu;
                _frm.LoadNguyenLieuChon();
                _frm.LoadNguyenLieu(2);

                if (_frm.ShowDialog() == DialogResult.OK)
                {
                    lsNCC[indexNCC] = _frm.NCC;
                    gvNCC.FocusedRowHandle = indexNCC-1;
                    gvNCC.FocusedRowHandle = indexNCC+1;
                }
            }
            public void XoaNhaCungCap()
            {
               BUS.NhaCungCap_BUS.DeleteNhaCungCap(lsNCC[indexNCC].MaNCC);
               lsNCC.RemoveAt(indexNCC);
               dtNCC.Rows.RemoveAt(indexNCC);
            }
            public void InDSNCC()
            {
                DevExpress.XtraPrinting.PrintingSystem printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
                DevExpress.XtraPrinting.PrintableComponentLink printLink = new DevExpress.XtraPrinting.PrintableComponentLink();
                try
                {
                    //Set to landscape
                    printingSystem1.PageSettings.Landscape = true;

                    this.Cursor = Cursors.WaitCursor;
                    printLink.Component = this.gridNCC;
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
        #endregion


    }
}
