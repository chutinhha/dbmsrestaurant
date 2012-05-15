using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiNhanVien_DTO
    {
        string maLoaiNV;
        public string MaLoaiNV
        {
            get { return maLoaiNV; }
            set { maLoaiNV = value; }
        }

        string tenLoaiNV;
        public string TenLoaiNV
        {
            get { return tenLoaiNV; }
            set { tenLoaiNV = value; }
        }

        long luong;
        public long Luong
        {
            get { return luong; }
            set { luong = value; }
        }
    }
}
