using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class VDatHang_DAO:VProvider
    {
        public List<VDatHang_DTO> SelectDatHang(String MaNH)
        {
            String store = "SelectDatHang";
           CreateCommand_StoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return  ConvertToList(ExecSelectCommand());
        }
        public int InsertDatHang(VDatHang_DTO dh,DataTable ChiTiet)
        {
            String store = "InsertDatHang";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TongTien", SqlDbType.Float);
            cm.Parameters.Add("@ThoiGianDat", SqlDbType.DateTime);
            cm.Parameters.Add("@ThoiGianGiao", SqlDbType.DateTime);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);
            cm.Parameters.Add("@ChiTiet", SqlDbType.Structured);

            cm.Parameters["@MaNCC"].Value = dh.MaNCC;
            cm.Parameters["@MaNH"].Value = dh.MaNH;
            cm.Parameters["@TongTien"].Value = dh.TongTien;
            cm.Parameters["@ThoiGianDat"].Value = dh.ThoiGianDat;
            cm.Parameters["@ThoiGianGiao"].Value = dh.ThoiGianGiao;
            cm.Parameters["@TinhTrang"].Value = dh.TinhTrang;
            cm.Parameters["@ChiTiet"].Value = ChiTiet;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@MaHoaDon"].Value;
        }
        public int UpdatetDatHang(VDatHang_DTO dh, DataTable ChiTiet)
        {
            String store = "UpdateDatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TongTien", SqlDbType.Float);
            cm.Parameters.Add("@ThoiGianDat", SqlDbType.DateTime);
            cm.Parameters.Add("@ThoiGianGiao", SqlDbType.DateTime);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);
            cm.Parameters.Add("@ChiTiet", SqlDbType.Structured);

            cm.Parameters["@MaHoaDon"].Value = dh.MaHoaDon;
            cm.Parameters["@MaNCC"].Value = dh.MaNCC;
            cm.Parameters["@MaNH"].Value = dh.MaNH;
            cm.Parameters["@TongTien"].Value = dh.TongTien;
            cm.Parameters["@ThoiGianDat"].Value = dh.ThoiGianDat;
            cm.Parameters["@ThoiGianGiao"].Value = dh.ThoiGianGiao;
            cm.Parameters["@TinhTrang"].Value = dh.TinhTrang;
            cm.Parameters["@ChiTiet"].Value = ChiTiet;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        public int UpdatetTinhTrangDatHang(int MaHoaDon, String tinhtrang)
        {
            String store = "UpdateTinhTrangDatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            cm.Parameters["@TinhTrang"].Value = tinhtrang;
            return ExecuteInsertUpdateDelete();
        }
        public int DeleteDatHang(int MaHoaDon)
        {
            String store = "DeleteDatHang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        private List<VDatHang_DTO> ConvertToList(DataTable dt)
        {
            List<VDatHang_DTO> ls = new List<VDatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                VDatHang_DTO ttdh = new VDatHang_DTO();
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
