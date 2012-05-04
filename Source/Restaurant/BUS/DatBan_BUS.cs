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
        public static int ThemDatBan(DatBan_DTO banDat)
        {
            return DatBan_DAO.ThemDatBan(banDat);
        }
    }
}
