using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BanAn_DTO
    {
        private int maBan;

        public int MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }
        private int maKhuVuc;

        public int MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }
        private string loaiBan;

        public string LoaiBan
        {
            get { return loaiBan; }
            set { loaiBan = value; }
        }
        private string maNH;

        public string MaNH
        {
            get { return maNH; }
            set { maNH = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }


    }
}
