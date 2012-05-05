using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class ChiTietDatHang_DTO
    {
        private int _MaHoaDon;
        private int _ThanhTien;
        private DateTime _ThoiGianDat;
        private DateTime _ThoiGianGiao;
        private String _MaNH;

        public int MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }
        public int ThanhTien
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
    }
}
