using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

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
            daoDatHang.Provider = b.Provider;
        }
        public List<VDatHang_DTO> SelectDatHang(String MaNH)
        {
            return daoDatHang.SelectDatHang(MaNH);
        }

        public int InsertDatHang(VDatHang_DTO dh)
        {
            return daoDatHang.InsertDatHang(dh);
        }

        public int UpdateDatHang(VDatHang_DTO dh)
        {
            return daoDatHang.UpdatetDatHang(dh);
        }

        public int DeleteDatHang(int MaHD)
        {
            return daoDatHang.DeleteDatHang(MaHD);
        }
    }
}
