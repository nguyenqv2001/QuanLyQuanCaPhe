using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class NhanVienBLL
    {
        NhanVienDAL nvdal;
        public NhanVienBLL()
        {
            nvdal = new NhanVienDAL();
        }
        public DataTable getAllNHANVIEN()
        {
            return nvdal.getAllNHANVIEN();
        }

        public bool InsertNHANVIEN(NhanVien nhanvien)
        {
            return nvdal.InsertNHANVIEN(nhanvien);
        }

        public bool UpdateNHANVIEN(NhanVien nhanvien)
        {
            return nvdal.UpdateNHANVIEN(nhanvien);
        }
        public bool DeleteNHANVIEN(NhanVien nhanvien)
        {
            return nvdal.DeleteNHANVIEN(nhanvien);
        }
    }
}
