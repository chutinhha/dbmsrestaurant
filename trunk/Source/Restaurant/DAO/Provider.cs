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
        public string str_connection = @"Server=PC\SQLSEVER; DataBase=QLNhaHanga ; Integrated Security=SSPI ";
        public SqlConnection cnn;
        public SqlTransaction trans;
        public SqlCommand cm;

        public SqlCommand CreateCommand(string sql)
        {
            cnn = new SqlConnection(str_connection);
            SqlCommand cm = cnn.CreateCommand();
            cnn.Open();
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            return cm;
        }
        public SqlCommand CreateCommand(ref SqlConnection cnn, ref SqlTransaction transaction, string sql, IsolationLevel iso)
        {
            cnn = new SqlConnection(str_connection);
            SqlCommand cm = cnn.CreateCommand();
            cnn.Open();
            cnn.BeginTransaction(iso);
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            return cm;
        }
     
    }
}
