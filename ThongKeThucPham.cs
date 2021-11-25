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
    public partial class ThongKeThucPham : Form
    {
        public ThongKeThucPham()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        ThucPhamDAL tp = new ThucPhamDAL();

        private void ThongKeThucPham_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select top 10 * from (select tenMon, sum(soLuongMon) as soLuong from PhieuThanhToan group by tenMon) ThongKeMonAn order by soLuong desc");
            dataGridViewThongKeThucPhamBanChay.ReadOnly = true;
            dataGridViewThongKeThucPhamBanChay.RowTemplate.Height = 80;
            dataGridViewThongKeThucPhamBanChay.DataSource = tp.getThucPham(command);
            dataGridViewThongKeThucPhamBanChay.AllowUserToAddRows = false;
            
            int RowCount = dataGridViewThongKeThucPhamBanChay.Rows.Count; //hang`
            int ColumnCount = dataGridViewThongKeThucPhamBanChay.Columns.Count; //cot
            int r;
            string ten_tam;
            int giatri;
            for (r = 0; r < RowCount; r++) //chay hang`
            {
                ten_tam = dataGridViewThongKeThucPhamBanChay.Rows[r].Cells[0].Value.ToString();
                for (int c = 1; c < ColumnCount; c++)
                {
                    giatri = Convert.ToInt32(dataGridViewThongKeThucPhamBanChay.Rows[r].Cells[c].Value);
                    chartThongKeThucPhamBanChay.Series["Thống Kê Thực Phẩm Bán Chạy"].Points.AddXY(ten_tam, giatri);
                }
            }
        }
    }
}
