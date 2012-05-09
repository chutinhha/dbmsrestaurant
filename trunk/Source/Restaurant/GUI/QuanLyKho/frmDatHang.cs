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
        int index_NL;
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
        #region "Khoi Tao " 
            public frmDatHang()
        {
            InitializeComponent();

            lsNguyenLieu = new List<NguyenLieu_DTO>();
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

            private void btnThem_Click(object sender, EventArgs e)
            {

            }

            private void btnXoa_Click(object sender, EventArgs e)
            {

            }
            private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
            {

            }
            private void btnKetThucDatHang_Click(object sender, EventArgs e)
            {

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
                for (int i = 0; i < lsNguyenLieu.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), lsNguyenLieu[i].TenNL, lsNguyenLieu[i].Gia.ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
            }
        #endregion
    }
}