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
        public DatHang_DAO()
        {
            provider = new Provider();
        }
      
        public List<DatHang_DTO> SelectDatHang(String MaNH)
        {
            String store = "SelectDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            return  ConvertToList(provider.ExecSelectCommand(cm));
        }
        public int InsertDatHang(DatHang_DTO dh)
        {
            String store = "InsertDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@MaHoaDon", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@MaNCC", SqlDbType.Int);
            cm.Parameters.Add("@MaNH", SqlDbType.NChar);
            cm.Parameters.Add("@TongTien", SqlDbType.Float);
            cm.Parameters.Add("@ThoiGianDat", SqlDbType.DateTime);
            cm.Parameters.Add("@ThoiGianGiao", SqlDbType.DateTime);
            cm.Parameters.Add("@TinhTrang", SqlDbType.NVarChar);

            cm.Parameters["@MaNCC"].Value = dh.MaNCC;
            cm.Parameters["@MaNH"].Value = dh.MaNH;
            cm.Parameters["@TongTien"].Value = dh.TongTien;
            cm.Parameters["@ThoiGianDat"].Value = dh.ThoiGianDat;
            cm.Parameters["@ThoiGianGiao"].Value = dh.ThoiGianGiao;
            cm.Parameters["@TinhTrang"].Value = dh.TinhTrang;

            provider.ExecuteInsertUpdateDelete(cm);
            return (int)cm.Parameters["@MaHoaDon"].Value;
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
