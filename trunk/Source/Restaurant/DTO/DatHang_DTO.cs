using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DatHang_DTO
    {
        private int _MaHoaDon;
        private int _MaNCC;
        private String _MaNH;
        private double _ThanhTien;
        private DateTime _ThoiGianDat;
        private DateTime _ThoiGianGiao;
        private String _TinhTrang;
        private String _TenNCC;

        public int MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        public double ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
        public DateTime ThoiGianDat
        {
            get { return _ThoiGianDat; }
            set { _ThoiGianDat = value; }
        }
        public DateTime ThoiGianGiao
        {
            get { return _ThoiGianGiao; }
            set { _ThoiGianGiao = value; }
        }
        public String MaNH
        {
            get { return _MaNH;}
            set { _MaNH = value; }
        }
        public String TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public String TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }
    }
}
