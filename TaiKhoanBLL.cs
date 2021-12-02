using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class TaiKhoanBLL
    {
        TaiKhoanDAL tkdal;
        public TaiKhoanBLL()
        {
            tkdal = new TaiKhoanDAL();
        }
        public DataTable getAllTAIKHOAN()
        {
            return tkdal.getAllTAIKHOAN();
        }

        public bool InsertTAIKHOAN(TAIKHOAN taikhoan)
        {
            return tkdal.InsertTAIKHOAN(taikhoan);
        }

        public bool UpdateTAIKHOAN(TAIKHOAN taikhoan)
        {
            return tkdal.UpdateTAIKHOAN(taikhoan);
        }
        public bool DeleteTAIKHOAN(TAIKHOAN taikhoan)
        {
            return tkdal.DeleteTAIKHOAN(taikhoan);
        }
    }
}
