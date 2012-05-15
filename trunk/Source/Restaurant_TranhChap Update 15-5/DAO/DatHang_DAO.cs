using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DatHang_DAO
    {
        Provider provider;
        Provider_Vu _provider;
        public Provider_Vu Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public DatHang_DAO()
        {
            provider = new Provider();
            _provider = new Provider_Vu();
        }
      
        public List<DatHang_DTO> SelectDatHang(String MaNH)
        {
            String store = "SelectDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return  ConvertToList(provider.ExecSelectCommand(cm));
        }
        public int InsertDatHang(int flag_connec, int flag_tran,DatHang_DTO dh)
        {
            String store = "InsertDatHang";
            if (flag_connec == 2 || flag_connec == 1)
                _provider.CreateCommand();
            _provider.Command.Parameters.Clear();
            _provider.CreateCommand_StoreName(store);
            _provider.Command.Parameters.Add("@MaHoaDon", SqlDbType.Int).Direction = ParameterDirection.Output;
            _provider.Command.Parameters.Add("@MaNCC", SqlDbType.Int);
            _provider.Command.Parameters.Add("@MaNH", SqlDbType.NChar);
            _provider.Command.Parameters.Add("@TongTien", SqlDbType.Float);
            _provider.Command.Parameters.Add("@ThoiGianDat", SqlDbType.DateTime);
            _provider.Command.Parameters.Add("@ThoiGianGiao", SqlDbType.DateTime);
            _provider.Command.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            _provider.Command.Parameters["@MaNCC"].Value = dh.MaNCC;
            _provider.Command.Parameters["@MaNH"].Value = dh.MaNH;
            _provider.Command.Parameters["@TongTien"].Value = dh.TongTien;
            _provider.Command.Parameters["@ThoiGianDat"].Value = dh.ThoiGianDat;
            _provider.Command.Parameters["@ThoiGianGiao"].Value = dh.ThoiGianGiao;
            _provider.Command.Parameters["@TinhTrang"].Value = dh.TinhTrang;

            _provider.ExecuteInsertUpdateDelete(flag_connec,flag_tran);
            return (int)_provider.Command.Parameters["@MaHoaDon"].Value;
        }
        public int UpdatetDatHang(DatHang_DTO dh)
        {
            String store = "UpdateDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TongTien", SqlDbType.Float);
            cm.Parameters.Add("@ThoiGianDat", SqlDbType.DateTime);
            cm.Parameters.Add("@ThoiGianGiao", SqlDbType.DateTime);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            cm.Parameters["@MaHoaDon"].Value = dh.MaHoaDon;
            cm.Parameters["@MaNCC"].Value = dh.MaNCC;
            cm.Parameters["@MaNH"].Value = dh.MaNH;
            cm.Parameters["@TongTien"].Value = dh.TongTien;
            cm.Parameters["@ThoiGianDat"].Value = dh.ThoiGianDat;
            cm.Parameters["@ThoiGianGiao"].Value = dh.ThoiGianGiao;
            cm.Parameters["@TinhTrang"].Value = dh.TinhTrang;

            return provider.ExecuteInsertUpdateDelete(cm);
        }
        public int DeleteDatHang(int MaHoaDon)
        {
            String store = "DeleteDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;

            return provider.ExecuteInsertUpdateDelete(cm);
        }
        private List<DatHang_DTO> ConvertToList(DataTable dt)
        {
            List<DatHang_DTO> ls = new List<DatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                DatHang_DTO ttdh = new DatHang_DTO();
                ttdh.MaHoaDon = (int)row.ItemArray[0];
                ttdh.MaNCC = (int)row.ItemArray[1];
                ttdh.MaNH = row.ItemArray[2].ToString();
                ttdh.TongTien = (double)row.ItemArray[3];
                try
                {
                    ttdh.ThoiGianDat = DateTime.Parse(row.ItemArray[4].ToString());
                }
                catch (Exception)
                {
                    ttdh.ThoiGianDat = new DateTime();
                }
                try
                {
                    ttdh.ThoiGianGiao =  DateTime.Parse(row.ItemArray[5].ToString());
                }
                catch (Exception)
                {
                    ttdh.ThoiGianGiao = new DateTime();
                }
                ttdh.TinhTrang = row.ItemArray[6].ToString();
                ttdh.TenNCC = row.ItemArray[7].ToString();
                ls.Add(ttdh);
            }
            return ls;
        }
    }
}
