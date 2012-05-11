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
        DataTable dtNguyenLieu ;
        DataTable dtNguyenLieu_Source;
        int indexNL;
        #endregion

        #region "Khoi tao UserControl"
        public UCtrlNguyenLieu()
        {
            InitializeComponent();
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
            LoadNguyenLieu();
        }

        private void gvNguyenLieu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvNguyenLieu.GetSelectedRows().Length > 0)
            {
                indexNL = gvNguyenLieu.GetSelectedRows()[0];
                txtTenNguyenLieu.Text = dtNguyenLieu.Rows[indexNL]["TenNL"].ToString();
                txtDonVi.Text = dtNguyenLieu.Rows[indexNL]["DonVi"].ToString();
                txtSoLuongTon.Text = dtNguyenLieu.Rows[indexNL]["SoLuongTon"].ToString();
                TenNL = txtTenNguyenLieu.Text;
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNguyenLieu();
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
            dtNguyenLieu.Rows.Clear();
            dtNguyenLieu_Source = NguyenLieu_BUS.SelectNguyenLieu_toDataTable(_MaNH);

            int i = 0;
            foreach (DataRow row in dtNguyenLieu_Source.Rows)
            {
                DataRow row2 = dtNguyenLieu.NewRow();
                row2["STT"] = i + 1;
                row2["TenNL"] = row.ItemArray[2].ToString();
                row2["DonVi"] = row.ItemArray[3].ToString();
                row2["SoLuongTon"] = (int)row.ItemArray[4];
                dtNguyenLieu.Rows.Add(row2);

                i++;

            }
        }
        public void ThemNguyenLieu()
        {
            frmNguyenLieu_ThemNL _frmThemNL = new frmNguyenLieu_ThemNL();
            _frmThemNL.NguyenLieu.MaNH = _MaNH;
            if (_frmThemNL.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }
        public void XoaNguyenLieu()
        {
            BUS.NguyenLieu_BUS.DeleteNguyenLieu((int)dtNguyenLieu_Source.Rows[indexNL][0], _MaNH);
            dtNguyenLieu.Rows.RemoveAt(indexNL);
            dtNguyenLieu_Source.Rows.RemoveAt(indexNL);
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
                        temp.MaNL = (int)dtNguyenLieu_Source.Rows[indexNL][0];
                        temp.MaNH = dtNguyenLieu_Source.Rows[indexNL][1].ToString();
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
                            LoadNguyenLieu();
                        }
                    }
        }
        #endregion

 

    }
}
