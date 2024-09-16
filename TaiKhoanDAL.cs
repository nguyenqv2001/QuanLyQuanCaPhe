using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class TaiKhoanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public TaiKhoanDAL()
        {
            dc = new DataConnection();
        }
        // do du lieu vao datatable
        public DataTable getAllTAIKHOAN()
        {
            // Tạo câu lệnh truy vấn lấy toàn bộ bảng NHANVIEN
            string sql = "SELECT * FROM Account";
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

        // Chức năng thêm vào tai khoan
        public bool InsertTAIKHOAN(TAIKHOAN taikhoan)
        {
            string sql = "INSERT INTO Account (UserID,username,password,role) VALUES(@UserID,@username,@password,@role)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Char).Value = taikhoan.UserID;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = taikhoan.username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = taikhoan.password;
                cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = taikhoan.role;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chức năng sửa tai khoan
        public bool UpdateTAIKHOAN(TAIKHOAN taikhoan)
        {
            string sql = "UPDATE Account SET username=@username ,password=@password ,role=@role WHERE UserID = @UserID";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Char).Value = taikhoan.UserID;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = taikhoan.username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = taikhoan.password;
                cmd.Parameters.Add("@role", SqlDbType.NVarChar).Value = taikhoan.role;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chức năng xoa tai khoan
        public bool DeleteTAIKHOAN(TAIKHOAN taikhoan)
        {
            string sql = "DELETE Account WHERE UserID = @UserID";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Char).Value = taikhoan.UserID;
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
