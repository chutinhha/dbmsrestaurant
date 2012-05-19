using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace GUI.QuanLyKho
{
    public partial class UCtrlNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        #region " Thuoc tinh && Properties "
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
            String maNH;
            public String MaNH
            {
                get { return maNH; }
                set { maNH = value; }
            }

            List<VNhaCungCap_DTO> lsNCC;
            DataTable dtNCC;
            DataTable dtNL_Source;
            DataTable dtNL;
            int indexNCC ;
            int indexNL;
            int sttNCC;
            int sttNL;
            VNguyenLieu_BUS busNguyenLieu;
            VChiTietNCC_BUS busChiTietNCC;
            VNhaCungCap_BUS busNhaCungCap;
            VBus Mybus;
        #endregion

        #region " Khoi tao "
            public UCtrlNhaCungCap()
            {
                busNguyenLieu = new VNguyenLieu_BUS();
                busChiTietNCC = new VChiTietNCC_BUS();
                busNhaCungCap = new VNhaCungCap_BUS();
                Mybus = new VBus();
                InitializeComponent();
                lsNCC = new List<VNhaCungCap_DTO>();
                dtNCC = new DataTable();            
                indexNCC = -1;            
                dtNCC.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtNCC.Columns.Add("TenNCC", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("sdt", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("DiaChi", System.Type.GetType("System.String"));
                dtNCC.Columns.Add("DiemUuTien", System.Type.GetType("System.Int32"));

                dtNL = new DataTable();
                indexNL = -1;
                dtNL.Columns.Add("STT", System.Type.GetType("System.Int16"));
                dtNL.Columns.Add("TenNL", System.Type.GetType("System.String"));
                dtNL.Columns.Add("Gia", System.Type.GetType("System.Double"));
            }
        #endregion

        #region " Event Control "

            private void UCtrlNhaCungCap_Load(object sender, EventArgs e)
            {
                LoadNhaCungCap();
            }
            private void gvNCC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try 
	            {
                    indexNCC = gvNCC.GetSelectedRows()[0];
                    sttNCC = int.Parse(gvNCC.GetDataRow(indexNCC)["STT"].ToString());
                    LoadNguyenLieu(lsNCC[sttNCC - 1].MaNCC);
	            }
	            catch (Exception){}
            }
            private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                try
                {
                    indexNL = gvNguyenLieu.GetSelectedRows()[0];
                    sttNL = int.Parse(gvNguyenLieu.GetDataRow(indexNL)["STT"].ToString());
                    txtGia.Text = dtNL_Source.Rows[sttNL - 1]["Gia"].ToString();
                }
                catch (Exception) { }                 
                               
            }
            private void btnThemNCC_Click(object sender, EventArgs e)
            {
                ThemNhaCungCap();
            }
            private void btnCapNhatNCC_Click(object sender, EventArgs e)
            {
                CapNhatNhaCungCap();
            }
            private void btnXoaNCC_Click(object sender, EventArgs e)
            {
                XoaNhaCungCap();
            }
            private void btnCapNhatGia_Click(object sender, EventArgs e)
            {
                CapNhatGia();
            }
            private void btnRefresh_Click(object sender, EventArgs e)
            {

                LoadNhaCungCap();
                
                LoadNguyenLieu(lsNCC[sttNCC - 1].MaNCC);
            }
            private void txtGia_EditValueChanged(object sender, EventArgs e)
            {
                if (txtGia.Text.Trim().Length == 0)
                    txtGia.Text = "0";
            }
            private void btnInDSNCC_Click(object sender, EventArgs e)
            {
                InDSNCC();
            }
        #endregion

        #region "Cac ham xu ly "
            public void LoadNhaCungCap()
            {
                gridNCC.DataSource = null;
                dtNCC.Rows.Clear();
                //try
                //{
                    lsNCC = busNhaCungCap.SelectNhaCungCap();

                    for (int i = 0; i < lsNCC.Count; i++)
                    {
                        DataRow row = dtNCC.NewRow();
                        row["STT"] = i + 1;
                        row["TenNCC"] = lsNCC[i].TenNCC;
                        row["sdt"] = lsNCC[i].sdt;
                        row["DiaChi"] = lsNCC[i].DiaChi;
                        row["DiemUuTien"] = lsNCC[i].DiemUuTien;
                        dtNCC.Rows.Add(row);
                    }
                    gridNCC.DataSource = dtNCC;
                //}
                //catch (Exception)
                //{
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Không đọc được dử liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                //}

            }
            public void LoadNguyenLieu(int MaNCC)
            {
                gridNguyenLieu.DataSource = null;
                
                dtNL.Rows.Clear();
                //try
                //{
                    dtNL_Source = busNguyenLieu.SelectNguyenLieu_In_NCC(MaNCC, maNH);
                   for (int i = 0; i < dtNL_Source.Rows.Count; i++)
                    {
                        DataRow row = dtNL.NewRow();

                        row["STT"] = i + 1;
                        row["TenNL"] = dtNL_Source.Rows[i]["TenNL"].ToString();
                        row["Gia"] = dtNL_Source.Rows[i]["Gia"];
                        dtNL.Rows.Add(row);
                    }
                    gridNguyenLieu.DataSource = dtNL;
                    if(gvNguyenLieu.GetSelectedRows().Length > 0)
                        txtGia.Text = dtNL_Source.Rows[sttNL-1]["Gia"].ToString();
                //}
                //catch (Exception)
                //{
                //    gridNCC.DataSource = null;
                //    gridNguyenLieu.DataSource = null;
                //    dtNCC.Rows.Clear();
                //    dtNL.Rows.Clear();
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Không đọc được dử liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                //}
            }
            public void ThemNhaCungCap()
            {
                frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
                //_frm.lsNguyenLieuChon = new List<VNguyenLieu_DTO>();
                _frm.Flag = 1;
                _frm.MaNH = maNH;
                if(_frm.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtNguyenLieu = _frm.DtNguyenLieuChon;
                    VNhaCungCap_DTO dtoNCC = _frm.DtoNCC;
                    try
                    {
                        int result = busNhaCungCap.InsertNhaCungCap(_frm.DtoNCC, _frm.DtChiTietNCC);
                        if (result == -1)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Thêm nhà cung cấp không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadNhaCungCap();
                            if (dtNCC.Rows.Count > 0)
                                gvNCC.SelectRow(0);
                            DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm nhà cung cấp mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Thêm nhà cung cấp không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            public void CapNhatNhaCungCap()
            {
                frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
                _frm.Flag = 2;
                _frm.MaNH = maNH;
                _frm.DtoNCC = lsNCC[indexNCC];                
                if (_frm.ShowDialog() == DialogResult.OK)
                {
                    DataTable dtNguyenLieu = _frm.DtNguyenLieuChon;
                    VNhaCungCap_DTO dtoNCC = _frm.DtoNCC;
                    try
                    {
                        int result = busNhaCungCap.UpdatetNhaCungCap(_frm.DtoNCC, _frm.DtChiTietNCC);
                        if (result == 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật nhà cung cấp không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadNhaCungCap();
                            LoadNguyenLieu(lsNCC[sttNCC - 1].MaNCC);
                            DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật nhà cung cấp không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            public void CapNhatGia()
            {
                int result = busChiTietNCC.UpdateChiTietNCC((int)dtNL_Source.Rows[sttNL - 1]["MaNL"], lsNCC[sttNCC- 1].MaNCC, Double.Parse(txtGia.Text));
                if (result != 0)
                {
                    LoadNguyenLieu(lsNCC[sttNCC - 1].MaNCC);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật giá cho nguyên liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật giá không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
            }
            public void XoaNhaCungCap()
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc là xóa nhà cung cấp này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //try
                    //{
                        int result = busNhaCungCap.DeleteNhaCungCap(lsNCC[indexNCC].MaNCC);
                        if (result == 1)
                        {
                            LoadNhaCungCap();
                            
                            DevExpress.XtraEditors.XtraMessageBox.Show("Đã xóa nhà cung cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            if (result == -1)
                                DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa nhà cung cấp này \n Ghi chú :không thể xóa nhà cung cấp khi thông tin nhà cung cấp được sử dụng trong đơn đặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa  nhà cung cấp thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //catch (Exception)
                    //{
                    //    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa nhà cung cấp thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
              
            }
            public void InDSNCC()
            {
                DevExpress.XtraPrinting.PrintingSystem printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
                DevExpress.XtraPrinting.PrintableComponentLink printLink = new DevExpress.XtraPrinting.PrintableComponentLink();
                try
                {
                    //Set to landscape
                    printingSystem1.PageSettings.Landscape = true;

                    this.Cursor = Cursors.WaitCursor;
                    printLink.Component = this.gridNCC;
                    printLink.CreateDocument(printingSystem1);

                    printingSystem1.PreviewRibbonFormEx.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                    printingSystem1.Dispose();
                    printLink.Dispose();
                }
            }
        #endregion


    }
}
