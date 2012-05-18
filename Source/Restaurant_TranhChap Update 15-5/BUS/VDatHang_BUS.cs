using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class VDatHang_BUS:VBus
    {
        VDatHang_DAO daoDatHang;
        public VDatHang_BUS()
        {
            daoDatHang = new VDatHang_DAO();
        }
        public void CopyProvider(VBus b)
        {
            daoDatHang.Copy(b.Provider);
        }
        public List<VDatHang_DTO> SelectDatHang(String MaNH)
        {
            return daoDatHang.SelectDatHang(MaNH);
        }

        public int InsertDatHang(VDatHang_DTO dh,DataTable chitiet )
        {
            return daoDatHang.InsertDatHang(dh,chitiet);
        }

        public int UpdateDatHang(VDatHang_DTO dh,DataTable chitiet)
        {
            return daoDatHang.UpdatetDatHang(dh,chitiet);
        }
        public int UpdateTinhTrangDatHang(int MaHoaDon, String tinhtrang)
        {
            return daoDatHang.UpdatetTinhTrangDatHang(MaHoaDon,tinhtrang);
        }

        public int DeleteDatHang(int MaHD)
        {
            return daoDatHang.DeleteDatHang(MaHD);
        }
    }
}
