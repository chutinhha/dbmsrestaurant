using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class LoaiNhanVien_DAO
    {
        public static DataTable DocLoaiNV()
        {
            Provider provider = new Provider();
            string str_sql = "select MaLoai, TenLoai";
            str_sql += " from LoaiNV";

            SqlCommand cm = provider.CreateCommandStringSql(str_sql);
            DataTable tb = new DataTable();
            return provider.ExecSelectCommand(cm);
        }

        public static int ThemLoaiNV(LoaiNhanVien_DTO loaiNV)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into LoaiNV(MaLoai,TenLoai,Luong) values ('{0}','{1}',{2})", loaiNV.MaLoaiNV,loaiNV.TenLoaiNV, loaiNV.Luong);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int KiemTraMaLoai(string maLoai)
        {
            Provider provider = new Provider();
            string sql = string.Format("select * from LoaiNV where MaLoai={0}", maLoai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            DataTable tb = new DataTable();
            tb = provider.ExecSelectCommand(cm);
            if (tb.Rows.Count > 0)
            {
                return 1;
            }
            return 0;
        }

        public static int KiemTraTenLoai(string tenLoai)
        {
            Provider provider = new Provider();
            string sql = string.Format("select * from LoaiNV where TenLoai like 'N{0}'", tenLoai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            DataTable tb = new DataTable();
            tb = provider.ExecSelectCommand(cm);
            if (tb.Rows.Count > 0)
            {
                return 1;
            }
            return 0;
        }

        public static int CapNhatLoaiNhanVien(LoaiNhanVien_DTO loaiNV)
        {
            Provider provider = new Provider();
            string sql = string.Format("update LoaiNV set TenLoai=N'{0}' where MaLoai='{1}'", loaiNV.TenLoaiNV, loaiNV.MaLoaiNV);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaLoaiNhanVien(string maLoai)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete LoaiNV where MaLoai='{0}'", maLoai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

    }
}
