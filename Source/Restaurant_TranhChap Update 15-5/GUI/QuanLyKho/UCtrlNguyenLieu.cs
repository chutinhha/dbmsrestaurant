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

        String tenNguyenLieu;
        DataTable dtNguyenLieu ;
        DataTable dtNguyenLieu_Source;
        int indexNL;
        int stt;
        VNguyenLieu_BUS busNguyenLieu;
        #endregion

        #region "Khoi tao UserControl"
        public UCtrlNguyenLieu()
        {
            InitializeComponent();

            busNguyenLieu = new VNguyenLieu_BUS();

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
                stt = int.Parse(gvNguyenLieu.GetDataRow(indexNL)["STT"].ToString());

                txtTenNguyenLieu.Text = dtNguyenLieu.Rows[stt-1]["TenNL"].ToString();
                txtDonVi.Text = dtNguyenLieu.Rows[stt-1]["DonVi"].ToString();
                txtSoLuongTon.Text = dtNguyenLieu.Rows[stt-1]["SoLuongTon"].ToString();
                tenNguyenLieu = txtTenNguyenLieu.Text;
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
            try
            {
                dtNguyenLieu_Source = busNguyenLieu.SelectNguyenLieu_toDataTable(mode, maNH);

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
            catch (Exception) { }

        }
        public void ThemNguyenLieu()
        {
            frmNguyenLieu_ThemNL _frmThemNL = new frmNguyenLieu_ThemNL();
            _frmThemNL.NguyenLieu.MaNH = maNH;
            if (_frmThemNL.ShowDialog() == DialogResult.OK)
            {
                LoadNguyenLieu();
            }
        }
        public void XoaNguyenLieu()
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc là xóa nguyên liệu này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int result = busNguyenLieu.DeleteNguyenLieu(mode, (int)dtNguyenLieu_Source.Rows[stt - 1][0], maNH);
                    if (result == 1)
                    {
                        LoadNguyenLieu();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Xóa nguyên liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (result == -1)
                            DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa nguyên liệu này \n Ghi chú :không thể xóa nguyên liệu khi thông tin nguyên liệu được sử dụng trong danh sách nguyên liệu của nhà cung cấp và trong đơn đặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Xóa nguyên liệu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa nguyên liệu thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

                        VNguyenLieu_DTO temp = new VNguyenLieu_DTO();
                        temp.MaNL = (int)dtNguyenLieu_Source.Rows[stt-1][0];
                        temp.MaNH = dtNguyenLieu_Source.Rows[stt-1][1].ToString();
                        temp.TenNL = txtTenNguyenLieu.Text.Trim();
                        temp.DonVi = txtDonVi.Text.Trim();
                        temp.SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim());
                        try
                        {
                            if (busNguyenLieu.UpdateNguyenLieu(mode, temp) == 0)
                            {
                                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                LoadNguyenLieu();
                                DevExpress.XtraEditors.XtraMessageBox.Show("Đã cập nhật lại dử liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                            }
                        }
                        catch (Exception)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
        }
        #endregion

    }
}
