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
        public static List<BanAn_DTO> selectBanAnTheoTrangThai(int trangthai, int manh)
        {
            BanAn_DAO bananDAO = new BanAn_DAO();
            return bananDAO.SelectBanAnTheoTrangThai(trangthai, manh);
        }

        public static void UpdateTrangThaiBanAn(int maban, int trangthai)
        {
            BanAn_DAO dao = new BanAn_DAO();
            dao.UpdateTrangThaiBanAn(maban, trangthai);
        }


    }
}
