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
        #region " Thuoc Tinh " 
            BUS.VNhaCungCap_BUS _NhaCungCapBUS;
            BUS.VNguyenLieu_BUS _NguyenLieuBUS;
            List<VNguyenLieu_DTO> _lsNguyenLieu;
            List<VChiTietDatHang_DTO> _lsDSDatHang;
            DataTable dtDSDatHang;
            int index_NL;
            int index_DSDatHang;

            VDatHang_DTO _ttdh;
            int _soluong_temp;
        #endregion 

        #region " Properties "
            public VNhaCungCap_BUS NhaCungCapBUS
            {
                get { return _NhaCungCapBUS; }
                set { _NhaCungCapBUS = value; }
            }
            public VNguyenLieu_BUS NguyenLieuBUS
            {
                get { return _NguyenLieuBUS; }
                set { _NguyenLieuBUS = value; }
            }

            public String TenNCC
            {
                get { return txtNCC.Text; }
                set { txtNCC.Text = value; }
            }
            public DateTime ThoiGianGiao
            {
                get { return dateThoiGianGiao.DateTime; }
                set { dateThoiGianGiao.DateTime = value; }
            }
            public String TongTien
            {
                get { return txtTongTien.Text; }
                set { txtTongTien.Text = value; }
            }
            public VDatHang_DTO ThongTinDH
            {
                get { return _ttdh; }
                set { _ttdh = value; }
            }
            public List<VNguyenLieu_DTO> lsNguyenLieu
            {
                get { return _lsNguyenLieu; }
                set { _lsNguyenLieu = value; }
            }
            public List<VChiTietDatHang_DTO> lsDSDatHang
            {
                get { return _lsDSDatHang; }
                set { _lsDSDatHang = value; }
            }

        #endregion

        #region "Khoi Tao "
            public frmDatHang()
            {
                InitializeComponent();
                _NhaCungCapBUS = new VNhaCungCap_BUS();
                _NguyenLieuBUS = new VNguyenLieu_BUS();
                _ttdh = new VDatHang_DTO();
                _lsNguyenLieu = new List<VNguyenLieu_DTO>();
                _lsDSDatHang = new List<VChiTietDatHang_DTO>();

                dtDSDatHang = new DataTable();
                dtDSDatHang.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtDSDatHang.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtDSDatHang.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtDSDatHang.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
                gridDSDatHang.DataSource = dtDSDatHang;

                txtTongTien.Text = "0";
                dateThoiGianGiao.DateTime = DateTime.Now;
            }
        #endregion

        #region "Event Control "
        private void lvNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
            {
                try
                {
                    index_NL = lvNguyenLieu.SelectedIndices[0];
                    txtNguyenLieu.Text = _lsNguyenLieu[index_NL].TenNL;
                    txtSoLuong.Text = "1";
                    lbDonVi.Text = _lsNguyenLieu[index_NL].DonVi;
                    if (lvNguyenLieu.Focused)
                    {
                        btnThem.Enabled = true;
                        btnXoa.Enabled = false;
                        btnCapNhatSoLuong.Enabled = false;
                    }
                }
                catch (Exception)
                {
                }
            }
            private void gvDSDatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                if (gvDSDatHang.GetSelectedRows().Length > 0)
                {
                    try
                    {
                        index_DSDatHang = gvDSDatHang.GetSelectedRows()[0];
                        txtNguyenLieu.Text = _lsDSDatHang[index_DSDatHang].TenNL;
                        txtSoLuong.Text = _lsDSDatHang[index_DSDatHang].SoLuong.ToString();
                        lbDonVi.Text = _lsDSDatHang[index_DSDatHang].DonVi;
                        _soluong_temp = _lsDSDatHang[index_DSDatHang].SoLuong;
                    }
                    catch (Exception)
                    {
                    }
        
                }
            }

            private void gvDSDatHang_Click(object sender, EventArgs e)
            {
                if (gvDSDatHang.GetSelectedRows().Length > 0)
                {
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                    btnCapNhatSoLuong.Enabled = true;

                    index_DSDatHang = gvDSDatHang.GetSelectedRows()[0];
                    txtNguyenLieu.Text = _lsDSDatHang[index_DSDatHang].TenNL;
                    txtSoLuong.Text = _lsDSDatHang[index_DSDatHang].SoLuong.ToString();
                    lbDonVi.Text = _lsDSDatHang[index_DSDatHang].DonVi;
                }
            }
            private void btnThem_Click(object sender, EventArgs e)
            {
                if(_lsNguyenLieu.Count>0)
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
                //this.Close();
            }

            private void lvNguyenLieu_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    ThemNguyenLieu();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void gridDSDatHang_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    XoaNguyenLieu();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        #endregion

        #region " Cac ham xu ly "
            public void LoadNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
               // _lsNguyenLieu = _NguyenLieuBUS.SelectNguyenLieu_fromNCC(_ttdh.MaNCC,_ttdh.MaNH);
                Load_lvNguyenLieu();
            }
            public void Load_lvNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                for (int i = 0; i < _lsNguyenLieu.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), _lsNguyenLieu[i].TenNL, _lsNguyenLieu[i].Gia.ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
                if (lvNguyenLieu.Items.Count > 0)
                    lvNguyenLieu.Items[0].Selected = true;
            }
            public void Load_gridDSDatHang()
            {
                gridDSDatHang.DataSource = null;
                dtDSDatHang.Rows.Clear();
                for (int i = 0; i < _lsDSDatHang.Count; i++)
                {
                    DataRow row = dtDSDatHang.NewRow();
                    row["STT"] = dtDSDatHang.Rows.Count + 1;
                    row["TenNL"] = _lsDSDatHang[i].TenNL;
                    row["SoLuong"] = _lsDSDatHang[i].SoLuong;
                    row["ThanhTien"] = _lsDSDatHang[i].ThanhTien;
                    dtDSDatHang.Rows.Add(row);
                }
                gridDSDatHang.DataSource = dtDSDatHang;
            }
            public void LoadThongTinDatHang()
            {
                txtTongTien.Text = _ttdh.TongTien.ToString();
                txtNCC.Text = _ttdh.TenNCC;
                dateThoiGianGiao.DateTime = _ttdh.ThoiGianGiao;
            }
            public void ThemNguyenLieu()
            {
                try
                {
                    if (int.Parse(txtSoLuong.Text) == 0)
                    {
                        MessageBox.Show("Số lượng phải khác 0", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Add Grid DSDatHang

                        VChiTietDatHang_DTO temp = new VChiTietDatHang_DTO();
                        temp.MaNL = _lsNguyenLieu[index_NL].MaNL;
                        temp.ThanhTien = _lsNguyenLieu[index_NL].Gia;
                        temp.DonVi = _lsNguyenLieu[index_NL].DonVi;
                        temp.TenNL = _lsNguyenLieu[index_NL].TenNL;
                        temp.SoLuong = int.Parse(txtSoLuong.Text);
                        _lsDSDatHang.Add(temp);

                        DataRow row = dtDSDatHang.NewRow();
                        row["STT"] = dtDSDatHang.Rows.Count + 1;
                        row["TenNL"] = _lsNguyenLieu[index_NL].TenNL;
                        row["SoLuong"] = int.Parse(txtSoLuong.Text);
                        Double ThanhTien = _lsNguyenLieu[index_NL].Gia * int.Parse(txtSoLuong.Text);
                        row["ThanhTien"] = ThanhTien;
                        dtDSDatHang.Rows.Add(row);

                        //Delete List View Nguyen Lieu
                        _lsNguyenLieu.RemoveAt(index_NL);
                        Load_lvNguyenLieu();

                        //Cap Nhat Tong Tien
                        Double TongTien = Double.Parse(txtTongTien.Text);
                        TongTien += ThanhTien;
                        txtTongTien.Text = TongTien.ToString();
                    }
                }
                catch (Exception)
                {
                }
            }
            public void XoaNguyenLieu()
            {

                //Cap nhat tong tien 
                Double TongTien = Double.Parse(txtTongTien.Text);
                TongTien -= _lsDSDatHang[index_DSDatHang].ThanhTien;
                txtTongTien.Text = TongTien.ToString();

                //Add List View Nguyen Lieu

                VNguyenLieu_DTO temp = new VNguyenLieu_DTO();
                temp.MaNL = _lsDSDatHang[index_DSDatHang].MaNL;
                temp.TenNL = _lsDSDatHang[index_DSDatHang].TenNL;
                temp.DonVi = _lsDSDatHang[index_DSDatHang].DonVi;
                temp.Gia = _lsDSDatHang[index_DSDatHang].ThanhTien;
                _lsNguyenLieu.Add(temp);
                Load_lvNguyenLieu();

                //Remove grid DSDatHang
                _lsDSDatHang.RemoveAt(index_DSDatHang);
                dtDSDatHang.Rows.RemoveAt(index_DSDatHang);

            }
            public void CapNhatSoLuong()
            {
                if (int.Parse(txtSoLuong.Text) == 0)
                {
                    MessageBox.Show("Số lượng phải khác 0", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dtDSDatHang.Rows[index_DSDatHang]["SoLuong"] = int.Parse(txtSoLuong.Text);
                    dtDSDatHang.Rows[index_DSDatHang]["ThanhTien"] = (_lsDSDatHang[index_NL].ThanhTien/_soluong_temp) * int.Parse(txtSoLuong.Text);
                    _lsDSDatHang[index_DSDatHang].SoLuong = int.Parse(txtSoLuong.Text);
                    _lsDSDatHang[index_DSDatHang].ThanhTien = _lsNguyenLieu[index_NL].Gia * int.Parse(txtSoLuong.Text);
                }
            }
            public void DongY()
            {
                if(lsDSDatHang.Count== 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn nguyên liệu để đặt hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
                }
                else{
                    _ttdh.ThoiGianGiao = dateThoiGianGiao.DateTime ;
                    ThongTinDH.TinhTrang = "Chưa Giao";
                    ThongTinDH.ThoiGianDat = DateTime.Now;
                    _ttdh.TongTien = Double.Parse(txtTongTien.Text);
                }

            }

        #endregion


    }
}