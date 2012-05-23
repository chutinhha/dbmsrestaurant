using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VNguyenLieu_DTO
    {
        private int maNL;
        private String maNH;
        private String tenNL;
        private String donVi;
        private int soLuongTon;
        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int MaNL
        {
            get { return maNL; }
            set {maNL= value;}
        }
        public String MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        public String TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }
        public String DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        public VNguyenLieu_DTO()
        {
            maNL = -1;
            maNH = null;
            tenNL = null;
            donVi = null;
            soLuongTon = 0;
            gia = 0;
        }
    }
}
