using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DatBan_BUS
    {
        public static DataTable DocBanTrong(int maNH)
        {
            return DatBan_DAO.DocBanTrong(maNH);
        }
        public static DataTable DocKhuVuc(int maNH)
        {
            return DatBan_DAO.DocKhuVuc(maNH);
        }
        public static DataTable DocLoaiBan()
        {
            return DatBan_DAO.DocLoaiBan();
        }
        public static int ThemDatBan(DatBan_DTO banDat)
        {
            return DatBan_DAO.ThemDatBan(banDat);
        }
        public static DataTable DocDanhSachBanDat(int maNH,string maBan,string khuVuc,string sucChua,string trangThai)
        {
            return DatBan_DAO.DocDanhSachBanDat(maNH, maBan, khuVuc, sucChua, trangThai);
        }
        public static int UpdateDatBan(DatBan_DTO bandat,string maBan,string maNH,string thoigianden)
        {
            return DatBan_DAO.UpdateDatBan(bandat,maBan,maNH,thoigianden);
        }
        public static int XoaDatBan(DatBan_DTO bandat)
        {
            return DatBan_DAO.XoaDatBan(bandat);
        }
    }
}
