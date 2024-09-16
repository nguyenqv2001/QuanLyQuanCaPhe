using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NhapNguyenLieuBLL
    {
        NhapNguyenLieuDAL nnldal;
        public NhapNguyenLieuBLL()
        {
            nnldal = new NhapNguyenLieuDAL();
        }
        public DataTable getAllNNL()
        {
            return nnldal.getAllNNL();
        }

        public bool InsertNNL(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.InsertNNL(NhapNguyenLieu);
        }
        public bool InsertNNLCT(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.InsertNNLCT(NhapNguyenLieu);
        }

        public bool UpdateNNL(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.UpdateNNL(NhapNguyenLieu);
        }
        public bool UpdateNNLCT(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.UpdateNNLCT(NhapNguyenLieu);
        }
        public bool DeleteNNL(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.DeleteNNL(NhapNguyenLieu);
        }
        public bool DeleteNNLCT(NhapNguyenLieu NhapNguyenLieu)
        {
            return nnldal.DeleteNNLCT(NhapNguyenLieu);
        }
    }
}
