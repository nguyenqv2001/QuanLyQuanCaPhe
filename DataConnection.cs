using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyQuanCaPhe
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source=DESKTOP-6V6IGLT\\SQLEXPRESS;Initial Catalog=QuanLyQuanCaPhe1;Integrated Security=True";

        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(conStr);
        }


    }
}
