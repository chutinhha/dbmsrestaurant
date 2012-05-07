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
        private int _flag;   //flag = 1 :Them , flag =2 : Cap nhat
        private String _MaNH;
        private int _MaNCC;
        private NhaCungCap_DTO _NCC;
        private List<NguyenLieu_DTO> lsNguyenLieu;
        private List<NguyenLieu_DTO> _lsNguyenLieuChon;
        
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
            public int MaNCC
            {
                get { return _MaNCC; }
                set { _MaNCC = value; }
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
            public String TenNCC
            {
                get { return txtTenNCC.Text; }
                set { txtTenNCC.Text = value; }
            }
            public String DiaChi
            {
                get { return txtDiaChi.Text; }
                set { txtDiaChi.Text = value; }
            }
            public String SDT
            {
                get { return txtSoDienThoai.Text; }
                set { txtSoDienThoai.Text = value; }
            }
            public String DiemUuTien
            {
                get { return txtDiemUuTien.Text; }
                set { txtDiemUuTien.Text = value; }
            }
        #endregion

        public frmNhaCungCap_Them_CapNhat()
        {
            InitializeComponent();
            _NCC = new NhaCungCap_DTO();
        }

        #region " Control Event "
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
                ThemNCC();
            }
        #endregion

        #region "Cac ham xu ly"
            public void LoadNguyenLieu(int flag)
            {
                if (flag == 1)
                    lsNguyenLieu =BUS.NguyenLieu_BUS.SelectNguyenLieu(_MaNH);
                else
                    lsNguyenLieu = BUS.NguyenLieu_BUS.SelectNguyenLieu_Free(_MaNCC,_MaNH);

                Load_lvNguyenLieu();
            }
            public void LoadNguyenLieuChon()
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
                    LoadNguyenLieuChon();
                }
                catch (Exception)
                {
                }
            }
            public void ThemNCC()
            {
                this.DialogResult = DialogResult.None;
                if (txtTenNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập Tên Nhà Cung Cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNCC.Focus();
                }
                else
                    if (txtDiaChi.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập Địa Chỉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDiaChi.Focus();
                    }
                    else
                        if (txtSoDienThoai.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập Số Điện Thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSoDienThoai.Focus();
                        }
                        else
                        {
                            _NCC.TenNCC = txtTenNCC.Text.Trim();
                            _NCC.DiaChi = txtDiaChi.Text.Trim();
                            _NCC.sdt = txtSoDienThoai.Text.Trim();
                            int iMaNCC = BUS.NhaCungCap_BUS.InsertNhaCungCap(_NCC);
                            if (iMaNCC == 0)
                            {
                                MessageBox.Show("Tên nhà cung cấp này đã có trong danh sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtTenNCC.Focus();
                                this.DialogResult = DialogResult.None;
                            }
                            else
                            {
                                for (int i = 0; i < lsNguyenLieuChon.Count; i++)
                                {
                                    BUS.ChiTietNCC_BUS.InsertChiTietNCC(lsNguyenLieuChon[i].MaNL,iMaNCC);
                                }
                                this.DialogResult = DialogResult.OK;
                            }
                        }  
            }
        #endregion
    }
}