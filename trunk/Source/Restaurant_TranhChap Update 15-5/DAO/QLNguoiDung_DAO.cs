using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class QLNguoiDung_DAO
    {
        Provider provider;
        public QLNguoiDung_DAO()
        {
            provider = new Provider();
        }

        public int SelectUser(string username, string pass)
        {
            SqlCommand cm = provider.CreateCommandStoreName("sp_SelectUser");
            cm.Parameters.Add("@username", SqlDbType.NVarChar);
            cm.Parameters.Add("@pass", SqlDbType.NVarChar);
            cm.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.Output;

            cm.Parameters["@username"].Value = username;
            cm.Parameters["@pass"].Value = pass;
            provider.ExecSelectCommand(cm);
            return (int)cm.Parameters["@kq"].Value;
        }
    }
}
