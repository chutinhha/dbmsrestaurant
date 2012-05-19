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
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
            BUS.VNhaCungCap_BUS busNhaCungCap;
            BUS.VNguyenLieu_BUS busNguyenLieu;
            DataTable dtNguyenLieu_Source;
            DataTable dtChiTietDatHang_Source;
            DataTable dtChiTietDatHang;

            int index_NL;
            int index_DSDatHang;
            int sttDSDatHang;
            VDatHang_DTO ttdh;
            int soluong_temp;
        #endregion 

        #region " Properties "
            public VNhaCungCap_BUS NhaCungCapBUS
            {
                get { return busNhaCungCap; }
                set { busNhaCungCap = value; }
            }
            public VNguyenLieu_BUS NguyenLieuBUS
            {
                get { return busNguyenLieu; }
                set { busNguyenLieu = value; }
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
                get { return ttdh; }
                set { ttdh = value; }
            }
            public DataTable DtNguyenLieu
            {
                get { return dtNguyenLieu_Source; }
                set { dtNguyenLieu_Source = value; }
            }
            public DataTable DtChiTietDatHang
            {
                get { return dtChiTietDatHang; }
                set { dtChiTietDatHang = value; }
            }

        #endregion

        #region "Khoi Tao "
            public frmDatHang()
            {
                InitializeComponent();
                busNhaCungCap = new VNhaCungCap_BUS();
                busNguyenLieu = new VNguyenLieu_BUS();
                ttdh = new VDatHang_DTO();
                dtNguyenLieu_Source = new DataTable();
                dtChiTietDatHang_Source = new DataTable();
                dtChiTietDatHang_Source.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtChiTietDatHang_Source.Columns.Add("MaHoaDon", System.Type.GetType("System.Int16"));
                dtChiTietDatHang_Source.Columns.Add("MaNL", System.Type.GetType("System.Int16"));
                dtChiTietDatHang_Source.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtChiTietDatHang_Source.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
                dtChiTietDatHang_Source.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtChiTietDatHang_Source.Columns.Add("DonVi", System.Type.GetType("System.String"));

                dtChiTietDatHang = new DataTable();
                dtChiTietDatHang.Columns.Add("MaHoaDon", System.Type.GetType("System.Int16"));
                dtChiTietDatHang.Columns.Add("MaNL", System.Type.GetType("System.Int32"));
                dtChiTietDatHang.Columns.Add("SoLuong", System.Type.GetType("System.Int16"));
                dtChiTietDatHang.Columns.Add("ThanhTien", System.Type.GetType("System.Double"));
                gridDSDatHang.DataSource = dtChiTietDatHang;

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
                    txtNguyenLieu.Text = dtNguyenLieu_Source.Rows[index_NL]["TenNL"].ToString();
                    txtSoLuong.Text = "1";
                    lbDonVi.Text = dtNguyenLieu_Source.Rows[index_NL]["DonVi"].ToString();
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
                        sttDSDatHang = int.Parse(gvDSDatHang.GetDataRow(index_DSDatHang)["STT"].ToString());

                        txtNguyenLieu.Text = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["TenNL"].ToString();
                        txtSoLuong.Text = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["SoLuong"].ToString();
                        lbDonVi.Text = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["DonVi"].ToString(); ;
                        soluong_temp = (int)dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["SoLuong"];
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
                    //txtNguyenLieu.Text = dtChiTietDatHang_Source[index_DSDatHang].TenNL;
                    //txtSoLuong.Text = dtChiTietDatHang_Source[index_DSDatHang].SoLuong.ToString();
                    //lbDonVi.Text = dtChiTietDatHang_Source[index_DSDatHang].DonVi;
                }
            }
            private void btnThem_Click(object sender, EventArgs e)
            {
                if (dtNguyenLieu_Source.Rows.Count > 0)
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
            private void lvNguyenLieu_DoubleClick(object sender, EventArgs e)
            {
                ThemNguyenLieu();
            }

            private void gridDSDatHang_DoubleClick(object sender, EventArgs e)
            {
                XoaNguyenLieu();
            }
        #endregion

        #region " Cac ham xu ly "
            public void LoadDuLieu(int flag)
            {
                if (flag == 1)
                    dtNguyenLieu_Source = busNguyenLieu.SelectNguyenLieu_In_NCC(ttdh.MaNCC, ttdh.MaNH);
                else
                {
                    DataSet dtset = busNguyenLieu.SelectNguyenLieu_DatHang(ttdh.MaHoaDon,ttdh.MaNCC,ttdh.MaNH);
                    dtNguyenLieu_Source = dtset.Tables[0];
                    dtChiTietDatHang_Source = dtset.Tables[1];
                    dtChiTietDatHang_Source.Columns.Add("STT", System.Type.GetType("System.Int16"));
                    Load_gridDSDatHang();
                }
                Load_lvNguyenLieu();
            }
            public void Load_lvNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                for (int i = 0; i < dtNguyenLieu_Source.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(new String[] { (i + 1).ToString(), dtNguyenLieu_Source.Rows[i]["TenNL"].ToString(), dtNguyenLieu_Source.Rows[i]["Gia"].ToString() });
                    lvNguyenLieu.Items.Add(item);
                }
                if (lvNguyenLieu.Items.Count > 0)
                    lvNguyenLieu.Items[0].Selected = true;
            }
            public void Load_gridDSDatHang()
            {
                gridDSDatHang.DataSource = null;
                dtChiTietDatHang.Rows.Clear();
                for (int i = 0; i < dtChiTietDatHang_Source.Rows.Count; i++)
                {
                    DataRow row = dtChiTietDatHang.NewRow();
                    row["MaHoaDon"] = ttdh.MaHoaDon;
                    row["MaNL"] = dtChiTietDatHang_Source.Rows[i]["MaNL"];
                    row["SoLuong"] = dtChiTietDatHang_Source.Rows[i]["SoLuong"];
                    row["ThanhTien"] = dtChiTietDatHang_Source.Rows[i]["ThanhTien"];
                    dtChiTietDatHang.Rows.Add(row);

                    dtChiTietDatHang_Source.Rows[i]["STT"] = (i+1);
                }
                gridDSDatHang.DataSource = dtChiTietDatHang_Source;
            }
            public void LoadThongTinDatHang()
            {
                txtTongTien.Text = ttdh.TongTien.ToString();
                txtNCC.Text = ttdh.TenNCC;
                dateThoiGianGiao.DateTime = ttdh.ThoiGianGiao;
            }
            public void ThemNguyenLieu()
            {
                try
                {
                    if (int.Parse(txtSoLuong.Text) == 0)
                    {
                        MessageBox.Show("Số lượng nguyên liệu phải lớn hơn 0", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Add Grid DSDatHang

                        DataRow row = dtChiTietDatHang_Source.NewRow();
                        row["TenNL"] = dtNguyenLieu_Source.Rows[index_NL]["TenNL"];
                        row["SoLuong"] = int.Parse(txtSoLuong.Text);
                        double ThanhTien = (double)dtNguyenLieu_Source.Rows[index_NL]["Gia"] * int.Parse(txtSoLuong.Text);
                        row["ThanhTien"] = ThanhTien;
                        row["MaNL"] = dtNguyenLieu_Source.Rows[index_NL]["MaNL"];
                        row["DonVi"] = dtNguyenLieu_Source.Rows[index_NL]["DonVi"];
                        dtChiTietDatHang_Source.Rows.Add(row);
                        Load_gridDSDatHang();

                        //Delete List View Nguyen Lieu
                        dtNguyenLieu_Source.Rows.RemoveAt(index_NL);
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
                TongTien -= (double)dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["ThanhTien"];
                txtTongTien.Text = TongTien.ToString();

                //Add List View Nguyen Lieu

                DataRow row = dtNguyenLieu_Source.NewRow();
                row["MaNL"] = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["MaNL"];
                row["TenNL"] = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["TenNL"];
                row["DonVi"] = dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["DonVi"];
                row["Gia"] = (double)(double.Parse(dtChiTietDatHang_Source.Rows[sttDSDatHang - 1]["ThanhTien"].ToString()) / int.Parse(dtChiTietDatHang_Source.Rows[sttDSDatHang - 1]["SoLuong"].ToString()));
                dtNguyenLieu_Source.Rows.Add(row);
                Load_lvNguyenLieu();

                //Remove grid DSDatHang
                dtChiTietDatHang_Source.Rows.RemoveAt(sttDSDatHang-1);
                dtChiTietDatHang.Rows.RemoveAt(sttDSDatHang-1);

            }
            public void CapNhatSoLuong()
            {
                if (int.Parse(txtSoLuong.Text) == 0)
                {
                    MessageBox.Show("Số lượng phảilớn hơn 0", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dtChiTietDatHang.Rows[sttDSDatHang-1]["SoLuong"] = int.Parse(txtSoLuong.Text);
                    dtChiTietDatHang.Rows[sttDSDatHang-1]["ThanhTien"] = ((double)dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["ThanhTien"] / soluong_temp) * int.Parse(txtSoLuong.Text);

                    dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["SoLuong"] = int.Parse(txtSoLuong.Text);
                    dtChiTietDatHang_Source.Rows[sttDSDatHang-1]["ThanhTien"] = (double)dtNguyenLieu_Source.Rows[sttDSDatHang-1]["Gia"] * int.Parse(txtSoLuong.Text);
                }
            }
            public void DongY()
            {
                if (dtChiTietDatHang.Rows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn nguyên liệu để đặt hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    ttdh.ThoiGianGiao = dateThoiGianGiao.DateTime;
                    ThongTinDH.TinhTrang = "Chưa Giao";
                    ThongTinDH.ThoiGianDat = DateTime.Now;
                    ttdh.TongTien = Double.Parse(txtTongTien.Text);
                }
            }

        #endregion


    }
}