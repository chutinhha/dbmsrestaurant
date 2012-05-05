using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NguyenLieu_DTO
    {
        private int _MaNL;
        private String _MaNH;
        private String _TenNL;
        private double _Gia;
        private String _DonVi;
        private int _SoLuongTon;
        private int _MaNCC;

        public int MaNL
        {
            get { return _MaNL; }
            set {_MaNL= value;}
        }
        public String MaNH
        {
            get { return _MaNH; }
            set { _MaNH = value; }
        }
        public String TenNL
        {
            get { return _TenNL; }
            set { _TenNL = value; }
        }
        public double Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        public String DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
        }
        public int SoLuongTon
        {
            get { return _SoLuongTon; }
            set { _SoLuongTon = value; }
        }
        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        public NguyenLieu_DTO()
        {
            _MaNL = -1;
            _MaNH = null;
            _TenNL = null;
            _Gia = 0;
            _DonVi = null;
            _SoLuongTon = 0;
            _MaNCC = -1;
        }
    }
}
