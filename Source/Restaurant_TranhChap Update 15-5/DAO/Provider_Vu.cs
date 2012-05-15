using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class Provider_Vu
    {
        string _connectionString = @"Server=MinhVu-LapTop\SQLExpress; DataBase=QLNhaHang ; Integrated Security=SSPI ";
        SqlConnection _cnn;
        SqlCommand _cm;
        SqlTransaction _tran;
        #region "Properties"
        public SqlConnection Connection
        {
            get { return _cnn; }
            set { _cnn = value; }
        }
        public SqlCommand Command
        {
            get { return _cm; }
            set { _cm = value; }
        }
        public SqlTransaction Transaction
        {
            get { return _tran; }
            set { _tran = value; }
        }
        #endregion
        public Provider_Vu()
        {
            _cnn = new SqlConnection(_connectionString);
            
        }

        public void OpenConnection()
        {
            _cnn.Open();
        }
        public void CloseConnection()
        {
            _cnn.Close();
        }
        public void BeginTransaction()
        {
            _tran = _cnn.BeginTransaction();
            _cm.Transaction = _tran;
        }
        public void CommitTransaction()
        {
            _tran.Commit();
        }
        public void CreateCommand()
        {
            _cm = _cnn.CreateCommand();
        }
        public void CreateCommand_StringSql(string sql)
        {
            
            _cm.CommandType = System.Data.CommandType.Text;
            _cm.CommandText = sql;
        }
        public void CreateCommand_StoreName(string StoreName)
        {
            _cm.CommandType = System.Data.CommandType.StoredProcedure;
            _cm.CommandText = StoreName;
        }

        /*  flag_connec = -1  => no open no close
         *  flag_connec = 0 => only close connection
         *  flag_connec = 1 => only open connection
         *  flag_connec = 2 => open connection and close connection
         *  flag_tran = -1 => normal
         *  flag_tran = 1 => only begin tran
         *  flag_tran = 0 => only commic
         */
        public DataTable ExecSelectCommand(int flag_connec,int flag_tran)
        {
            DataTable table = new DataTable();
            if(flag_connec ==2 )
                OpenConnection();
            if (flag_connec == 1)
            {
                //_cm.CommandTimeout = 10000;
                OpenConnection();

            }
            if (flag_tran == 1)
                BeginTransaction();

            SqlDataReader read = _cm.ExecuteReader();
            table.Load(read);
            read.Close();

            if (flag_tran == 0)
                CommitTransaction();
            if (flag_connec == 2 || flag_connec == 0)
                    _cm.Connection.Close();

            return table;
        }

        public int ExecuteInsertUpdateDelete(int flag_connec, int flag_tran)
        {
            if (flag_connec == 2 || flag_connec == 1)
                OpenConnection();
            if (flag_tran == 1)
                BeginTransaction();

            int flag = _cm.ExecuteNonQuery();

            if (flag_tran == 0)
                CommitTransaction();
            if (flag_connec == 2 || flag_connec == 0)
                _cm.Connection.Close();

            return flag;

        }
    }
}
