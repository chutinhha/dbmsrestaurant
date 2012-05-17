using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VDatHang_DTO
    {
        private int maHoaDon;
        private int maNCC;
        private String maNH;
        private double tongTien;
        private DateTime thoiGianDat;
        private DateTime thoiGianGiao;
        private String tinhTrang;
        private String tenNCC;

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public DateTime ThoiGianDat
        {
            get { return thoiGianDat; }
            set { thoiGianDat = value; }
        }
        public DateTime ThoiGianGiao
        {
            get { return thoiGianGiao; }
            set { thoiGianGiao = value; }
        }
        public String MaNH
        {
            get { return maNH;}
            set { maNH = value; }
        }
        public String TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public String TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
    }
}
