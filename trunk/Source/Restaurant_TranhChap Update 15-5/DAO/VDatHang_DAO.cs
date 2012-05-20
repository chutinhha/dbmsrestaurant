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
        public List<VDatHang_DTO> SelectDatHang(int mode, String MaNH)
        {
            String store = "SPoV_SelectDatHang";
           CreateCommand_StoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return  ConvertToList(ExecSelectCommand());
        }
        public List<VDatHang_DTO> SelectDatHang_TinhTrang(int mode, String MaNH, String TinhTrang)
        {
            String store = "SPoV_SelectDatHang_TinhTrang";
            CreateCommand_StoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            cm.Parameters["@maNH"].Value = MaNH;
            cm.Parameters["@TinhTrang"].Value = TinhTrang;

            return ConvertToList(ExecSelectCommand());
        }
        public int InsertDatHang(int mode, VDatHang_DTO dh, DataTable ChiTiet)
        {
            String store = "SPoV_InsertDatHang";

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
        public int UpdatetDatHang(int mode, VDatHang_DTO dh, DataTable ChiTiet)
        {
            String store = "SPoV_UpdateDatHang";
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
        public int UpdatetTinhTrangDatHang(int mode, int MaHoaDon, String tinhtrang)
        {
            String store = "SPoV_UpdateTinhTrangDatHang"; // deffault

            //Goi store theo Mode
            if (mode == 1) //che do delay
                store = "SPoV_DeLay_UpdateTinhTrangDatHang";
            else
                if (mode == 2) //che do fix loi
                    store = "SPoV_FIX_UpdateTinhTrangDatHang";

            CreateCommand_StoreName(store);
            cm.Parameters.Add("@Flag", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            cm.Parameters["@MaHoaDon"].Value = MaHoaDon;
            cm.Parameters["@TinhTrang"].Value = tinhtrang;

            ExecuteInsertUpdateDelete();
            return (int)cm.Parameters["@Flag"].Value;
        }
        public int DeleteDatHang(int mode, int MaHoaDon)
        {
            String store = "SPoV_DeleteDatHang";
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
