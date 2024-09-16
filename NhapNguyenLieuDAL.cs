using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyQuanCaPhe
{
    class NhapNguyenLieuDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public NhapNguyenLieuDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNNL()
        {

            string sql = "SELECT * FROM THONGKENHAPHANG";
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNNLCT(NhapNguyenLieu nl)
        {
            string sql = "INSERT INTO PhieuNhapChiTiet(maPhieuNhap_CT,maThucPham,donGiaNhap,soLuong) VALUES(@maPN,  @maTP, @donGiaNhap,@soLuong)";

            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
                cmd.Parameters.Add("@maTP", SqlDbType.Char).Value = nl.maTP;
                cmd.Parameters.Add("@donGiaNhap", SqlDbType.Int).Value = nl.donGiaNhap;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = nl.soLuong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool InsertNNL(NhapNguyenLieu nl)
        {
            string sql = "INSERT INTO PhieuNhap(maPhieuNhap,ngayNhap,maNV,maNCC) VALUES(@maPN, @ngayNhap, @maNV, @maNCC)";
            SqlConnection con = dc.GetConnection();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
                cmd.Parameters.Add("@ngayNhap", SqlDbType.Date).Value = nl.ngaynhap.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nl.maNV;
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = nl.maNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool UpdateNNLCT(NhapNguyenLieu nl)
        {
            string sql = "UPDATE PhieuNhapChiTiet SET  donGiaNhap=@donGiaNhap, soLuong=@soLuong,maThucPham=@maTP WHERE maPhieuNhap_CT = @maPN";

            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
                cmd.Parameters.Add("@maTP", SqlDbType.Char).Value = nl.maTP;
                cmd.Parameters.Add("@donGiaNhap", SqlDbType.Int).Value = nl.donGiaNhap;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = nl.soLuong;
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNNL(NhapNguyenLieu nl)
        {

            string sql = "UPDATE PhieuNhap SET  ngayNhap = @ngayNhap, maNV = @maNV, maNCC = @maNCC WHERE maPhieuNhap = @maPN";
            SqlConnection con = dc.GetConnection();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
                cmd.Parameters.Add("@ngayNhap", SqlDbType.Date).Value = nl.ngaynhap.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nl.maNV;
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = nl.maNCC;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNNLCT(NhapNguyenLieu nl)
        {
            string sql = "DELETE PhieuNhapChiTiet WHERE maPhieuNhap_CT = @maPN";

            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNNL(NhapNguyenLieu nl)
        {
            string sql = "DELETE PhieuNhap WHERE maPhieuNhap = @maPN";
            SqlConnection con = dc.GetConnection();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maPN", SqlDbType.Int).Value = nl.maPN;
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
