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
    public partial class frmNhaCungCap_Them_CapNhat : DevExpress.XtraEditors.XtraForm
    {
        #region " Thuoc Tinh & properties "
            private int _flag;   //flag = 1 :Them , flag =2 : Cap nhat
            private String _MaNH;
            private String TenNCC_old;
            private NhaCungCap_DTO _NCC;
            private List<NguyenLieu_DTO> lsNguyenLieu;
            private List<NguyenLieu_DTO> _lsNguyenLieuChon;
            BUS.NguyenLieu_BUS _NguyenLieuBUS;
        #endregion

        #region " Properties "
        public int Flag
            {
                get { return _flag; }
                set { _flag = value; }
            }
            public String MaNH
            {
                get { return _MaNH; }
                set { _MaNH = value; }
            }
            public NhaCungCap_DTO NCC
            {
                get { return _NCC; }
                set { _NCC = value; }
            }
            public List<NguyenLieu_DTO>  lsNguyenLieuChon
            {
                get { return _lsNguyenLieuChon; }
                set { _lsNguyenLieuChon = value; }
            }
        #endregion

        #region " Khoi Tao "
            public frmNhaCungCap_Them_CapNhat()
        {
            InitializeComponent();
            _NCC = new NhaCungCap_DTO();
            _NguyenLieuBUS = new NguyenLieu_BUS();
        }
        #endregion

        #region " Control Event "
            private void frmNhaCungCap_Them_CapNhat_Load(object sender, EventArgs e)
            {
                if (_flag == 1)
                {
                    txtDiemUuTien.Text = "0";
                    txtDiemUuTien.Enabled = false;
                }
                else
                    txtDiemUuTien.Text = _NCC.DiemUuTien.ToString();
                TenNCC_old = _NCC.TenNCC;
                txtTenNCC.Text = _NCC.TenNCC;
                txtDiaChi.Text = _NCC.DiaChi;
                txtSoDienThoai.Text = _NCC.sdt;
            }
            private void btnThemNL_Click(object sender, EventArgs e)
            {
                ThemNL();
            }

            private void btnXoaNL_Click(object sender, EventArgs e)
            {
                XoaNL();
            }

            private void btnDongY_Click(object sender, EventArgs e)
            {
                Save();
            }

            private void txtDiemUuTien_TextChanged(object sender, EventArgs e)
            {
                if (txtDiemUuTien.Text.Trim().Length == 0)
                    txtDiemUuTien.Text = "0";
            }
        #endregion

        #region "Cac ham xu ly"
            public void LoadNguyenLieu(int flag)
            {
                if (flag == 1)
                    lsNguyenLieu = _NguyenLieuBUS.SelectNguyenLieu(2,-1,_MaNH);
                else
                    lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_NotIn_ChiTietNCC(_NCC.MaNCC,_MaNH);

                Load_lvNguyenLieu();
            }
            public void LoadNguyenLieuChon()
            {
                lsNguyenLieuChon = _NguyenLieuBUS.SelectNguyenLieu_fromNCC(2,-1,_NCC.MaNCC, _MaNH);
                Load_lvNguyenLieuChon();
            }
            public void Load_lvNguyenLieuChon()
            {
                lvNguyenLieuChon.Items.Clear();
                for (int i = 0; i < lsNguyenLieuChon.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(new String[] { (i + 1).ToString(), lsNguyenLieuChon[i].TenNL });
                    lvNguyenLieuChon.Items.Add(lvItem);
                }
            }
            public void Load_lvNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                for (int i = 0; i < lsNguyenLieu.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(new String[] { (i + 1).ToString(), lsNguyenLieu[i].TenNL });
                    lvNguyenLieu.Items.Add(lvItem);
                }
            }
            public void ThemNL()
            {
                try
                {
                    int index_NguyenLieu = lvNguyenLieu.SelectedIndices[0];
                    //Add List View Nguyen Lieu Chon
                    ListViewItem lvItem = new ListViewItem(new String[] { (lsNguyenLieuChon.Count + 1).ToString(), lsNguyenLieu[index_NguyenLieu].TenNL });
                    lvNguyenLieuChon.Items.Add(lvItem);
                    lsNguyenLieuChon.Add(lsNguyenLieu[index_NguyenLieu]);
                    //Delete List View Nguyen Lieu
                    lsNguyenLieu.RemoveAt(index_NguyenLieu);
                    Load_lvNguyenLieu();
                }
                catch (Exception)
                {   
                }
            }
            public void XoaNL()
            {
                try
                {
                    int index_NguyenLieuChon = lvNguyenLieuChon.SelectedIndices[0];
                    //Add List View Nguyen Lieu
                    ListViewItem lvItem = new ListViewItem(new String[] { (lsNguyenLieu.Count + 1).ToString(), lsNguyenLieuChon[index_NguyenLieuChon].TenNL });
                    lvNguyenLieu.Items.Add(lvItem);
                    lsNguyenLieu.Add(lsNguyenLieuChon[index_NguyenLieuChon]);
                    //Remove List View Nguyen Lieu Chon
                    lsNguyenLieuChon.RemoveAt(index_NguyenLieuChon);
                    Load_lvNguyenLieuChon();
                }
                catch (Exception)
                {
                }
            }
            public void Save()
            {
                this.DialogResult = DialogResult.None;
                if (txtTenNCC.Text.Trim().Length == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên Nhà Cung Cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenNCC.Focus();
                }
                else
                    if (txtDiaChi.Text.Trim().Length == 0)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Địa Chỉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDiaChi.Focus();
                    }
                    else
                        if (txtSoDienThoai.Text.Trim().Length == 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Số Điện Thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            _NCC.TenNCC = txtTenNCC.Text.Trim();
                            _NCC.DiaChi = txtDiaChi.Text.Trim();
                            _NCC.sdt = txtSoDienThoai.Text.Trim();
                            if (_flag == 1)
                            {
                                _NCC.MaNCC = BUS.NhaCungCap_BUS.InsertNhaCungCap(_NCC);
                                if (_NCC.MaNCC == 0)
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Tên nhà cung cấp này đã có trong danh sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtTenNCC.Focus();
                                    this.DialogResult = DialogResult.None;
                                }
                                else
                                {
                                    for (int i = 0; i < lsNguyenLieuChon.Count; i++)
                                    {
                                        BUS.ChiTietNCC_BUS.InsertChiTietNCC(lsNguyenLieuChon[i].MaNL, _NCC.MaNCC,0);
                                    }
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                            else
                            {
                                _NCC.DiemUuTien = int.Parse(txtDiemUuTien.Text);
                                int flag = BUS.NhaCungCap_BUS.UpdatetNhaCungCap(TenNCC_old,_NCC);
                                if (flag == 0)
                                {
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Tên nhà cung cấp này đã có trong danh sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtTenNCC.Focus();
                                    this.DialogResult = DialogResult.None;
                                }
                                else
                                {
                                    BUS.ChiTietNCC_BUS.DeleteChiTietNCC(_NCC.MaNCC);
                                    for (int i = 0; i < lsNguyenLieuChon.Count; i++)
                                    {
                                        BUS.ChiTietNCC_BUS.InsertChiTietNCC(lsNguyenLieuChon[i].MaNL, _NCC.MaNCC, lsNguyenLieuChon[i].Gia);
                                    }
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }  
            }
        #endregion

            private void lvNguyenLieu_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    ThemNL();
                }
                catch (Exception)
                {
                    
                }
               
            }

            private void lvNguyenLieuChon_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    XoaNL();
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }


    }
}