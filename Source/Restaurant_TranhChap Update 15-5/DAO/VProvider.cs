using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class VProvider
    {
        protected string connectionString = @"Server=MinhVu-LapTop\SQLExpress; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        protected SqlConnection cnn;
        protected SqlCommand cm;
        protected SqlTransaction tran;
        protected SqlDataReader read;
        protected SqlDataAdapter adapter;
        #region "Properties"
        public SqlConnection Connection
        {
            get { return cnn; }
            set { cnn = value; }
        }
        public SqlCommand Command
        {
            get { return cm; }
            set { cm = value; }
        }
        public SqlTransaction Transaction
        {
            get { return tran; }
            set { tran = value; }
        }
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        #endregion
        public VProvider()
        {
            cnn = new SqlConnection(connectionString);
        }
        public VProvider(VProvider p)
        {
            connectionString = p.connectionString;
            cnn = p.cnn;
            cm = p.cm;
            tran = p.tran;
        }
        public void Copy(VProvider p)
        {
            connectionString = p.connectionString;
            cnn = p.cnn;
            cm = p.cm;
            tran = p.tran;
        }
        public void OpenConnection()
        {
            cnn.Open();
           
        }
        public void CloseConnection()
        {
            cnn.Close();
        }
        public void BeginTransaction()
        {
            OpenConnection();
            tran = cnn.BeginTransaction();
            cm.Connection = cnn;
            cm.Transaction = tran;
        }
        public void CommitTransaction()
        {
            tran.Commit();
            CloseConnection();
        }
        public void CreateCommand_StringSql(string sql)
        {
            if (cnn.State != ConnectionState.Open)
                cm = cnn.CreateCommand();
            cm.Parameters.Clear();
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
        }
        public void CreateCommand_StoreName(string StoreName)
        {
            if (cnn.State != ConnectionState.Open)
                cm = cnn.CreateCommand();
            cm.Parameters.Clear();
            cm.CommandType = System.Data.CommandType.StoredProcedure;
            cm.CommandText = StoreName;
        }

        public DataTable ExecSelectCommand()
        {
            int flag = 0;   
            if (cnn.State != ConnectionState.Open)
            {
                OpenConnection();
                flag = 1;
            }

            DataTable table = new DataTable();
            
            read = cm.ExecuteReader();
            table.Load(read);
            read.Close();

            if (flag == 1)
                CloseConnection();

            return table;
        }
   
        public DataSet FillDataSet()
        {
            int flag = 0;
            if (cnn.State != ConnectionState.Open)
            {
                OpenConnection();
                flag = 1;
            }

            List<DataTable> lsData = new List<DataTable>();
            adapter = new SqlDataAdapter(cm);
            
            DataSet dtset = new DataSet();
            adapter.Fill(dtset);
  

            if (flag == 1)
                CloseConnection();

            return dtset;
        }
        public int ExecuteInsertUpdateDelete()
        {
            int flag = 0;
            if (cnn.State != ConnectionState.Open)
            {
                OpenConnection();
                flag = 1;
            }

            int result = cm.ExecuteNonQuery();

            if (flag == 1)
                CloseConnection();

            return result;

        }
    }
}
