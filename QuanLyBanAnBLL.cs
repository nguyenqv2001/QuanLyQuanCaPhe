using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class QuanLyBanAnBLL
    {
        QuanLyBanAnDAL banandal;
        public QuanLyBanAnBLL()
        {
            banandal = new QuanLyBanAnDAL();
        }

        public DataTable getAllBANAN()
        {
            return banandal.getAllBANAN();
        }

        // Chuc nang gio hang them , xoa , sua  mon an 
        public bool InsertMONAN(QUANLYBANAN banan)
        {
            return banandal.InsertMONAN(banan);
        }
        
        public bool DeleteMONAN(QUANLYBANAN banan)
        {
            return banandal.DeleteMONAN(banan);
        }

        public bool DeleteMONANALL(QUANLYBANAN banan)
        {
            return banandal.DeleteMONANALL(banan);
        }

        public bool UpdateMONAN(QUANLYBANAN banan)
        {
            return banandal.UpdateMONAN(banan);
        }


        // Chuc nang them , xoa , sua thong tin hoa don
        public bool InsertHOADON(QUANLYBANAN banan)
        {
            return banandal.InsertHOADON(banan);
        }
        
        public bool DeleteHOADON(QUANLYBANAN banan)
        {
            return banandal.DeleteHOADON(banan);
        }

        public bool UpdateHOADON(QUANLYBANAN banan)
        {
            return banandal.UpdateHOADON(banan);
        }

        // Update trang thai ban an khi dat hang
        public bool UpdateBANAN(QUANLYBANAN banan)
        {
            return banandal.UpdateBANAN(banan);
        }
        // Update trang thai ban an khi thanh toan
        public bool UpdateBANANTT(QUANLYBANAN banan)
        {
            return banandal.UpdateBANANTT(banan);
        }
    }
}
