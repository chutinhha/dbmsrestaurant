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

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlQLThucDon : DevExpress.XtraEditors.XtraUserControl
    {

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

        DatBan_DTO banDat = new DatBan_DTO();
        MonAn_DTO MonAn = new MonAn_DTO();
        int chon;
        int tt;
        int[] ArrayMaMon;
        string[] ArrayLoaiMon;

        public UCtrlQLThucDon()
        {
            InitializeComponent();
        }

        private void UCtrl_QLNhaHang_QLThucDon_Load(object sender, EventArgs e)
        {
         
            gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
            
            gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
           
            
            DataTable dt = MonAn_BUS.DocMonAn(mode,maNH);
            if (dt.Rows.Count > 0)
            {
                ArrayMaMon = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ArrayMaMon[i] = (int)dr[0];
                }
            }

            DataTable dt1 = MonAn_BUS.LayLoaiMon();
            if (dt1.Rows.Count > 0)
            {
                ArrayLoaiMon = new string[dt.Rows.Count];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr = dt1.Rows[i];
                    cbbChiTietTK.Properties.Items.Add(dr[1]);
                    ArrayLoaiMon[i] = dr[0].ToString();
                }
            }
        }

        private void btnThemLoaiMA_Click(object sender, EventArgs e)
        {
            ThemLoaiMonAn();
        }
        private void btnCapNhatLoaiMA_Click(object sender, EventArgs e)
        {
          
                CapNhatLoaiMonAn();
                gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
            
        }
        private void btnXoaLoaiMA_Click(object sender, EventArgs e)
        {
            XoaLoaiMonAn();
            gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
        }
        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            XoaMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
        }

        #region cac Ham ThemXoaSua

        private void CapNhatLoaiMonAn()
        {
            int flag = 0;
            int[] index= gridView_LoaiMonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "TenLoai").ToString();
                string maloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "MaLoai").ToString();
               
                if (maloai != null)
                {
                    DTO.LoaiMonAn_DTO loaiMonAn = new LoaiMonAn_DTO();
                    loaiMonAn.Maloai = maloai;
                    loaiMonAn.Tenloai = tenloai;
                   flag= LoaiMonAn_BUS.CapNhatLoaiMonAn(loaiMonAn);
                }
            }
            if(flag!=0)
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void XoaLoaiMonAn()
        {
            int flag = 0;
            int[] index= gridView_LoaiMonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string maloai = gridView_LoaiMonAn.GetRowCellValue(index[0], "MaLoai").ToString();
                    flag= LoaiMonAn_BUS.XoaLoaiMonAn(maloai);
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại món ăn khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        private void ThemLoaiMonAn()
        {
            Form_ThemLoaiMonAn openForm = new Form_ThemLoaiMonAn();
            openForm.Mode = mode;
            if (openForm.ShowDialog() == DialogResult.OK)
            {
                
                   
               
                    LoaiMonAn_BUS.ThemLoaiMonAn(openForm.loaiMonAn);
                    gridLoaiMonAn.DataSource = LoaiMonAn_BUS.DocLoaiMonAn();
                
                
            }
        }
        ////
        private void XoaMonAn()
        {
            int flag = 0;
            int[] index = gridView_MonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có muốn xóa dòng thứ " + (index[0] + 1).ToString(), "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    chon = index[0];
                    int maMon = ArrayMaMon[chon];
                    flag = MonAn_BUS.XoaMonAn(mode,maMon);

                    
                }
                if (flag != 0)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Không thể xóa Loại món ăn khi còn món ăn trong Loại món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            ThemMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
        }

        public void ThemMonAn()
        {
            Form_ThemMonAn openf = new Form_ThemMonAn();
            openf.Mode = mode;
            if (openf.ShowDialog() == DialogResult.OK)
            {
                int flag=MonAn_BUS.ThemMonAn(mode,openf.MonAn,maNH);
                if (flag == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm Món ăn không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Thêm Món ăn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
            }

        }

        private void btnCapNhatMonAn_Click(object sender, EventArgs e)
        {
            CapNhatMonAn();
            gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
        }

        public void CapNhatMonAn()
        {
            int flag = 0;
            int[] index = gridView_MonAn.GetSelectedRows();
            if (index.Length > 0)
            {
                string tenMon = gridView_MonAn.GetRowCellValue(index[0], "TenMon").ToString();
                //  string maloai = gridView_MonAn.GetRowCellValue(index[0], "LoaiMon").ToString();
                string gia = gridView_MonAn.GetRowCellValue(index[0], "Gia").ToString();
                string donvitinh = gridView_MonAn.GetRowCellValue(index[0], "DonViTinh").ToString();
                //  string maNH = gridView_MonAn.GetRowCellValue(index[0], "MaNH").ToString();

                if (tenMon != null)
                {
                    DTO.MonAn_DTO MonAn = new MonAn_DTO();
                    MonAn.tenmon = tenMon;
                    //  MonAn.MaLoai = maloai;
                    MonAn.Gia =double.Parse( gia);
                    MonAn.Dvtinh= donvitinh;
                    //  MonAn.MaNhaHang = maNH;        dang can nhac

                    chon = index[0];
                     tt = ArrayMaMon[chon];
                    flag = MonAn_BUS.CapNhatMonAn(mode,MonAn, tt,maNH);
                }
            }
            if (flag != 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cbbDSTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbbChiTietTK.SelectedIndex != -1)
            {
                string maLoai = ArrayLoaiMon[cbbChiTietTK.SelectedIndex];
                string tenLoai = cbbChiTietTK.Text;
                int sl=0;
                DataTable dt = MonAn_BUS.TimTheoLoai(mode,maLoai, maNH,ref sl);
                DevExpress.XtraEditors.XtraMessageBox.Show("Loại món '"+tenLoai+"' có số lượng: "+sl.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridMonAn.DataSource = dt ;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridMonAn.DataSource = MonAn_BUS.DocMonAn(mode,maNH);
        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    MonAn_BUS.CapNhatMonAn_Commmit(MonAn, tt);
        //    gridMonAn.DataSource = MonAn_BUS.DocMonAn();
        //}

    }
}
