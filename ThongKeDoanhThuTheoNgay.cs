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
    public partial class ThongKeDoanhThuTheoNgay : Form
    {
        public ThongKeDoanhThuTheoNgay()
        {
            InitializeComponent();
        }

        HOADONCHITIET hdct = new HOADONCHITIET();

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerThongKeDoanhThuTheoNgay.Value.ToString();

            SqlCommand command = new SqlCommand("select * from dbo.thongKeTheoNgay (@date)");
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            dataGridViewThongKeDoanhThuTheoNgay.DataSource = hdct.getDoanhThuTheoNgay(command);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            Hide();
            f9.Show();
        }
    }
}
