using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class QuanLyThongTinMonAnDAL
    {

        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public QuanLyThongTinMonAnDAL()
        {
            dc = new DataConnection();
        }

        // do du lieu vao datatable
        public DataTable getAllMONAN()
        {
            // Tạo câu lệnh truy vấn lấy toàn bộ bảng MON AN
            string sql = "SELECT * FROM MonAn";
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

        // Chức năng thêm vào 
        public bool InsertMONAN(QUANLYMONAN monan)
        {
            string sql = "INSERT INTO MonAn(maMon,tenMon,donGiaMon,donViTinh,maNhom,hinhAnh) VALUES( @maMon,@tenMon ,@donGiaMon , @donViTinh, @hinhAnh);";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = monan.maMon;
                cmd.Parameters.Add("@tenMon", SqlDbType.NVarChar).Value = monan.tenMon;
                cmd.Parameters.Add("@donGiaMon", SqlDbType.Int).Value = monan.donGiaMon;
                cmd.Parameters.Add("@donViTinh", SqlDbType.NVarChar).Value = monan.donViTinh;
                cmd.Parameters.Add("@maNhom", SqlDbType.Char).Value = monan.maNhom;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = monan.hinhAnh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chức năng sửa 
        public bool UpdateMONAN(QUANLYMONAN monan)
        {
            string sql = "UPDATE MonAn SET  tenMon =@tenMon , donGiaMon = @donGiaMon , donViTinh = @donViTinh, maNhom = @maNhom, hinhAnh = @hinhAnh  WHERE maMon = @maMon";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = monan.maMon;
                cmd.Parameters.Add("@tenMon", SqlDbType.NVarChar).Value = monan.tenMon;
                cmd.Parameters.Add("@donGiaMon", SqlDbType.Int).Value = monan.donGiaMon;
                cmd.Parameters.Add("@donViTinh", SqlDbType.NVarChar).Value = monan.donViTinh;
                cmd.Parameters.Add("@maNhom", SqlDbType.Char).Value = monan.maNhom;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = monan.hinhAnh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chức năng xóa 
        public bool DeleteMONAN(QUANLYMONAN monan)
        {
            string sql = "DELETE MonAn WHERE maMon = @maMon";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maMon", SqlDbType.Char).Value = monan.maMon;
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
