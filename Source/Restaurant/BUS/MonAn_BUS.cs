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
    public class MonAn_BUS
    {
        public static DataTable DocMonAn()
        {
            return MonAn_DAO.DocMonAn();
        }
    }
}
