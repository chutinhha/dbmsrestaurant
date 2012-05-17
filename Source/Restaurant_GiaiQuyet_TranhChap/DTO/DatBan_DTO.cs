using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DatBan_DTO
    {
       
        private string tenkhuvuc;
        private string loaiban;
        private string makhuvuc;
        private string maNH;
     
        private string succhua;
        private string vitri;
        private string sdt;
        private string maBan;
        private string thoiGianDen;
        private string tenKhachHang;
        private string thoiGianDat;

        public string ThoiGianDat
        {
            get { return thoiGianDat; }
            set { thoiGianDat = value; }
        }

        public string Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }

        

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        

        public string MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        

        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }

        string maKhachHang;
        
        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }
        
        string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        

        public string ThoiGianDen
        {
            get { return thoiGianDen; }
            set { thoiGianDen = value; }
        }
       

    

        public string Tenkhuvuc
        {
            get { return tenkhuvuc; }
            set { tenkhuvuc = value; }
        }


        public string Loaiban
        {
            get { return loaiban; }
            set { loaiban = value; }
        }


        public string Makhuvuc
        {
            get { return makhuvuc; }
            set { makhuvuc = value; }
        }

 



        public string Succhua
        {
            get { return succhua; }
            set { succhua = value; }
        }
    }
}
