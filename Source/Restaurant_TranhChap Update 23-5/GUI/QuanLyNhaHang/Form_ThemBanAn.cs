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
    public partial class Form_ThemBanAn : Form
    {
        int[] ArrayMaKV;
        string[] ArrayLoaiBan;
        string[] ArrayMaNH;

        public BanAn_DTO BanAn = new BanAn_DTO();
        public Form_ThemBanAn()
        {
            InitializeComponent();
        }

        private void Form_ThemBanAn_Load(object sender, EventArgs e)
        {
            cbbKhuVuc.Properties.Items.Clear();
            DataTable dt = KhuVuc_BUS.DocKhuVuc();
            if (dt.Rows.Count > 0)
            {
                ArrayMaKV = new int[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cbbKhuVuc.Properties.Items.Add(dr[1]);
                    ArrayMaKV[i] = (int)dr[0];
                }
            }

            cbbNhaHang.Properties.Items.Clear();
            DataTable dt1 = KhuVuc_BUS.LayNhaHang();
            if (dt.Rows.Count > 0)
            {
                ArrayMaNH = new string[dt1.Rows.Count];
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr = dt1.Rows[i];
                    cbbNhaHang.Properties.Items.Add(dr[1]);
                    ArrayMaNH[i] = dr[0].ToString();
                }
            }

            cbbSucChua.Properties.Items.Clear();
            DataTable dt2 = LoaiBanAn_BUS.DocLoaiBanAn();
            if (dt.Rows.Count > 0)
            {
                ArrayLoaiBan = new string[dt2.Rows.Count];
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    DataRow dr = dt2.Rows[i];
                    cbbSucChua.Properties.Items.Add(dr[1]);
                    ArrayLoaiBan[i] = dr[0].ToString();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BanAn.MaBan = int.Parse(txtMaBan.Text);
            BanAn.MaKhuVuc = ArrayMaKV[cbbKhuVuc.SelectedIndex];
            BanAn.LoaiBan = ArrayLoaiBan[cbbSucChua.SelectedIndex];
            BanAn.MaNH = ArrayMaNH[cbbNhaHang.SelectedIndex];
            BanAn.TrangThai = 0;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
