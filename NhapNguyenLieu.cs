using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NhapNguyenLieu
    {
        
        public int maPN { set; get; }
        public string maNV { set; get; }
        public string maNCC { set; get; }
        public int soLuong { set; get; }
        public string maTP { set; get; }
        public int donGiaNhap { set; get; }
        public DateTime ngaynhap { set; get; }
        public int Tong { set; get; }
        

    }
}
