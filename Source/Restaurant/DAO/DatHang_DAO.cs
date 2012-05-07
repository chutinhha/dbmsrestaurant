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
        public void SelectDatHang(String MaNH)
        {
            String store = "SelectDatHang";
            SqlCommand cm = provider.CreateCommandStoreName(store);
            cm.Parameters.Add("@maNH", SqlDbType.NChar);

            cm.Parameters["@maNH"].Value = MaNH;
            ConvertToList(provider.ExecSelectCommand(cm));
        }
        private List<DatHang_DTO> ConvertToList(DataTable dt)
        {
            List<DatHang_DTO> ls = new List<DatHang_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                DatHang_DTO ttdh = new DatHang_DTO();
                ttdh.MaHoaDon = (int)row.ItemArray[0];
                ttdh.ThanhTien = (double)row.ItemArray[1];
                ttdh.ThoiGianDat = (DateTime)row.ItemArray[2];
                ttdh.ThoiGianGiao = (DateTime)row.ItemArray[3];
                ttdh.MaNH = row.ItemArray[4].ToString();
                ls.Add(ttdh);
            }
            return ls;
        }
    }
}
