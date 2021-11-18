using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    static class Program
    {
        /* ---------------------------------------------------PHAN MEM QUAN LY QUAN CA PHE------------------------------------------------------
         * 
         *          Chuong trinh gom co : 9 Form 
         *          Chu y : lam theo thu tu form da phan cong
         *          
         * ------------------------------------------------------------------------------
         *  Hoang Minh Nhat :
         *          Form : 
         *              1.Trang chu gioi thieu quan
         *              2.Đăng nhập
         *              3.Quan Ly thong tin Food
         * ------------------------------------------------------------------------------             
         *  Vuong La Quoc Hoang
         *          Form :
         *              4.Quan ly ban an
         *              5.Hoa don thanh toan
         * ------------------------------------------------------------------------------
         * Do Quoc Viet
         *              6.Quan ly nhan vien
         *              7.Quan ly nhap xuat nguyen lieu
         * ------------------------------------------------------------------------------
         * Nguyen Thanh Dong
         *              8.Ho tro tim kiem
         *              9.Thong ke doanh so
         * ------------------------------------------------------------------------------
         * 
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form7());
        }
    }
}
