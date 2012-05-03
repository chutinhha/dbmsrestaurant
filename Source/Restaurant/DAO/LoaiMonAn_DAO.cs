using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
   public class LoaiMonAn_DAO
    {
      
        public static DataTable DocLoaiMonAn()
        {
            Provider provider = new Provider();
            DataTable tbLoaiMonAn = new DataTable();
            string sql = "select MaLoai,TenLoai from LoaiMonAn";
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static int CapNhatLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            Provider provider = new Provider();
            string sql = string.Format("update LoaiMonAn set TenLoai=N'{0}' where MaLoai='{1}'", loaiMonAn.Tenloai, loaiMonAn.Maloai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public static int XoatLoaiMonAn(string ma)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete LoaiMonAn where MaLoai='{0}'",ma);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public static int ThemLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into LoaiMonAn values('{0}',N'{1}')",loaiMonAn.Maloai,loaiMonAn.Tenloai);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
