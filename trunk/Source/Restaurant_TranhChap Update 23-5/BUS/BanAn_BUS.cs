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
    public class BanAn_BUS
    {
        public static List<BanAn_DTO> selectBanAnTheoTrangThai(int trangthai, int manh, int mode)
        {
            BanAn_DAO bananDAO = new BanAn_DAO();
            return bananDAO.SelectBanAnTheoTrangThai(trangthai, manh, mode);
        }

        public static void UpdateTrangThaiBanAn(int maban, int trangthai)
        {
            BanAn_DAO dao = new BanAn_DAO();
            dao.UpdateTrangThaiBanAn(maban, trangthai);
        }

        public static DataTable DocBanAn(String maNH)
        {
            return BanAn_DAO.DocBanAn(maNH);
        }

        public static int ThemBanAn(BanAn_DTO BanAn, string maNH)
        {
            return BanAn_DAO.ThemBanAn(BanAn, maNH);
        }

        public static int CapNhatBanAn(BanAn_DTO BanAn)
        {
            return BanAn_DAO.CapNhatBanAn(BanAn);
        }

        public static int XoaBanAn(string maBan)
        {
            return BanAn_DAO.XoaBanAn(maBan);
        }


    }
}
