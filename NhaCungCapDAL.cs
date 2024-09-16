using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NhaCungCapDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhaCungCapDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNCC()
        {

            string sql = "SELECT * FROM NhaCungCap";
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNCC(NhaCungCap ncc)
        {
            string sql = "INSERT INTO NhaCungCap(maNCC,tenNCC,diaChi,SDT,hinhAnh) VALUES(@maNCC, @tenNCC, @diaChi, @SDT, @hinhAnh)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = ncc.maNCC;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = ncc.tenNCC;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = ncc.diaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = ncc.SDT;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = ncc.hinhAnh;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateNCC(NhaCungCap ncc)
        {
            string sql = "UPDATE NhaCungCap SET tenNCC = @tenNCC, diaChi = @diaChi, SDT = @SDT, hinhAnh = @hinhAnh WHERE maNCC = @maNCC";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = ncc.maNCC;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = ncc.tenNCC;
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = ncc.diaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = ncc.SDT;
                cmd.Parameters.Add("@hinhAnh", SqlDbType.VarChar).Value = ncc.hinhAnh;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteNCC(NhaCungCap ncc)
        {
            string sql = "DELETE NhaCungCap WHERE maNCC = @maNCC";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = ncc.maNCC;
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
