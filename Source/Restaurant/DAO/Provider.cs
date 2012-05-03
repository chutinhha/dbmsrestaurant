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
       //public string str_connection = @"Server=PC\SQLSEVER; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        public string str_connection = @"Server=MinhVu-LapTop\SQLExpress; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        public SqlConnection cnn;
        //public SqlTransaction trans;

        public SqlCommand CreateCommandStringSql(string sql)
        {
            cnn = new SqlConnection(str_connection);
            SqlCommand cm = cnn.CreateCommand();
            //cnn.Open();
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            return cm;
        }
        public SqlCommand CreateCommandStoreName(string StoreName)
        {
            cnn = new SqlConnection(str_connection);
            SqlCommand cm = cnn.CreateCommand();
            //cnn.Open();
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.CommandText = StoreName;
            return cm;
        }
        public DataTable ExecSelectCommand(SqlCommand cm)
        {
            DataTable table = new DataTable();
            cm.Connection.Open();
            SqlDataReader read = cm.ExecuteReader();
            table.Load(read);
            read.Close();
            cm.Connection.Close();
            return table;
        }
        public int ExecuteInsertUpdateDelete(SqlCommand cm)
        {
            try
            {
                cm.Connection.Open();
                int flag = cm.ExecuteNonQuery();
                cm.Connection.Close();
                return flag;
            }
            catch
            {
                return 0;
            }
            
        }
        
       
     
    }
}
