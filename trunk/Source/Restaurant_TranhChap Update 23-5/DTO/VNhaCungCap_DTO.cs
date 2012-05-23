using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VNhaCungCap_DTO
    {
        private int maNCC;
        private String tenNCC;
        private String _sdt;
        private String diaChi;
        private int diemUuTien; 

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public String sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public int DiemUuTien
        {
            get { return diemUuTien; }
            set { diemUuTien = value; }
        }
    }
}
