using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhuVuc_DTO
    {
        int maKhuVuc;
        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }

        string tenKhuVuc;
        public string TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }

        string viTri;
        public string ViTri
        {
            get { return viTri; }
            set { viTri = value; }
        }

        string maNH;
        public string MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
    }
}
