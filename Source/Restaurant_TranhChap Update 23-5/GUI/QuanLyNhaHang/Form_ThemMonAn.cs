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
    public partial class Form_ThemMonAn : Form
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public MonAn_DTO MonAn = new MonAn_DTO();
        string[] ArrayMaMon;
        string[] ArrayMaNH;
        public Form_ThemMonAn()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MonAn.tenmon = txtTenMonAn.Text;
            MonAn.Mamon = ArrayMaMon[cbbLoaiMonAn.SelectedIndex];
            MonAn.Gia = double.Parse(txtGia.Text);
            MonAn.Dvtinh = txtDonViTinh.Text;
            MonAn.Manh = ArrayMaNH[cbbNhaHang.SelectedIndex];

            MonAn_BUS.ThemMonAn(MonAn);

            this.Close();
        }

        private void Form_ThemMonAn_Load(object sender, EventArgs e)
        {
            cbbLoaiMonAn.Properties.Items.Clear();
            cbbNhaHang.Properties.Items.Clear();
            DataTable dt = MonAn_BUS.LayLoaiMon();

            if (dt.Rows.Count > 0)
            {
                ArrayMaMon = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cbbLoaiMonAn.Properties.Items.Add(dr[1]);
                    ArrayMaMon[i] = dr[0].ToString();

                }
            }
            DataTable dt1 = MonAn_BUS.LayNhaHang();
            if (dt1.Rows.Count > 0)
            {
                ArrayMaNH = new string[dt1.Rows.Count];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr = dt1.Rows[i];
                    cbbNhaHang.Properties.Items.Add(dr[1]);
                    ArrayMaNH[i] = dr[0].ToString();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
