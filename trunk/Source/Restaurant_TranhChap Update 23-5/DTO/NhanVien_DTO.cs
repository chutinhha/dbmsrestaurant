using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVien_DTO
    {
        int maNV;
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        string tenNV;
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        string maNH;
        public string MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }

        string maLoaiNV;
        public string MaLoaiNhanVien
        {
            get { return maLoaiNV; }
            set { maLoaiNV = value; }
        }

        int cmnd;
        public int Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        int sdt;
        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
