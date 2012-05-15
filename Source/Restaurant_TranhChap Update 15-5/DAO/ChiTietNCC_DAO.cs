using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietNCC_DAO
    {
        Provider provider ;
        Provider_Vu _provider;
        public ChiTietNCC_DAO()
        {
            provider = new Provider();
            _provider = new Provider_Vu();
        }
        public Provider_Vu Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public int InsertChiTietNCC(int flag_connec, int flag_tran, int MaNL, int MaNCC, double Gia)
        {
            String store = "InsertChiTietNCC";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNL", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@Gia", SqlDbType.Float);

            _provider.Command.Parameters["@MaNL"].Value = MaNL;
            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;
            _provider.Command.Parameters["@Gia"].Value = Gia;
            return  _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
        }
        public int UpdateChiTietNCC(int flag_connec, int flag_tran, int MaNL, int MaNCC, double Gia)
        {
            String store = "UpdateChiTietNCC";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNL", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@Gia", SqlDbType.Float);

            _provider.Command.Parameters["@MaNL"].Value = MaNL;
            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;
            _provider.Command.Parameters["@Gia"].Value = Gia;
            return _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
        }
        public int DeleteChiTietNCC_fromNCC(int flag_connec, int flag_tran, int MaNCC)
        {
            String store = "DeleteChiTietNCC_fromNCC";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);

            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;

            return _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
        }
        public int DeleteChiTietNCC(int flag_connec, int flag_tran,int MaNL, int MaNCC)
        {
            String store = "DeleteChiTietNCC";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaNL", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);


            _provider.Command.Parameters["@MaNL"].Value = MaNL;
            _provider.Command.Parameters["@MaNCC"].Value = MaNCC;

            return _provider.ExecuteInsertUpdateDelete(flag_connec, flag_tran);
        }
        private List<ChiTietNCC_DTO> ConvertToList(DataTable dt)
        {
            List<ChiTietNCC_DTO> ls = new List<ChiTietNCC_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietNCC_DTO ct = new ChiTietNCC_DTO();
                ct.MaNL= (int)row.ItemArray[0];
                ct.MaNCC = (int)row.ItemArray[1];
                ct.Gia = (Double)row.ItemArray[2];
                ct.TenNL = row.ItemArray[3].ToString();
                ct.TenNCC = row.ItemArray[4].ToString();
                ls.Add(ct);
            }
            return ls;
        }
    }
}
