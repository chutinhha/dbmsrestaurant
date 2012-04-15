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
        public DataTable DocMonAn()
        {
            MonAn_DAO moan = new MonAn_DAO();
            return moan.DocMonAn();
        }
    }
}
