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
    public partial class Form_ThemLoaiBanAn : Form
    {
        int mode;
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public LoaiBanAn_DTO LoaiBA = new LoaiBanAn_DTO();
        public Form_ThemLoaiBanAn()
        {
            InitializeComponent();
        }

        private void Form_ThemLoaiBanAn_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoaiBA.MaLoai = txtMaLoai.Text;
            LoaiBA.SucChua = int.Parse(txtSucChua.Text);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
