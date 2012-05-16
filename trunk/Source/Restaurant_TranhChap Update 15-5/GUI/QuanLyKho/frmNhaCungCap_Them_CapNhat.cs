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
            private VNhaCungCap_DTO _NCC;
            private List<VNguyenLieu_DTO> lsNguyenLieu;
            private List<VNguyenLieu_DTO> _lsNguyenLieuChon;
            BUS.VNguyenLieu_BUS _NguyenLieuBUS;
            BUS.VNhaCungCap_BUS _NhaCungCapBUS;
            BUS.VChiTietNCC_BUS _ChiTietNCCBUS;
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
            public VNhaCungCap_DTO NCC
            {
                get { return _NCC; }
                set { _NCC = value; }
            }
            public List<VNguyenLieu_DTO>  lsNguyenLieuChon
            {
                get { return _lsNguyenLieuChon; }
                set { _lsNguyenLieuChon = value; }
            }
        #endregion

        #region " Khoi Tao "
            public frmNhaCungCap_Them_CapNhat()
        {
            InitializeComponent();
            _NCC = new VNhaCungCap_DTO();
            _NguyenLieuBUS = new VNguyenLieu_BUS();
            _NhaCungCapBUS = new VNhaCungCap_BUS();
            _ChiTietNCCBUS = new VChiTietNCC_BUS();
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
        #endregion

        #region "Cac ham xu ly"
            public void LoadNguyenLieu(int flag)
            {
                if (flag == 1) // Them du lieu moi
                    lsNguyenLieu = _NguyenLieuBUS.SelectNguyenLieu(_MaNH);
                else //Cap nhat du lieu
                {
                    lsNguyenLieu = _NguyenLieuBUS.SelectNguyenLieu_NotIn_ChiTietNCC(_NCC.MaNCC, _MaNH);
 
                }

                Load_lvNguyenLieu();
            }
            public void LoadNguyenLieuChon()
            {
                
                lsNguyenLieuChon = _NguyenLieuBUS.SelectNguyenLieu_fromNCC(_NCC.MaNCC, _MaNH);
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
                    //Neu la cap nhat nha cung cap - thi moi lan them nguyen lieu phai ghi xuong databse
                    if (_flag != 1)
                    {
                        if (_ChiTietNCCBUS.InsertChiTietNCC(lsNguyenLieu[index_NguyenLieu].MaNL, _NCC.MaNCC, lsNguyenLieu[index_NguyenLieu].Gia) == 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Không thể thêm nguyên liệu này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                     }
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
                    if (_flag != 1)
                    {
                        if (_ChiTietNCCBUS.DeleteChiTietNCC(lsNguyenLieuChon[index_NguyenLieuChon].MaNL, _NCC.MaNCC) == 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa nguyên liệu này!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

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
                           // Them du lieu 
                            if (_flag == 1)
                            {
                                _NCC.MaNCC = _NhaCungCapBUS.InsertNhaCungCap(-1,-1,_NCC);
                                if (_NCC.MaNCC == 0)                                    
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu Không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                {
                                    int flag_insertCtncc = 1;
                                    for (int i = 0; i < lsNguyenLieuChon.Count; i++)
                                    {
                                        if (i < lsNguyenLieuChon.Count - 1)
                                        {
                                            if (_ChiTietNCCBUS.InsertChiTietNCC(lsNguyenLieuChon[i].MaNL, _NCC.MaNCC, 0) == 0)
                                            {
                                                flag_insertCtncc = 0;
                                                break;
                                            }
                                        }else
                                            //Neu la Chi tiet nguyen lieu cuoi thi insert va commit tran sau do Close Connection
                                            if (_ChiTietNCCBUS.InsertChiTietNCC( lsNguyenLieuChon[i].MaNL, _NCC.MaNCC, 0) == 0)
                                            {
                                                flag_insertCtncc = 0;
                                                break;
                                            }

                                    }
                                    if(flag_insertCtncc ==1)
                                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm dử liệu  thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else // Cap nhat du lieu
                            {
                                _NCC.DiemUuTien = int.Parse(txtDiemUuTien.Text);
                                if (_NhaCungCapBUS.UpdatetNhaCungCap(TenNCC_old,_NCC) == 0)
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật dử liệu Không thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật dử liệu  thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                        }  
            }
        #endregion
    }
}