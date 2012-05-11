using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MonAn_DTO
    {
        string maMonAn;

        public string Mamon
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }
        string tenMonAn;

        public string tenmon
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        string maLoai;

        public string Loaimon
        {
            get { return maLoai; }
            set { maLoai = value; }
        }

        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        string donViTinh;

        public string Dvtinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        string manh;

        public string Manh
        {
            get { return manh; }
            set { manh = value; }
        }

    }
}
