using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietDatHang_DAO
    {
        Provider provider;
        Provider_Vu _provider;
        public Provider_Vu Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public ChiTietDatHang_DAO()
        {
            provider = new Provider();
            _provider = new Provider_Vu();
        }

        public List<ChiTietDatHang_DTO> SelectChiTietDatDang(int MaHoaDon)
        {
            String store = "SelectChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            return ConvertToList(provider.ExecSelectCommand(cm));
        }
        public int InsertChiTietDatHang(int flag_connec, int flag_tran,ChiTietDatHang_DTO ctdh)
        {
            String store = "InsertChiTietDatHang";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNL", SqlDbType.Int);
            _provider.Command.Parameters.Add("@SoLuong", SqlDbType.Int);
            _provider.Command.Parameters.Add("@ThanhTien", SqlDbType.Float);

            _provider.Command.Parameters["@MaHoaDon"].Value = ctdh.MaHoaDon;
            _provider.Command.Parameters["@MaNL"].Value = ctdh.MaNL;
            _provider.Command.Parameters["@SoLuong"].Value = ctdh.SoLuong;
            _provider.Command.Parameters["@ThanhTien"].Value = ctdh.ThanhTien;

            return _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
        }
        public int DeleteChiTietDatDang(int MaHoaDon)
        {
            String store = "DeleteChiTietDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;

            return provider.ExecuteInsertUpdateDelete(cm);
        }
        private List<ChiTietDatHang_DTO> ConvertToList(DataTable dt)
        {
            List<ChiTietDatHang_DTO> ls = new List<ChiTietDatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                ChiTietDatHang_DTO ct = new ChiTietDatHang_DTO();
                ct.MaHoaDon = (int)row.ItemArray[0];
                ct.MaNL = (int)row.ItemArray[1];
                ct.SoLuong = (int)row.ItemArray[2];
                ct.ThanhTien = (Double)row.ItemArray[3];
                ct.TenNL = row.ItemArray[4].ToString();
                ct.DonVi= row.ItemArray[5].ToString();
                ls.Add(ct);
            }
            return ls;
        }
    }
}
