using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BUS;
using DTO;
namespace GUI.QuanLyKho
{
    public partial class UCtrlNguyenLieu : DevExpress.XtraEditors.XtraUserControl
    {
        #region " Thuoc Tinh & Properties"
        String _MaNH;
        public String MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }

        String TenNL;
        List<NguyenLieu_DTO> lsNguyenLieu;
        DataTable dtNguyenLieu ;
        int indexNL;
        #endregion

        #region "Khoi tao UserControl"
        public UCtrlNguyenLieu()
        {
            InitializeComponent();
            lsNguyenLieu = new List<NguyenLieu_DTO>();
            dtNguyenLieu = new DataTable();
            indexNL = -1;

            dtNguyenLieu.Columns.Add("STT", System.Type.GetType("System.Int16"));
            dtNguyenLieu.Columns.Add("TenNL", System.Type.GetType("System.String"));
            dtNguyenLieu.Columns.Add("DonVi", System.Type.GetType("System.String"));
            dtNguyenLieu.Columns.Add("SoLuongTon", System.Type.GetType("System.Int32"));
            gridNguyenLieu.DataSource = dtNguyenLieu;
        }
        #endregion

        #region "Event Control"
        private void UCtrlNguyenLieu_Load(object sender, EventArgs e)
        {
            
        }

        private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNguyenLieu.GetSelectedRows().Length > 0)
            {
                indexNL = gvNguyenLieu.GetSelectedRows()[0];
                txtTenNguyenLieu.Text = lsNguyenLieu[indexNL].TenNL;
                txtDonVi.Text = lsNguyenLieu[indexNL].DonVi;
                txtSoLuongTon.Text = lsNguyenLieu[indexNL].SoLuongTon.ToString();

                TenNL = lsNguyenLieu[indexNL].TenNL;
            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            XoaNguyenLieu();
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            ThemNguyenLieu();
        }

        private void btnCapNhatNguyenLieu_Click(object sender, EventArgs e)
        {
            CapNhatNguyenLieu();
        }

        private void btnInDanhMucNL_Click(object sender, EventArgs e)
        {
            DevExpress.XtraPrinting.PrintingSystem printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem();
            DevExpress.XtraPrinting.PrintableComponentLink printLink = new DevExpress.XtraPrinting.PrintableComponentLink();
            try
            {
                //Set to landscape
                printingSystem1.PageSettings.Landscape = true;

                this.Cursor = Cursors.WaitCursor;
                printLink.Component = this.gridNguyenLieu;
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

        #region "Cac ham xu ly "
        public void LoadNguyenLieu()
        {
            //gridNguyenLieu.DataSource = null;
            dtNguyenLieu.Rows.Clear();
            lsNguyenLieu = NguyenLieu_BUS.SelectNguyenLieu(_MaNH);

            for (int i = 0; i < lsNguyenLieu.Count; i++)
            {
                DataRow row = dtNguyenLieu.NewRow();
                row["Stt"] = i + 1;
                row["TenNL"] = lsNguyenLieu[i].TenNL;
                row["DonVi"] = lsNguyenLieu[i].DonVi;
                row["SoLuongTon"] = lsNguyenLieu[i].SoLuongTon;
                dtNguyenLieu.Rows.Add(row);
            }
            
        }
        public void ThemNguyenLieu()
        {
            frmNguyenLieu_ThemNL _frmThemNL = new frmNguyenLieu_ThemNL();
            _frmThemNL.NguyenLieu.MaNH = _MaNH;
            if (_frmThemNL.ShowDialog() == DialogResult.OK)
            {
                DataRow row = dtNguyenLieu.NewRow();
                row["STT"] = dtNguyenLieu.Rows.Count + 1;
                row["TenNL"] = _frmThemNL.NguyenLieu.TenNL;
                row["DonVi"] = _frmThemNL.NguyenLieu.DonVi;
                row["SoLuongTon"] = 0;
                dtNguyenLieu.Rows.Add(row);
                lsNguyenLieu.Add(_frmThemNL.NguyenLieu);
            }
        }
        public void XoaNguyenLieu()
        {
            BUS.NguyenLieu_BUS.DeleteNguyenLieu(lsNguyenLieu[indexNL].MaNL, _MaNH);
            lsNguyenLieu.RemoveAt(indexNL);
            dtNguyenLieu.Rows.RemoveAt(indexNL);
        }
        public void CapNhatNguyenLieu()
        {
            if (txtTenNguyenLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên Nguyên Liệu !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNguyenLieu.Focus();
            }
            else
                if (txtDonVi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập đơn vị nguyên liêu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonVi.Focus();
                }
                else
                    if (txtSoLuongTon.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng tồn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoLuongTon.Focus();
                    }
                    else
                    {

                        NguyenLieu_DTO temp = new NguyenLieu_DTO();
                        temp.MaNL = lsNguyenLieu[indexNL].MaNL;
                        temp.MaNH = lsNguyenLieu[indexNL].MaNH;
                        temp.TenNL = txtTenNguyenLieu.Text.Trim();
                        temp.DonVi = txtDonVi.Text.Trim();
                        temp.SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
                        int a = BUS.NguyenLieu_BUS.UpdateNguyenLieu(TenNL, temp);
                        if (BUS.NguyenLieu_BUS.UpdateNguyenLieu(TenNL, temp) == 0)
                        {
                            MessageBox.Show("Tên nguyên liệu này đã có trong danh sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTenNguyenLieu.Focus();
                        }
                        else
                        {
                            dtNguyenLieu.Rows[indexNL]["TenNL"] = txtTenNguyenLieu.Text.Trim();
                            dtNguyenLieu.Rows[indexNL]["DonVi"] = txtDonVi.Text.Trim();
                            dtNguyenLieu.Rows[indexNL]["SoLuongTon"] = int.Parse(txtSoLuongTon.Text.Trim());
                            lsNguyenLieu[indexNL].TenNL = txtTenNguyenLieu.Text.Trim();
                            lsNguyenLieu[indexNL].DonVi = txtDonVi.Text.Trim();
                            lsNguyenLieu[indexNL].SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
                        }
                    }
        }
        #endregion



    }
}
