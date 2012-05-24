using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.QuanLyNhaHang
{
    public partial class UCtrlThongKeDoanhThu : DevExpress.XtraEditors.XtraUserControl
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
        public UCtrlThongKeDoanhThu()
        {
            InitializeComponent();
        }
    }
}
