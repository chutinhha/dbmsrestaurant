using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.QuanLyNhaHang
{
    public partial class Form_ThemNhanVien : Form
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

        public NhanVien_DTO NhanVien = new NhanVien_DTO();
        string[] ArrayLoaiNV;
        //string[] ArrayNhaHang;
        public Form_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void Form_ThemNhanVien_Load(object sender, EventArgs e)
        {
            cbbLoaiNV.Properties.Items.Clear();
            //cbbNhaHang.Properties.Items.Clear();

            DataTable dt = LoaiNhanVien_BUS.DocLoaiNV(); 
            if (dt.Rows.Count > 0)
            {
                ArrayLoaiNV = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cbbLoaiNV.Properties.Items.Add(dr[1]);
                    ArrayLoaiNV[i] = dr[0].ToString();
                }
            }

            //DataTable dt1 = NhanVien_BUS.LayNhaHang();
            //if (dt1.Rows.Count > 0)
            //{
            //    ArrayNhaHang = new string[dt1.Rows.Count];
            //    for (int i = 0; i < dt1.Rows.Count; i++)
            //    {
            //        DataRow dr = dt1.Rows[i];
            //        cbbNhaHang.Properties.Items.Add(dr[1]);
            //        ArrayNhaHang[i] = dr[0].ToString();
            //    }
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NhanVien.TenNV = txtTenNV.Text;
            NhanVien.MaLoaiNhanVien = ArrayLoaiNV[cbbLoaiNV.SelectedIndex];
            //NhanVien.MaNH = ArrayNhaHang[cbbNhaHang.SelectedIndex];
            NhanVien.Cmnd = int.Parse(txtCMND.Text);
            NhanVien.Sdt = int.Parse(txtSoDT.Text);
           // NhanVien_BUS.ThemNhanVien(NhanVien);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
