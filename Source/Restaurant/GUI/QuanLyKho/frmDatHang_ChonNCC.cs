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
        public frmDatHang_ChonNCC()
        {
            InitializeComponent();

            lsNCC = new List<NhaCungCap_DTO>();
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
        private void lvNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                index_NCC = lvNCC.SelectedIndices[0];
                LoadDanhSachNL(lsNCC[index_NCC].MaNCC);
            }
            catch (Exception)
            {
            }
           
        }
        #region " Cac ham xu ly "
            public void LoadDanhSachNCC()
            {
                lvNCC.Items.Clear();
                lsNCC = BUS.NhaCungCap_BUS.SelectNhaCungCap_fromNH(_MaNH);
                for (int i = 0; i < lsNCC.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), lsNCC[i].TenNCC, lsNCC[i].DiemUuTien.ToString() });
                    lvNCC.Items.Add(item);                       
                }
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