using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class LoaiBanAn_DAO
    {
        public static DataTable DocLoaiBanAn()
        {
            Provider provider = new Provider();
            string sql = "select * from LoaiBan";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }

        public static int ThemLoaiBanAn(LoaiBanAn_DTO LoaiBA)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into LoaiBan values ('{0}',{1})", LoaiBA.MaLoai, LoaiBA.SucChua);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int CapNhatLoaiBA(LoaiBanAn_DTO loaiBA)
        {
            Provider provider = new Provider();
            string sql = string.Format("update LoaiBan set SucChua={0} where Maloai='{1}'", loaiBA.SucChua,loaiBA.MaLoai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaLoaiBanAn(string maLoai)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete LoaiBan where Maloai='{0}'", maLoai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
