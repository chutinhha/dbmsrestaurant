﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietNCC_DAO:VProvider
    {
        public ChiTietNCC_DAO():base() { }
        public int InsertChiTietNCC( int MaNL, int MaNCC, double Gia)
        {
            String store = "InsertChiTietNCC";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@Gia", SqlDbType.Float);

            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@Gia"].Value = Gia;
            return  ExecuteInsertUpdateDelete();
        }
        public int UpdateChiTietNCC(int MaNL, int MaNCC, double Gia)
        {
            String store = "UpdateChiTietNCC";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@Gia", SqlDbType.Float);

            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNCC"].Value = MaNCC;
            cm.Parameters["@Gia"].Value = Gia;
            return ExecuteInsertUpdateDelete();
        }
        public int DeleteChiTietNCC_fromNCC( int MaNCC)
        {
            String store = "DeleteChiTietNCC_fromNCC";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);

            cm.Parameters["@MaNCC"].Value = MaNCC;

            return ExecuteInsertUpdateDelete();
        }
        public int DeleteChiTietNCC(int MaNL, int MaNCC)
        {
            String store = "DeleteChiTietNCC";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaNL", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);


            cm.Parameters["@MaNL"].Value = MaNL;
            cm.Parameters["@MaNCC"].Value = MaNCC;

            return ExecuteInsertUpdateDelete();
        }
        private List<VChiTietNCC_DTO> ConvertToList(DataTable dt)
        {
            List<VChiTietNCC_DTO> ls = new List<VChiTietNCC_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                VChiTietNCC_DTO ct = new VChiTietNCC_DTO();
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
