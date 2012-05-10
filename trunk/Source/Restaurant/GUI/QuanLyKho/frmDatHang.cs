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
    public partial class frmDatHang : DevExpress.XtraEditors.XtraForm
    {
        String _MaNH;
        int _MaNCC;
        List<NguyenLieu_DTO> lsNguyenLieu;
        List<NguyenLieu_DTO> lsDSDatHang;
        DataTable dtDSDatHang;
        int index_NL;


        #region " Properties "
            public String MaNH
            {
                get { return _MaNH; }
                set { _MaNH = value; }
            }
            public int MaNCC
            {
                get { return _MaNCC; }
                set { _MaNCC = value; }
            }
            public String TenNCC
            {
                get { return txtNCC.Text; }
                set { txtNCC.Text = value; }
            }
        #endregion

        #region "Khoi Tao "
            public frmDatHang()
            {
                InitializeComponent();

                lsNguyenLieu = new List<NguyenLieu_DTO>();
                lsDSDatHang = new List<NguyenLieu_DTO>();

                dtDSDatHang = new DataTable();
                dtDSDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtDSDatHang.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtDSDatHang.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtDSDatHang.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
                gridDSDatHang.DataSource = dtDSDatHang;
            }
        #endregion

        #region "Event Control "
        private void lvNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    index_NL = lvNguyenLieu.SelectedIndices[0];
                    txtNguyenLieu.Text = lsNguyenLieu[index_NL].TenNL;
                    txtSoLuong.Text = "0";
                    lbDonVi.Text = lsNguyenLieu[index_NL].DonVi;
                }
                catch (Exception)
                {
                }
            }
            private void gvDSDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {

            }
            private void btnThem_Click(object sender, EventArgs e)
            {
                if(lsNguyenLieu.Count>0)
                    ThemNguyenLieu();
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                XoaNguyenLieu();
            }
            private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
            {
                CapNhatSoLuong();
            }
            private void btnDongY_Click(object sender, EventArgs e)
            {
                DongY();
            }
            private void btnHuy_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion
        #region " Cac ham xu ly "
            public void LoadNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_fromNCC(MaNCC, _MaNH);
                Load_lvNguyenLieu();
            }
            public void Load_lvNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                for (int i = 0; i < lsNguyenLieu.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), lsNguyenLieu[i].TenNL, lsNguyenLieu[i].Gia.ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
                if (lvNguyenLieu.Items.Count > 0)
                    lvNguyenLieu.Items[0].Selected = true;
            }
            public void ThemNguyenLieu()
            {
                try
                {
                    int index_NguyenLieu = lvNguyenLieu.SelectedIndices[0];
                    //Add Grid DSDatHang
                    DataRow row = dtDSDatHang.NewRow();
                    row["STT"] = dtDSDatHang.Rows.Count + 1;
                    row["TenNL"] = lsNguyenLieu[index_NguyenLieu].TenNL;
                    row["SoLuong"] = int.Parse(txtSoLuong.Text);
                    row["ThanhTien"] = lsNguyenLieu[index_NguyenLieu].Gia * int.Parse(txtSoLuong.Text);
                    dtDSDatHang.Rows.Add(row);
                    lsDSDatHang.Add(lsNguyenLieu[index_NguyenLieu]);
                    //Delete List View Nguyen Lieu
                    lsNguyenLieu.RemoveAt(index_NguyenLieu);
                    Load_lvNguyenLieu();
                }
                catch (Exception)
                {
                }
            }
            public void XoaNguyenLieu()
            {
                int index_NguyenLieuChon = gvDSDatHang.GetSelectedRows()[0];
                //Add List View Nguyen Lieu
                ListViewItem lvItem = new ListViewItem(new String[] { (lsNguyenLieu.Count + 1).ToString(), lsDSDatHang[index_NguyenLieuChon].TenNL });
                lvNguyenLieu.Items.Add(lvItem);
                lsNguyenLieu.Add(lsDSDatHang[index_NguyenLieuChon]);
                //Remove grid DSDatHang
                lsDSDatHang.RemoveAt(index_NguyenLieuChon);
                dtDSDatHang.Rows.RemoveAt(index_NguyenLieuChon);
            }
            public void CapNhatSoLuong()
            {
            }
            public void DongY()
            {
            }

        #endregion

    }
}