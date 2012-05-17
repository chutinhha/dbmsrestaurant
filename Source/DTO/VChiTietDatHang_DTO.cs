using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VChiTietDatHang_DTO
    {
        private int maHoaDon;
        private int maNL;
        private int soLuong;
        private double thanhTien;
        private String tenNL;
        private String donVi;


        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public int MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
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
    }
}
