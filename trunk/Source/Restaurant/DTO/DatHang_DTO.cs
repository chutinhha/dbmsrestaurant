using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class DatHang_DTO
    {
        private int _MaHoaDon;
        private int _MaNCC;
        private int _MaNguyenLieu;
        private int _SoLuong;
        private long _Gia;

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
        public int MaNguyenLieu
        {
            get { return _MaNguyenLieu; }
            set { _MaNguyenLieu = value; }
        }
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        public long Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
    }
}
