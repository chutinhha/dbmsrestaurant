using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietNCC_DTO
    {
        private int _MaNL;
        private int _MaNCC;
        private String _TenNL;
        private String _TenNCC;
        private double _Gia;

        public double Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        public int MaNL
        {
            get { return _MaNL; }
            set { _MaNL = value; }
        }
        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        public String TenNL
        {
            get { return _TenNL; }
            set { _TenNL = value; }
        }
        public String TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }        
    }
}
