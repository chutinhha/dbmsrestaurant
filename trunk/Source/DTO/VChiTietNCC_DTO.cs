using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VChiTietNCC_DTO
    {
        private int maNL;
        private int maNCC;
        private String tenNL;
        private String tenNCC;
        private double gia;


        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public String TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }
        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }


    }
}
