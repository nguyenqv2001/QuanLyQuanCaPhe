using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class QuanLyBanAnDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public QuanLyBanAnDAL()
        {
            dc = new DataConnection();
        }

        // do du lieu vao datatable
        public DataTable getAllBANAN()
        {
            // Tạo câu lệnh truy vấn lấy toàn bộ bảng MON AN
            string sql = "SELECT * FROM THONGKEBANHANG";
            // Tạo một kết nối đến sql
            SqlConnection con = dc.GetConnection();
            // khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // Đổ dữ liệu từ sqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Đóng kết nối
            con.Close();
            return dt;
        }

        /* Chức năng thêm , xóa , sửa thông tin hóa đơn */

        // Chức năng thêm hóa đơn
        public bool InsertHOADON(QUANLYBANAN banan)
        {
            string sql = "INSERT INTO PhieuYeuCau(maPhieuYeuCau,maKH,maNV,ngayYeuCau) VALUES(@maPhieuYeuCau,@maKH,@maNV,@ngayYeuCau); ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.Parameters.Add("@maKH", SqlDbType.Char).Value = banan.maKH;
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = banan.maNV;
                cmd.Parameters.Add("@ngayYeuCau", SqlDbType.DateTime).Value = banan.ngayYeuCau;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        // Chức năng xóa hóa đơn 
        public bool DeleteHOADON(QUANLYBANAN banan)
        {
            string sql = "DELETE PhieuYeuCau  WHERE maPhieuYeuCau = @maPhieuYeuCau";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chức năng sửa thông tin hóa đơn
        public bool UpdateHOADON(QUANLYBANAN banan)
        {
            string sql = "UPDATE PhieuYeuCau SET maKH=@maKH,maNV=@maNV,ngayYeuCau=@ngayYeuCau  WHERE maPhieuYeuCau = @maPhieuYeuCau";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.Parameters.Add("@maKH", SqlDbType.Char).Value = banan.maKH;
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = banan.maNV;
                cmd.Parameters.Add("@ngayYeuCau", SqlDbType.DateTime).Value = banan.ngayYeuCau;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        /* Chức năng giỏ hàng : thêm , sửa , xóa món ăn */

        // Chức năng thêm món ăn vào hóa đơn
        public bool InsertMONAN(QUANLYBANAN banan)
        {
            string sql = "INSERT INTO PhieuThanhToan (maPhieuYeuCau,maMon,soLuongMon,maBan) VALUES(@maPhieuYeuCau,@maMon,@soLuongMon,@maBan); ";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = banan.maMon;
                cmd.Parameters.Add("@soLuongMon", SqlDbType.Int).Value = banan.soLuongMon;
                cmd.Parameters.Add("@maBan", SqlDbType.Char).Value = banan.maBan;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        // Chức năng xóa món ăn khỏi hóa đơn 
        public bool DeleteMONAN(QUANLYBANAN banan)
        {
            string sql = "DELETE PhieuThanhToan  WHERE maPhieuYeuCau = @maPhieuYeuCau and maMon = @maMon";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = banan.maMon;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        // Chức năng xóa tất cả món ăn khỏi hóa đơn 
        public bool DeleteMONANALL(QUANLYBANAN banan)
        {
            string sql = "DELETE PhieuThanhToan  WHERE maPhieuYeuCau = @maPhieuYeuCau";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        // Chức năng sửa thông tin món ăn trong hóa đơn
        public bool UpdateMONAN(QUANLYBANAN banan)
        {
            string sql = "UPDATE PhieuThanhToan SET soLuongMon=@soLuongMon , maBan=@maBan WHERE maPhieuYeuCau = @maPhieuYeuCau and maMon=@maMon";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPhieuYeuCau", SqlDbType.Int).Value = banan.maPhieuYeuCau;
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = banan.maMon;
                cmd.Parameters.Add("@soLuongMon", SqlDbType.Int).Value = banan.soLuongMon;
                cmd.Parameters.Add("@maBan", SqlDbType.Char).Value = banan.maBan;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Update trang thai ban an khi dat hang
        public bool UpdateBANAN(QUANLYBANAN banan)
        {
            string sql = "UPDATE BanAn SET tinhTrang='1' WHERE maBan=@maBan";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();                              
                cmd.Parameters.Add("@maBan", SqlDbType.Char).Value = banan.maBan;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Update trang thai ban an khi thanh toan
        public bool UpdateBANANTT(QUANLYBANAN banan)
        {
            string sql = "UPDATE BanAn SET tinhTrang='0' WHERE maBan=@maBan";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maBan", SqlDbType.Char).Value = banan.maBan;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
