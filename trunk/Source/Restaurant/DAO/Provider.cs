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
        public string str_connection = @"Server=PC\SQLSEVER; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        //public string str_connection = @"Server=MinhVu-LapTop\SQLExpress; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        public SqlConnection cnn;
        //public string str_connection = @"Server=.\SQLExpress; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        public SqlCommand cm;
        //public SqlTransaction trans;
        public Provider()
        {
        }
        public Provider(SqlCommand cm)
        {
            this.cm = cm;
        }
        public SqlCommand CreateCommandStringSql(string sql)
        {
            if(cnn==null)
                cnn = new SqlConnection(str_connection);
            cm = cnn.CreateCommand();
            //cnn.Open();
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            return cm;
        }
        public SqlCommand CreateCommand_CommitTran(string sql)
        {
            //if (cnn == null)
            //    cnn = new SqlConnection(str_connection);
            //cm = cnn.CreateCommand();
            //cnn.Open();
            try
            {
                cm.CommandType = System.Data.CommandType.Text;
                cm.CommandText = sql;
            }
            catch { }
            return cm;
        }
        public SqlCommand CreateCommandStoreName(string StoreName)
        {
            cnn = new SqlConnection(str_connection);
            cm = cnn.CreateCommand();
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
                if(cm.Connection.State== ConnectionState.Closed)
                    cm.Connection.Open();
                int flag = cm.ExecuteNonQuery();
                if(cm.Connection.State== ConnectionState.Open)
                    cm.Connection.Close();
                return flag;
            }
            catch
            {
                return 0;
            }
            
        }
        public DataTable ExecSelectCommand_OpenConnection(SqlCommand cm)
        {
            DataTable table = new DataTable();
            if(cm.Connection.State!=ConnectionState.Open)
                cm.Connection.Open();
            SqlDataReader read = cm.ExecuteReader();
            table.Load(read);
            read.Close();
           // cm.Connection.Close();
            return table;
        }
        public DataTable ExecSelectCommand_CloseConnection(SqlCommand cm)
        {
            DataTable table = new DataTable();
          //  cm.Connection.Open();
            SqlDataReader read = cm.ExecuteReader();
            table.Load(read);
            read.Close();
             cm.Connection.Close();
            return table;
        }
        public int ExecuteInsertUpdateDelete_CloseConnection(SqlCommand cm)
        {
            //try
            //{
                //cm.Connection.Open();
                int flag = cm.ExecuteNonQuery();
                cm.Connection.Close();
                return flag;
            //}
            //catch
            //{
            //    return 0;
            //}

        }
       
     
    }
}
