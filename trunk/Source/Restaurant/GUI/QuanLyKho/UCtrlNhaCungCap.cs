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
        String _MaNH;
        public String MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        List<NhaCungCap_DTO> lsNCC;
        List<NguyenLieu_DTO> lsNguyenLieu;
        DataTable dtNCC;
        int indexNCC ;

        public UCtrlNhaCungCap()
        {
            InitializeComponent();
            lsNCC = new List<NhaCungCap_DTO>();
            dtNCC = new DataTable();
            indexNCC = -1;

            dtNCC.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtNCC.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("sdt", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("DiaChi", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("DiemUuTien", System.Type.GetType("System.Int32"));
        }
        private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            indexNCC = gvNCC.GetSelectedRows()[0];
            LoadNguyenLieu(lsNCC[indexNCC].MaNCC);
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
        private void btnInDSNCC_Click(object sender, EventArgs e)
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

        #region "Cac ham xu ly "
        public void LoadNhaCungCap()
        {
            gridNCC.DataSource =null;
            dtNCC.Clear();
            lsNCC = NhaCungCap_BUS.SelectNhaCungCap();

            for (int i = 0; i < lsNCC.Count; i++)
            {
                DataRow row = dtNCC.NewRow();
                row["Stt"] = i + 1;
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
            lvNguyenLieu.Items.Clear();
            lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_fromNCC(MaNCC,_MaNH);
            for (int i = 0; i < lsNguyenLieu.Count; i++)
            {
                ListViewItem lvItem = new ListViewItem(new String [] {(i+1).ToString(), lsNguyenLieu[i].TenNL});
                lvNguyenLieu.Items.Add(lvItem);
            }
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
                dtNCC.Rows.Add(row);
                //lsNguyenLieu.Add(_frm.NguyenLieu);
            }
        }
        public void CapNhatNhaCungCap()
        {
            frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
            _frm.Flag = 2;
            _frm.MaNH = _MaNH;
            _frm.MaNCC = lsNCC[indexNCC].MaNCC;
            _frm.TenNCC = lsNCC[indexNCC].TenNCC;
            _frm.DiaChi = lsNCC[indexNCC].DiaChi;
            _frm.SDT = lsNCC[indexNCC].sdt;
            _frm.DiemUuTien = lsNCC[indexNCC].DiemUuTien.ToString();
            _frm.lsNguyenLieuChon = lsNguyenLieu;
            _frm.LoadNguyenLieuChon();
            _frm.LoadNguyenLieu(2);
            if (_frm.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dtNCC.NewRow();
                row["STT"] = dtNCC.Rows.Count + 1;
                dtNCC.Rows.Add(row);
                //lsNguyenLieu.Add(_frm.NguyenLieu);
            }
        }
        public void XoaNhaCungCap()
        {
        }
        #endregion
    }
}
