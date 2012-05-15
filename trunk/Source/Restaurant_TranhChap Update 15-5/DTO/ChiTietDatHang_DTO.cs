using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietDatHang_DTO
    {
        private int _MaHoaDon;
        private int _MaNL;
        private int _SoLuong;
        private double _ThanhTien;
        private String _TenNL;
        private String _DonVi;


        public int MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        public int MaNL
        {
            get { return _MaNL; }
            set { _MaNL = value; }
        }
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        public double ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
        public String TenNL
        {
            get { return _TenNL; }
            set { _TenNL = value; }
        }
        public String DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
        }
    }
}
