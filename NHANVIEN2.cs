using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe
{

    class NHANVIEN2
    {
        public DataTable getNhanVien()
        {
            MY_DB mydb = new MY_DB();

            SqlCommand command = new SqlCommand("SELECT maNV, tenNV from NhanVien", mydb.getConnection);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
