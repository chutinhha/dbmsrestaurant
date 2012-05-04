using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DatBan_DAO
    {
        public static DataTable DocBanTrong(int maNH)
        {
            Provider provider = new Provider();
            DataTable tb = new DataTable();
            string sql = "select b.MaBan,k.TenKhuVuc,k.ViTri,lb.SucChua";
            sql += " from BanAn b,KhuVuc k,NhaHang n,LoaiBan lb";
            sql += " where b.MaKhuVuc=k.MaKhuVuc and b.LoaiBan=lb.MaLoai and n.MaNH="+maNH;
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecSelectCommand(cm);
        }
        public static int ThemDatBan(DatBan_DTO bandat)
        {
            Provider provider = new Provider();
            DateTime t = DateTime.Parse(bandat.ThoiGianDen);
            bandat.ThoiGianDen = t.ToString("MM/dd/yyyy");
            string sql = string.Format("insert into DatBan values({0},{1},{2},'{3}',{4},'{5}')",bandat.MaNH,bandat.MaBan,0,DateTime.Now.ToString("MM/dd/yyyy"),0,bandat.ThoiGianDen);//0 ban dat
            SqlCommand cm = provider.CreateCommandStringSql(sql);
            return provider.ExecuteInsertUpdateDelete(cm);
        }
    }
}
