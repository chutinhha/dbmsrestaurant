using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class KhuVuc_DAO
    {
        public static DataTable DocKhuVuc()
        {
            Provider provider = new Provider();
            string sql = "select * from KhuVuc";
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

        public static int ThemKhuVuc(KhuVuc_DTO KhuVuc, string maNH)
        {
            Provider provider = new Provider();
            string sql = string.Format("insert into KhuVuc values ({0},'{1}','{2}','{3}')", KhuVuc.MaKhuVuc, KhuVuc.TenKhuVuc, KhuVuc.ViTri, maNH);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int CapNhatKhuVuc(KhuVuc_DTO KhuVuc)
        {
            Provider provider = new Provider();
            string sql = string.Format("update KhuVuc set TenKhuVuc=N'{0}',ViTri=N'{1}' where MaKhuVuc={2}", KhuVuc.TenKhuVuc, KhuVuc.ViTri, KhuVuc.MaKhuVuc);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }

        public static int XoaKhuVuc(string maKhuVuc)
        {
            Provider provider = new Provider();
            string sql = string.Format("delete KhuVuc where MaKhuVuc={0}", maKhuVuc);
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
