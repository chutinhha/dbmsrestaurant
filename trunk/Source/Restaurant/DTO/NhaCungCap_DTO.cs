using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhaCungCap_DTO
    {
        private int _MaNCC;
        private String _TenNCC;
        private String _sdt;
        private String _DiaChi;
        private int _DiemUuTien;


        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        public String TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }
        public String sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public String DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public int DiemUuTien
        {
            get { return _DiemUuTien; }
            set { _DiemUuTien = value; }
        }
    }
}
