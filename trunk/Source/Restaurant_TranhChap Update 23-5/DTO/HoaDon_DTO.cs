using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private double tongtien;

        public double Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        private DateTime thoigianlap;

        public DateTime Thoigianlap
        {
            get { return thoigianlap; }
            set { thoigianlap = value; }
        }
        private DateTime thoigianKetthuc;

        public DateTime ThoigianKetthuc
        {
            get { return thoigianKetthuc; }
            set { thoigianKetthuc = value; }
        }
        private int manv;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private int maban;

        public int Maban
        {
            get { return maban; }
            set { maban = value; }
        }

    }
}
