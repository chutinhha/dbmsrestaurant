using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class MonAn_DAO
    {
        Provider provider;
        public MonAn_DAO()
        {
            provider = new Provider();
        }
        
        public static  DataTable DocMonAn()
        {
            Provider provider=new Provider();
            string str_sql = "select MaMon, TenMon,TenLoai,Gia,DonViTinh,TenNH";
            str_sql+= " from MonAn m,LoaiMonAn lm,NhaHang nh";
            str_sql+= " where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH";
            SqlCommand cm = provider.CreateCommandStringSql(str_sql);
            DataTable tb = new DataTable();
            return provider.ExecSelectCommand(cm);
        }
        public static int XoaMonAn(string maMon)
        {
            return 0;
        }

        public static int ThemMonAn(MonAn_DTO MonAn)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values ('{0}','{1}','{2}','{3}','{4}')", MonAn.tenmon, MonAn.Loaimon, MonAn.Gia, MonAn.Dvtinh, MonAn.Manh);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static DataTable LayLoaiMon()
        {
            Provider provider = new Provider();
            // DataTable tbLoaiMonAn = new DataTable();
            string sql = "select MaLoai,TenLoai from LoaiMonAn";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }

        public static DataTable LayNhaHang()
        {
            Provider provider = new Provider();
            // DataTable tbLoaiMonAn = new DataTable();
            string sql = "select * from NhaHang";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }

        public static int CapNhatMonAn(MonAn_DTO MonAn, int maMonAn)
        {
            Provider provider = new Provider();
            //chua xu ly nha hang
            string sql = string.Format("update MonAn set TenMon=N'{0}',Gia='{1}',DonViTinh='{2}' where MaMon='{3}'", MonAn.tenmon, MonAn.Gia, MonAn.Dvtinh, maMonAn);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaMonAn(int maMonAn)
        {
            Provider provider = new Provider();
            //chua xu ly nha hang
            string sql = string.Format("delete MonAn  where MaMon={0}", maMonAn);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public DataTable SelectMonAnTheoLoai(String maloai, String manh)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_SelectMonAnTheoLoai");
            cm.Parameters.Add("@maloai", SqlDbType.NChar);
            cm.Parameters.Add("@manh", SqlDbType.NChar);
            cm.Parameters["@maloai"].Value = maloai;
            cm.Parameters["@manh"].Value = manh;
            return provider.ExecSelectCommand(cm);
        }
    }
}
