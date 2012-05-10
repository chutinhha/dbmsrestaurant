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
    public partial class frmDatHang_ChonNCC : DevExpress.XtraEditors.XtraForm
    {
        String _MaNH;

        int index_NCC;
        public String MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        int _MaNCC;
        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        List<NhaCungCap_DTO> lsNCC;
        List<NguyenLieu_DTO> lsNguyenLieu;
        DataTable dtNCC;
        public frmDatHang_ChonNCC()
        {
            InitializeComponent();

            lsNCC = new List<NhaCungCap_DTO>();
            dtNCC = new DataTable();
            index_NCC = -1;
            dtNCC.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtNCC.Columns.Add("TenNCC", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("sdt", System.Type.GetType("System.String"));
            dtNCC.Columns.Add("DiemUuTien", System.Type.GetType("System.Int32"));

            lsNguyenLieu = new List<NguyenLieu_DTO>();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            _MaNCC = lsNCC[index_NCC].MaNCC;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index_NCC = gvNCC.GetSelectedRows()[0];
            LoadDanhSachNL(lsNCC[index_NCC].MaNCC);
        }
        #region " Cac ham xu ly "
            public void LoadDanhSachNCC()
            {               
                gridNCC.DataSource = null;
                dtNCC.Rows.Clear();
                lsNCC = BUS.NhaCungCap_BUS.SelectNhaCungCap_fromNH(_MaNH);

                for (int i = 0; i < lsNCC.Count; i++)
                {
                    DataRow row = dtNCC.NewRow();
                    row["STT"] = i + 1;
                    row["TenNCC"] = lsNCC[i].TenNCC;
                    row["sdt"] = lsNCC[i].sdt;
                    row["DiemUuTien"] = lsNCC[i].DiemUuTien;
                    dtNCC.Rows.Add(row);
                }
                gridNCC.DataSource = dtNCC;
            }
            public void LoadDanhSachNL(int MaNCC)
            {
                lvNguyenLieu.Items.Clear();
                lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_fromNCC(MaNCC, _MaNH);
                for (int i = 0; i < lsNguyenLieu.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), lsNguyenLieu[i].TenNL, lsNguyenLieu[i].Gia.ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
            }
        #endregion 

    }
}