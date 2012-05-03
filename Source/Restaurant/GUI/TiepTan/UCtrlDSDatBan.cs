using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI.TiepTan
{
    public partial class UCtrlDSDatBan : DevExpress.XtraEditors.XtraUserControl
    {
        //Khai bao 1 delegate
        public delegate void deleDatBan();
        public deleDatBan DatBan;
        public UCtrlDSDatBan()
        {
            InitializeComponent();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            //khoi dong su kien dat ban
            if(DatBan!=null)
                DatBan();
        }
    }
}
