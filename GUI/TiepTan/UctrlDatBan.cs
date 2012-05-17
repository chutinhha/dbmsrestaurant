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
using System.Data.SqlClient;

namespace GUI.TiepTan
{
    public partial class UctrlDatBan : DevExpress.XtraEditors.XtraUserControl
    {
        int maNH = 1;
        List< DatBan_DTO> dsBanDat = new List<DatBan_DTO>();
        DataTable tbBanTrong = new DataTable();
        DataTable tbBanDat = new DataTable();
        int row;
        string maBanChon;
        bool flag = false;
        DatBan_BUS DatBan_BUS = new DatBan_BUS();

        public UctrlDatBan()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            DocBanTrong();
            DocKhachHang();
        }
        private void UctrlDatBan_Load(object sender, EventArgs e)
        {
            CreateStructTable();
            LoadForm();
        }
        

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if ( flag  /*&& txtSoDienThoai.Text != ""*/ && txtThoiGianDen.Text != "" && maBanChon!=null)
            {
               
                    DatBan_DTO banDat = new DatBan_DTO();
                    banDat.MaBan = maBanChon;
                    banDat.MaKhachHang =cbbTenKhachHang.SelectedValue.ToString();
                    banDat.TenKhachHang = cbbTenKhachHang.Text;
                    banDat.Sdt = txtSoDienThoai.Text;
                    banDat.ThoiGianDen =  txtThoiGianDen.Text;
                    banDat.Vitri  = gridView_BanTrong.GetRowCellValue(row, "ViTri").ToString();
                    banDat.MaNH = maNH.ToString();
                    dsBanDat.Add(banDat);
                    Them1BanDat(banDat);
                    //if (tbBanTrong.Rows.Count > 0)
                    //{
                    //    tbBanTrong.Rows.RemoveAt(row);
                    //    gridControl_BanTrong.DataSource = tbBanTrong;
                    //}
                    gridControl_DatBan.DataSource = tbBanDat;
                    Refest();
                //}
                //else
                //    DevExpress.XtraEditors.XtraMessageBox.Show("Nhập dữ liệu không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn cần nhật đầy đủ thông tin","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        //
  

        private void gridView_BanTrong_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
             int []index=gridView_BanTrong.GetSelectedRows();
            if (index.Length > 0)
            {
                maBanChon = gridView_BanTrong.GetRowCellValue(index[0], "MaBan").ToString();
                row = index[0];
                flag = true;
            }
        }

        private void btnKhongDatBan_Click(object sender, EventArgs e)
        {
            tbBanDat.Clear();
            gridControl_DatBan.DataSource = tbBanDat;
            Refest();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (dsBanDat.Count > 0)
            {
                for (int i = 0; i < dsBanDat.Count; i++)
                {
                    DatBan_DTO banDat = new DatBan_DTO();
                    banDat.MaNH = maNH.ToString();
                    banDat.MaBan = dsBanDat[i].MaBan;
                    banDat.ThoiGianDen = dsBanDat[i].ThoiGianDen;
                    banDat.Sdt = dsBanDat[i].Sdt;
                    banDat.MaKhachHang = dsBanDat[i].MaKhachHang;
                    if (DatBan_BUS.ThemDatBan(banDat) > 0)
                    {
                        //Cập nhật Tình trạng bên bảng Bàn Ăn
                        if(dsBanDat[i].Sdt=="")
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bàn số " + dsBanDat[i].MaBan + " đặt không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            DevExpress.XtraEditors.XtraMessageBox.Show("Bàn số " + dsBanDat[i].MaBan + " đã được đặt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // DatBan_BUS.UpdateTrangThaiBanAn(int.Parse( banDat.MaBan));
                       
                        
                    }
                    else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Bàn số " + dsBanDat[i].MaBan + " đặt không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
                DevExpress.XtraEditors.XtraMessageBox.Show("Chưa có bàn đặt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dsBanDat.Clear();
            tbBanDat.Rows.Clear();
            gridControl_DatBan.DataSource = tbBanDat;
            Refest();
        }

        private void btnHuyDatBan_Click(object sender, EventArgs e)
        {
            int[] index = gridView_BanDat.GetSelectedRows();
            if (index.Length > 0 && tbBanDat.Rows.Count>0)
            {
                tbBanDat.Rows.RemoveAt(index[0]);
                gridControl_DatBan.DataSource = tbBanDat;
            }
        }
        #region Các Hàm xử lý
        private void DocBanTrong()
        {
            tbBanTrong = DatBan_BUS.DocBanTrong(maNH);
            gridControl_BanTrong.DataSource = tbBanTrong;
        }
        private void CreateStructTable()
        {
            tbBanDat.Columns.Add("MaBan", Type.GetType("System.String"));
            tbBanDat.Columns.Add("TenKhachHang", Type.GetType("System.String"));
            tbBanDat.Columns.Add("Sdt", Type.GetType("System.String"));
            tbBanDat.Columns.Add("ThoiGianDen", Type.GetType("System.DateTime"));
            tbBanDat.Columns.Add("ViTri", Type.GetType("System.String"));

        }
        private void Refest()
        {
            txtSoDienThoai.Text = "";
            txtThoiGianDen.Text = "";
            flag = false;
        }
        private void Them1BanDat(DatBan_DTO banDat)
        {
            DataRow newrow = tbBanDat.NewRow();
            newrow["MaBan"] = banDat.MaBan;
            newrow["TenKhachHang"] = banDat.TenKhachHang;
            newrow["Sdt"] = banDat.Sdt;
            newrow["ThoiGianDen"] = banDat.ThoiGianDen;
            newrow["ViTri"] = banDat.Vitri;
            tbBanDat.Rows.Add(newrow);
        }
        private void DocKhachHang()
        {
            cbbTenKhachHang.DataSource = KhachHang_BUS.DocKhacHang();
            cbbTenKhachHang.DisplayMember = "TenKhachHang";
            cbbTenKhachHang.ValueMember = "cmnd";
        }
        #endregion
       
    }
}
