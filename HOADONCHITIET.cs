using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    class HOADONCHITIET
    {
        MY_DB mydb = new MY_DB();
        public bool insertHoaDonChiTiet(string maPhieuYeuCau, string maMon, string tenMon, int donGiaMon, string maBan, int donGiaBan, DateTime ngayThanhToan, int soLuongMon, int soLuongBan)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PhieuThanhToan (maPhieuYeuCau, maMon, tenMon, donGiaMon, maBan, donGiaBan, ngayThanhToan,  " +
                "soLuongMon, soLuongBan)" + "VALUES (@id, @mm, @tm, @dgm, @mb, @dgb, @ntt, @slm, @slb)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = maPhieuYeuCau;
            command.Parameters.Add("@mm", SqlDbType.VarChar).Value = maMon;
            command.Parameters.Add("@tm", SqlDbType.VarChar).Value = tenMon;
            command.Parameters.Add("@dgm", SqlDbType.Int).Value = donGiaMon;
            command.Parameters.Add("@mb", SqlDbType.VarChar).Value = maBan;
            command.Parameters.Add("@dgb", SqlDbType.Int).Value = donGiaBan;
            command.Parameters.Add("@ntt", SqlDbType.DateTime).Value = ngayThanhToan;
            command.Parameters.Add("@slm", SqlDbType.Int).Value = soLuongMon;
            command.Parameters.Add("@slb", SqlDbType.Int).Value = soLuongBan;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool checkHoaDonChiTiet(string Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PhieuThanhToan WHERE maPhieuYeuCau <> @cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                //neu phat hien cos 1 dong ton tai trung ten
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
