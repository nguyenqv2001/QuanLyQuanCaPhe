using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NhaCungCapBLL
    {
        NhaCungCapDAL nccdal;
        public NhaCungCapBLL()
        {
            nccdal = new NhaCungCapDAL();
        }
        public DataTable getAllNCC()
        {
            return nccdal.getAllNCC();
        }

        public bool InsertNCC(NhaCungCap NhaCungCap)
        {
            return nccdal.InsertNCC(NhaCungCap);
        }

        public bool UpdateNCC(NhaCungCap NhaCungCap)
        {
            return nccdal.UpdateNCC(NhaCungCap);
        }
        public bool DeleteNCC(NhaCungCap NhaCungCap)
        {
            return nccdal.DeleteNCC(NhaCungCap);
        }
    }
}
