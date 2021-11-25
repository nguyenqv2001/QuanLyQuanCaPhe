using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class TimKiemPhieuThanhToan : Form
    {
        public TimKiemPhieuThanhToan()
        {
            InitializeComponent();
        }

        HOADONCHITIET hdct = new HOADONCHITIET();

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string From = dateTimePickerFrom.Value.ToString();
            string To = dateTimePickerTo.Value.ToString();

            SqlCommand command = new SqlCommand("select * from dbo.timPhieuThanhToan (@from, @to)");
            command.Parameters.Add("@from", SqlDbType.DateTime).Value = From;
            command.Parameters.Add("@to", SqlDbType.DateTime).Value = To;
            dataGridViewTimPhieuThanhToan.DataSource = hdct.getPhieuThanhToanTheoNgay(command);
        }
    }
}
