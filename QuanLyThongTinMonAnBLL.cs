using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class QuanLyThongTinMonAnBLL
    {
        QuanLyThongTinMonAnDAL monandal;
        public QuanLyThongTinMonAnBLL()
        {
            monandal = new QuanLyThongTinMonAnDAL();
        }
        public DataTable getAllMONAN()
        {
            return monandal.getAllMONAN();
        }

        public bool InsertMONAN(QUANLYMONAN monan)
        {
            return monandal.InsertMONAN(monan);
        }
        public bool UpdateMONAN(QUANLYMONAN monan)
        {
            return monandal.UpdateMONAN(monan);
        }
        public bool DeleteMONAN(QUANLYMONAN monan)
        {
            return monandal.DeleteMONAN(monan);
        }
    }
}
