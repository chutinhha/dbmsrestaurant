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
        
        //public static  DataTable DocMonAn(string maNH)
        //{
        //    Provider provider=new Provider();
        //    string str_sql = "select MaMon, TenMon,TenLoai,Gia,DonViTinh,TenNH";
        //    str_sql+= " from MonAn m,LoaiMonAn lm,NhaHang nh";
        //    str_sql+= " where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and nh.MaNH="+maNH;
        //    SqlCommand cm = provider.CreateCommandStringSql(str_sql);
        //    DataTable tb = new DataTable();
        //    return provider.ExecSelectCommand(cm);
        //}

        public static DataTable DocMonAn(int mode,string maNH)
        {
            Provider provider = new Provider();
			string store = "sp_DocMonAn";
            if (mode == 3)
                store = "sp_DocMonAn_Fix";
			
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaNH", SqlDbType.VarChar, 5);
            cm.Parameters["@MaNH"].Value = maNH;
            return provider.ExecSelectCommand(cm);
        }

        

        //public DataTable DocMonAn_commit(string maNH)
        //{
        //    string sql = "select MaMon,TenMon,TenLoai,Gia,DonViTinh ";
        //    sql+="from MonAn m,LoaiMonAn lm,NhaHang nh";
        //    sql += "where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =" + maNH+" commit tran";
        //    provider.cm = provider.CreateCommandStringSql(sql);
        //    return provider.ExecSelectCommand_CloseConnection(provider.cm);
            
        //}
        
        public static int XoaMonAn(string maMon)
        {
            return 0;
        }

        public static int ThemMonAn(int mode,MonAn_DTO MonAn,string maNH)
        {
            Provider provider = new Provider();
            string  store="sp_ThemMonAn";
            
            if(mode==3)
                store = "sp_ThemMonAn_Fix";
            //string sql = string.Format("insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values ('{0}','{1}','{2}','{3}','{4}')", MonAn.tenmon, MonAn.Mamon, MonAn.Gia, MonAn.Dvtinh,maNH);
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@TenMon", SqlDbType.NVarChar,50);
            cm.Parameters.Add("@LoaiMon", SqlDbType.NChar, 20);
            cm.Parameters.Add("@Gia", SqlDbType.Int);
            cm.Parameters.Add("@DonViTinh", SqlDbType.NVarChar, 20);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar, 5);

            cm.Parameters["@TenMon"].Value = MonAn.tenmon;
            cm.Parameters["@LoaiMon"].Value = MonAn.Mamon;
            cm.Parameters["@Gia"].Value = MonAn.Gia;
            cm.Parameters["@DonViTinh"].Value = MonAn.Dvtinh;
            cm.Parameters["@MaNH"].Value = maNH;
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

        public static int CapNhatMonAn(int mode,MonAn_DTO MonAn, int maMonAn)
        {
            Provider provider = new Provider();
			string store="sp_CapNhatMonAn";
            if(mode==3)
                store = "sp_CapNhatMonAn_Fix";
            //chua xu ly nha hang
           // string sql = string.Format("update MonAn set TenMon=N'{0}',Gia='{1}',DonViTinh='{2}' where MaMon='{3}' and MaNH='{4}'", MonAn.tenmon, MonAn.Gia, MonAn.Dvtinh, maMonAn,maNH);
	
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@TenMon", SqlDbType.NVarChar, 50);
            cm.Parameters.Add("@gia", SqlDbType.Money);
            cm.Parameters.Add("@DVTinh", SqlDbType.NVarChar, 10);
            cm.Parameters.Add("@MaMon", SqlDbType.Int);

            cm.Parameters["@TenMon"].Value = MonAn.tenmon;
            cm.Parameters["@gia"].Value = MonAn.Gia;
            cm.Parameters["@DVTinh"].Value = MonAn.Dvtinh;
            cm.Parameters["@MaMon"].Value = maMonAn;
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int CapNhatMonAn_Commit(MonAn_DTO MonAn, int maMonAn)
        {
            Provider provider = new Provider();
            string sql = string.Format("update MonAn set TenMon=N'{0}',Gia='{1}',DonViTinh='{2}' where MaMon='{3}'", MonAn.tenmon, MonAn.Gia, MonAn.Dvtinh, maMonAn);
            sql += " commit tran";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaMonAn(int mode,int maMonAn)
        {
            Provider provider = new Provider();
            //chua xu ly nha hang
           // string sql = string.Format("delete MonAn  where MaMon={0}", maMonAn);
		   string  store= "sp_XoaMonAn";
           if(mode==3)
               store = "sp_XoaMonAn_Fix";
		   
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maMon", SqlDbType.Int);
            cm.Parameters["@maMon"].Value = maMonAn;
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

        public static DataTable TimTheoLoai(int mode,string maLoai, string MaNH,ref int sl)
        {
            Provider provider = new Provider();
			string store="sp_TimTheoLoai";
            if(mode==3)
                store = "sp_TimTheoLoai_Fix";

            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maLoai", SqlDbType.VarChar, 5);
            cm.Parameters.Add("@maNH", SqlDbType.VarChar, 5);
            cm.Parameters.Add("@dem", SqlDbType.Int);

            cm.Parameters["@maLoai"].Value = maLoai;
            cm.Parameters["@maNH"].Value = MaNH;
            
            cm.Parameters["@dem"].Direction = ParameterDirection.Output;
            string name="@dem";
            return provider.ExecSelectCommand_Output(cm, name,ref sl);
        }
    }
}
