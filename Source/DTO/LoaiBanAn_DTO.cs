using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiBanAn_DTO
    {
        string maLoai;
        public string MaLoai
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        int sucChua;
        public int SucChua
        {
            get { return sucChua; }
            set { sucChua = value; }
        }
    }
}
