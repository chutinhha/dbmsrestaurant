using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO

{
    public class NhanVien_DAO
    {
        public static DataTable DocNhanVien()
        {
            Provider provider = new Provider();
            string str_sql = "select MaNV,TenNV,TenNH,TenLoai,nv.sdt";
            str_sql += " from NhanVien nv,LoaiNV lnv,NhaHang nh";
            str_sql += " where nv.Maloai=lnv.MaLoai and nv.MaNH=nh.MaNH";
            SqlCommand cm = provider.CreateCommandStringSql(str_sql);
            DataTable tb = new DataTable();
            return provider.ExecSelectCommand(cm);
        }
        public static DataTable DocNhanVienTheoUsername(string username)
        {
            Provider provider = new Provider();
            string str_sql = "select * from NhanVien where Username = '" + username + "'";
            SqlCommand cm = provider.CreateCommandStringSql(str_sql);
            return provider.ExecSelectCommand(cm);
        }

        public static DataTable LayLoaiNhanVien()
        {
            Provider provider = new Provider();
            string sql = "select * from LoaiNV";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            DataTable tb = new DataTable();
            return provider.ExecSelectCommand(cm);
        }

        public static DataTable LayNhaHang()
        {
            Provider provider = new Provider();
            string sql = "select MaNH,TenNH from NhaHang";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            DataTable tb = new DataTable();
            return provider.ExecSelectCommand(cm);
        }

        public static int ThemNhanVien(NhanVien_DTO NhanVien)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into NhanVien values (N'{0}','{1}','{2}',{3},{4})", NhanVien.TenNV, NhanVien.MaNH, NhanVien.MaLoaiNhanVien, NhanVien.Cmnd, NhanVien.Sdt);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int CapNhatNhanVien(NhanVien_DTO NhanVien, int MaNV)
        {
            Provider provider = new Provider();
            string sql = string.Format("update NhanVien set TenNV=N'{0}',sdt={1} where MaNV={2}", NhanVien.TenNV, NhanVien.Sdt, MaNV);
            SqlCommand cm=provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaNhanVien(int MaNV)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete NhanVien where MaNV={0}", MaNV);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);

        }
    }
}
