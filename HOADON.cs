using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{
    class HOADON
    {
        MY_DB mydb = new MY_DB();
        public bool insertHoaDon(string maPhieuYeuCau, string maKH, string maNV, DateTime ngayYeuCau)
        {
            SqlCommand command = new SqlCommand("INSERT INTO PhieuYeuCau (maPhieuYeuCau, maKH, maNV, ngayYeuCau)" + "VALUES (@id, @mkh, @mnv, @nyc)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = maPhieuYeuCau;
            command.Parameters.Add("@mkh", SqlDbType.VarChar).Value = maKH;
            command.Parameters.Add("@mnv", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@nyc", SqlDbType.DateTime).Value = ngayYeuCau;
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

        public bool checkHoaDon(string Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PhieuYeuCau WHERE maPhieuYeuCau <> @cID", mydb.getConnection);
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

        public DataTable getHoaDon()
        {
            SqlCommand command = new SqlCommand("SELECT maPhieuYeuCau from PhieuYeuCau", mydb.getConnection);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
