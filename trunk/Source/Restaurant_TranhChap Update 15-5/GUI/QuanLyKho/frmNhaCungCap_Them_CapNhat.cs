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
            private int flag;   //flag = 1 :Them , flag =2 : Cap nhat
            private String maNH;
            private VNhaCungCap_DTO dtoNCC;
            private DataTable dtNguyenLieu;
            private DataTable dtNguyenLieuChon;
            private DataTable dtChiTietNCC;

            VNguyenLieu_BUS busNguyenLieu;
            VNhaCungCap_BUS busNCC;
            VChiTietNCC_BUS busChiTietNCC;
            
        #endregion

        #region " Properties "
        public int Flag
            {
                get { return flag; }
                set { flag = value; }
            }
            public String MaNH
            {
                get { return maNH; }
                set { maNH = value; }
            }
            public VNhaCungCap_DTO DtoNCC
            {
                get { return dtoNCC; }
                set { dtoNCC = value; }
            }
            public DataTable DtNguyenLieu
            {
                get { return dtNguyenLieu; }
                set { dtNguyenLieu = value; }
            }
            public DataTable DtNguyenLieuChon
            {
                get { return dtNguyenLieuChon; }
                set { dtNguyenLieuChon = value; }
            }
            public DataTable DtChiTietNCC
            {
                get { return dtChiTietNCC; }
                set { dtChiTietNCC = value; }
            }
        #endregion

        #region " Khoi Tao "
            public frmNhaCungCap_Them_CapNhat()
            {
                InitializeComponent();
                flag =0;
                dtoNCC = new VNhaCungCap_DTO();
                busNguyenLieu = new VNguyenLieu_BUS();
                busNCC = new VNhaCungCap_BUS();
                busChiTietNCC = new VChiTietNCC_BUS();

                dtNguyenLieu = new DataTable();
                dtNguyenLieuChon = new DataTable();
                dtNguyenLieuChon.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtNguyenLieuChon.Columns.Add("MaNL", System.Type.GetType("System.Int32"));
                dtNguyenLieuChon.Columns.Add("Gia", System.Type.GetType("System.Double"));

                dtChiTietNCC = new DataTable();
                DtChiTietNCC.Columns.Add("MaNL", System.Type.GetType("System.Int32"));
                DtChiTietNCC.Columns.Add("MaNCC", System.Type.GetType("System.Int32"));
                DtChiTietNCC.Columns.Add("Gia", System.Type.GetType("System.Double"));
            }
        #endregion

        #region " Control Event "
            private void frmNhaCungCap_Them_CapNhat_Load(object sender, EventArgs e)
            {
               
                if (flag == 1)
                {
                    LoadNguyenLieu();
                    txtDiemUuTien.Text = "0";
                    txtDiemUuTien.Enabled = false;
                }
                else
                {
                    txtDiemUuTien.Text = dtoNCC.DiemUuTien.ToString();
                    LoadDuLieu();
                }
                txtTenNCC.Text = dtoNCC.TenNCC;
                txtDiaChi.Text = dtoNCC.DiaChi;
                txtSoDienThoai.Text = dtoNCC.sdt;
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
                ThemNL();
            }

            private void lvNguyenLieuChon_DoubleClick(object sender, EventArgs e)
            {
                XoaNL();
            }
        #endregion

        #region "Cac ham xu ly"
            
            public void LoadNguyenLieu()
            {
                dtNguyenLieu = busNguyenLieu.SelectNguyenLieu_NotIn_ChiTietNCC(dtoNCC.MaNCC, maNH);
                Load_lvNguyenLieu();
            }
            public void LoadNguyenLieuChon()
            {
                
                dtNguyenLieuChon = busNguyenLieu.SelectNguyenLieu_In_NCC(dtoNCC.MaNCC, maNH);
                Load_lvNguyenLieuChon();
            }
            public void Load_lvNguyenLieuChon()
            {
                lvNguyenLieuChon.Items.Clear();
                for (int i = 0; i < dtNguyenLieuChon.Rows.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(new String[] { (i + 1).ToString(), dtNguyenLieuChon.Rows[i]["TenNL"].ToString() });
                    lvNguyenLieuChon.Items.Add(lvItem);
                }
            }
            public void Load_lvNguyenLieu()
            {
                lvNguyenLieu.Items.Clear();
                for (int i = 0; i < dtNguyenLieu.Rows.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(new String[] { (i + 1).ToString(), dtNguyenLieu.Rows[i]["TenNL"].ToString() });
                    lvNguyenLieu.Items.Add(lvItem);
                }
            }
            public void LoadDuLieu()
            {
                DataSet temp = new DataSet();
                temp = busNguyenLieu.SelectNguyenLieu_NCC(dtoNCC.MaNCC, maNH);
                DtNguyenLieu = temp.Tables[0];
                dtNguyenLieuChon = temp.Tables[1];
                
                Load_lvNguyenLieuChon();
                Load_lvNguyenLieu();

            }
            public void ThemNL()
            {
                //try
                //{
                    int index_NguyenLieu = lvNguyenLieu.SelectedIndices[0];
                    //Add List View Nguyen Lieu Chon
                    DataRow row = dtNguyenLieuChon.NewRow();
                    row["TenNL"] = dtNguyenLieu.Rows[index_NguyenLieu]["TenNL"].ToString();
                    row["MaNL"] = (int)dtNguyenLieu.Rows[index_NguyenLieu]["MaNL"];
                    dtNguyenLieuChon.Rows.Add(row);
                    Load_lvNguyenLieuChon();
                    //Delete List View Nguyen Lieu
                    dtNguyenLieu.Rows.RemoveAt(index_NguyenLieu);
                    Load_lvNguyenLieu();
                    
            //    }
            //    catch (Exception)
            //    {   
            //    }
            }
            public void XoaNL()
            {
                try
                {
                    int index_NguyenLieuChon = lvNguyenLieuChon.SelectedIndices[0];

                    //Add List View Nguyen Lieu
                    DataRow row = dtNguyenLieu.NewRow();
                    row["TenNL"] = dtNguyenLieuChon.Rows[index_NguyenLieuChon]["TenNL"].ToString();
                    row["MaNL"] = (int)dtNguyenLieuChon.Rows[index_NguyenLieuChon]["MaNL"];
                    dtNguyenLieu.Rows.Add(row);
                    Load_lvNguyenLieu();
                    //Remove List View Nguyen Lieu Chon
                    dtNguyenLieuChon.Rows.RemoveAt(index_NguyenLieuChon);
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
                            dtoNCC.TenNCC = txtTenNCC.Text.Trim();
                            dtoNCC.DiaChi = txtDiaChi.Text.Trim();
                            dtoNCC.sdt = txtSoDienThoai.Text.Trim();
                            dtoNCC.DiemUuTien = int.Parse(txtDiemUuTien.Text);
                            for (int i = 0; i < dtNguyenLieuChon.Rows.Count; i++)
                            {
                                DataRow row = dtChiTietNCC.NewRow();
                                row["MaNCC"] = dtoNCC.MaNCC;
                                row["MaNL"] = dtNguyenLieuChon.Rows[i]["MaNL"].ToString();
                                row["Gia"] = 0;
                                DtChiTietNCC.Rows.Add(row);
                            }
                           
                        }  
            }
        #endregion
    }
}