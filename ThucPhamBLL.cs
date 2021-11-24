using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class ThucPhamBLL
    {
        ThucPhamDAL tpdal;
        public ThucPhamBLL()
        {
            tpdal = new ThucPhamDAL();
        }
        public DataTable getAllTP()
        {
            return tpdal.getAllTP();
        }

        public bool InsertTP(ThucPham ThucPham)
        {
            return tpdal.InsertTP(ThucPham);
        }

        public bool UpdateTP(ThucPham ThucPham)
        {
            return tpdal.UpdateTP(ThucPham);
        }
        public bool DeleteTP(ThucPham ThucPham)
        {
            return tpdal.DeleteTP(ThucPham);
        }
    }
}
