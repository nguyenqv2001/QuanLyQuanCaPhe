using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NhanVien
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public string maNV { set; get; }
        public string tenNV { set; get; }
        public string diaChi { set; get; }
        public string SDT { set; get; }
        public string chucVu { set; get; }
        public string hinhAnh { set; get; }


        public NhanVien()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNHANVIEN()
        {
            // Tạo câu lệnh truy vấn lấy toàn bộ bảng NHANVIEN
            string sql = "SELECT * FROM NhanVien";
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
        public bool InsertNHANVIEN(NhanVien nhanvien)
        {
            string sql = "INSERT INTO NhanVien(maNV,tenNV,chucVu,diaChi,SDT,hinhAnh) VALUES(@maNV,@tenNV,@chucVu,@diaChi,@SDT,@hinhAnh)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nhanvien.maNV;
                cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = nhanvien.tenNV;
                cmd.Parameters.Add("@chucVu", SqlDbType.NVarChar).Value = nhanvien.chucVu;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhanvien.diaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = nhanvien.SDT;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = nhanvien.hinhAnh;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNHANVIEN(NhanVien nhanvien)
        {
            string sql = "UPDATE NhanVien SET tenNV = @tenNV, diaChi = @diaChi, SDT = @SDT, chucVu = @chucVu, hinhAnh = @hinhAnh WHERE maNV = @maNV";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nhanvien.maNV;
                cmd.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = nhanvien.tenNV;
                cmd.Parameters.Add("@chucVu", SqlDbType.NVarChar).Value = nhanvien.chucVu;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = nhanvien.diaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = nhanvien.SDT;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = nhanvien.hinhAnh;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNHANVIEN(NhanVien nhanvien)
        {
            string sql = "DELETE NhanVien WHERE maNV = @maNV";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nhanvien.maNV;
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
