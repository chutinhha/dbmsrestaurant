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

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlQLNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        int chon;
        int[] ArrayMaNV;
        public UCtrlQLNhanVien()
        {
            InitializeComponent();
        }

        private void UCtrlQLNhanVien_Load(object sender, EventArgs e)
        {
            gridLoaiNV.DataSource = LoaiNhanVien_BUS.DocLoaiNV();
            gridNhanVien.DataSource = NhanVien_BUS.DocNhanVien();

            DataTable dt = NhanVien_BUS.DocNhanVien();
            if (dt.Rows.Count > 0)
            {
                ArrayMaNV = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ArrayMaNV[i] = (int)dr[0];

                }
            }
        }

        private void btnThemLoaiNV_Click(object sender, EventArgs e)
        {
            ThemLoaiNhanVien();
        }

        public void ThemLoaiNhanVien()
        {
            Form_ThemLoaiNhanVien openForm = new Form_ThemLoaiNhanVien();
            if (openForm.ShowDialog() == DialogResult.OK)
            {
                if (LoaiNhanVien_BUS.KiemTraMaLoai(openForm.loaiNV.MaLoaiNV) == 1||LoaiNhanVien_BUS.KiemTraTenLoai(openForm.loaiNV.TenLoaiNV)==1)
                {
                }
                else
                {
                    LoaiNhanVien_BUS.ThemLoaiNV(openForm.loaiNV);
                    gridLoaiNV.DataSource = LoaiNhanVien_BUS.DocLoaiNV();
                }
            }
        }

        private void btnCapNhatLoaiNV_Click(object sender, EventArgs e)
        {
            CapNhatLoaiNhanVien();
            gridLoaiNV.DataSource = LoaiNhanVien_BUS.DocLoaiNV();
        }

        public void CapNhatLoaiNhanVien()
        {
            int flag = 0;
            int[] index = gridView_LoaiNV.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenloai = gridView_LoaiNV.GetRowCellValue(index[0], "TenLoai").ToString();
                string maloai = gridView_LoaiNV.GetRowCellValue(index[0], "MaLoai").ToString();

                if (maloai != null)
                {
                    DTO.LoaiNhanVien_DTO loaiNV = new LoaiNhanVien_DTO();
                    loaiNV.MaLoaiNV = maloai;
                    loaiNV.TenLoaiNV = tenloai;
                    flag = LoaiNhanVien_BUS.CapNhatLoaiNhanVien(loaiNV);
                }
            }
            if (flag != 0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaLoaiNV_Click(object sender, EventArgs e)
        {
            XoaLoaiNhanVien();
            gridLoaiNV.DataSource = LoaiNhanVien_BUS.DocLoaiNV();
        }

        public void XoaLoaiNhanVien()
        {
            int flag = 0;
            int[] index = gridView_LoaiNV.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maloai = gridView_LoaiNV.GetRowCellValue(index[0], "MaLoai").ToString();
                    flag = LoaiNhanVien_BUS.XoaLoaiNhanVien(maloai);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại nhân viên khi còn nhân viên trong Loại nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            Form_ThemNhanVien openForm = new Form_ThemNhanVien();
            if (openForm.ShowDialog() == DialogResult.OK)
            {
               NhanVien_BUS.ThemNhanVien(openForm.NhanVien);
                gridNhanVien.DataSource = NhanVien_BUS.DocNhanVien();
            }

        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            CapNhatNhanVien();
            gridNhanVien.DataSource = NhanVien_BUS.DocNhanVien();
        }

        public void CapNhatNhanVien()
        {
            int flag = 0;
            int[] index = gridView_NhanVien.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenNhanVien = gridView_NhanVien.GetRowCellValue(index[0], "TenNV").ToString();
                //  string maloai = gridView_MonAn.GetRowCellValue(index[0], "LoaiMon").ToString();
                string sdt = gridView_NhanVien.GetRowCellValue(index[0], "sdt").ToString();
                //  string maNH = gridView_MonAn.GetRowCellValue(index[0], "MaNH").ToString();

                if (tenNhanVien != null)
                {
                    DTO.NhanVien_DTO NhanVien = new NhanVien_DTO();
                    NhanVien.TenNV = tenNhanVien;
                    NhanVien.Sdt = int.Parse(sdt);

                    chon = index[0];
                    int tt =ArrayMaNV[chon];
                    flag = NhanVien_BUS.CapNhatNhanVien(NhanVien, tt);
                }
            }
            if (flag != 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            XoaNhanVien();
            gridNhanVien.DataSource = NhanVien_BUS.DocNhanVien();
        }

        public void XoaNhanVien()
        {
            int flag = 0;
            int[] index = gridView_NhanVien.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chon = index[0];
                    int maNhanVien = ArrayMaNV[chon];
                    flag = NhanVien_BUS.XoaNhanVien(maNhanVien);


                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // else
                    //DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Nhân Viên khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
