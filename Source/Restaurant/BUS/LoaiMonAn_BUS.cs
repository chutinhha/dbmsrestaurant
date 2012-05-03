﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiMonAn_BUS
    {
        public static DataTable DocLoaiMonAn()
        {
            return LoaiMonAn_DAO.DocLoaiMonAn();
        }
        public static int CapNhatLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            return LoaiMonAn_DAO.CapNhatLoaiMonAn(loaiMonAn);
        }
        public static int XoaLoaiMonAn(string maLoai)
        {
            return LoaiMonAn_DAO.XoatLoaiMonAn(maLoai);
        }
        public static int ThemLoaiMonAn(LoaiMonAn_DTO loaiMonAn)
        {
            return LoaiMonAn_DAO.ThemLoaiMonAn(loaiMonAn);
        }
    }
}
