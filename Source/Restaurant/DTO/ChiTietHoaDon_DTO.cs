using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        private int maHD;

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private int maMon;

        public int MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }

        private String tenMon;

        public String TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        private double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private String donvitinh;

        public String Donvitinh
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private double thanhtien;

        public double Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
