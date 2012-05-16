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
            String maNH;
            public String MaNH
            {
                get { return maNH; }
                set { maNH = value; }
            }

            List<VNhaCungCap_DTO> lsNCC;
            List<VNguyenLieu_DTO> lsNguyenLieu;
            DataTable dtNCC;
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

                lsNguyenLieu = new List<VNguyenLieu_DTO>();
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
                if( gvNCC.GetSelectedRows().Length >0)
                {
                    indexNCC = gvNCC.GetSelectedRows()[0];
                    sttNCC = int.Parse(gvNCC.GetDataRow(indexNCC)["STT"].ToString());
                    LoadNguyenLieu(lsNCC[sttNCC-1].MaNCC);
                }

            }
            private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
            {
                if (gvNguyenLieu.GetSelectedRows().Length > 0)
                {
                    indexNL = gvNguyenLieu.GetSelectedRows()[0];
                    sttNL = int.Parse(gvNguyenLieu.GetDataRow(indexNL)["STT"].ToString());
                    txtGia.Text = lsNguyenLieu[sttNL-1].Gia.ToString();
                }
               
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
                    lsNguyenLieu = busNguyenLieu.SelectNguyenLieu_fromNCC(MaNCC, maNH);
                    for (int i = 0; i < lsNguyenLieu.Count; i++)
                    {
                        DataRow row = dtNL.NewRow();
                        row["Stt"] = i + 1;
                        row["TenNL"] = lsNguyenLieu[i].TenNL;
                        row["Gia"] = lsNguyenLieu[i].Gia;
                        dtNL.Rows.Add(row);
                    }
                    gridNguyenLieu.DataSource = dtNL;
                    if(gvNguyenLieu.GetSelectedRows().Length > 0)
                        txtGia.Text = lsNguyenLieu[sttNL-1].Gia.ToString();
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
                _frm.lsNguyenLieuChon = new List<VNguyenLieu_DTO>();
                _frm.Flag = 1;
                _frm.MaNH = maNH;
                _frm.LoadNguyenLieu(1);
                if(_frm.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            public void CapNhatNhaCungCap()
            {
                frmNhaCungCap_Them_CapNhat _frm = new frmNhaCungCap_Them_CapNhat();
                _frm.Flag = 2;
                _frm.MaNH = maNH;
                _frm.NCC = lsNCC[indexNCC];
                _frm.lsNguyenLieuChon = lsNguyenLieu;
                _frm.LoadNguyenLieu(2);
                _frm.LoadNguyenLieuChon();
                
                if (_frm.ShowDialog() == DialogResult.OK)
                {
                    lsNCC[indexNCC] = _frm.NCC;
                    gvNCC.FocusedRowHandle = indexNCC-1;
                    gvNCC.FocusedRowHandle = indexNCC+1;
                }
            }
            public void CapNhatGia()
            {
                int result = busChiTietNCC.UpdateChiTietNCC(lsNguyenLieu[sttNL - 1].MaNL, lsNCC[sttNCC- 1].MaNCC, Double.Parse(txtGia.Text));
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
               busNhaCungCap.DeleteNhaCungCap(lsNCC[indexNCC].MaNCC);
               lsNCC.RemoveAt(indexNCC);
               dtNCC.Rows.RemoveAt(indexNCC);
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
