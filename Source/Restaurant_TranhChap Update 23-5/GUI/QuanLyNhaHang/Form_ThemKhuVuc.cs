using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI.QuanLyNhaHang
{
    public partial class Form_ThemKhuVuc : Form
    {
        string[] ArrayMaNH;
        public KhuVuc_DTO KhuVuc = new KhuVuc_DTO();
        public Form_ThemKhuVuc()
        {
            InitializeComponent();
        }

        private void Form_ThemKhuVuc_Load(object sender, EventArgs e)
        {
            cbbNhaHang.Properties.Items.Clear();
            DataTable dt = KhuVuc_BUS.LayNhaHang();
            if (dt.Rows.Count > 0)
            {
                ArrayMaNH = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cbbNhaHang.Properties.Items.Add(dr[1]);
                    ArrayMaNH[i] = dr[0].ToString();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            KhuVuc.MaKhuVuc = int.Parse(txtMaKV.Text);
            KhuVuc.TenKhuVuc = txtTenKV.Text;
            KhuVuc.ViTri = txtViTri.Text;
            KhuVuc.MaNH = ArrayMaNH[cbbNhaHang.SelectedIndex];
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
