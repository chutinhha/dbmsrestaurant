using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    class Provider
    {
        public string str_connection=" ";

        public SqlCommand CreateCommand(string sql)
        {
            SqlConnection cnn = new SqlConnection(str_connection);
            SqlCommand cm = cnn.CreateCommand();

            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            return cm;
        }


        
    }
}
