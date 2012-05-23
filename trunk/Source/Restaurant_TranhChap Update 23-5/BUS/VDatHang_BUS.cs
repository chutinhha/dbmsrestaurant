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
        public List<VDatHang_DTO> SelectDatHang(int mode, String MaNH)
        {
            return daoDatHang.SelectDatHang(mode, MaNH);
        }
        public List<VDatHang_DTO> SelectDatHang_TinhTrang(int mode, String MaNH, String TinhTrang)
        {
            return daoDatHang.SelectDatHang_TinhTrang(mode, MaNH, TinhTrang);
        }
        public int InsertDatHang(int mode, VDatHang_DTO dh, DataTable chitiet)
        {
            return daoDatHang.InsertDatHang(mode, dh, chitiet);
        }

        public int UpdateDatHang(int mode, VDatHang_DTO dh, DataTable chitiet)
        {
            return daoDatHang.UpdatetDatHang(mode, dh, chitiet);
        }
        public int UpdateTinhTrangDatHang(int mode, int MaHoaDon, String tinhtrang)
        {
            return daoDatHang.UpdatetTinhTrangDatHang(mode, MaHoaDon, tinhtrang);
        }

        public int DeleteDatHang(int mode, int MaHD)
        {
            return daoDatHang.DeleteDatHang(mode, MaHD);
        }
    }
}
