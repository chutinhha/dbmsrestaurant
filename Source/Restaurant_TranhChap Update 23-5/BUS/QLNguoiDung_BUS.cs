using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace BUS
{
    public class QLNguoiDung_BUS
    {
        public static int SelectUser(string username, string pass)
        {
            QLNguoiDung_DAO dao = new QLNguoiDung_DAO();
            return dao.SelectUser(username, pass);
        }
    }
}
