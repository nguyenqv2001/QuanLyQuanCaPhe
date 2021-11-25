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
    public partial class ThongKe10KhachHangMuaNhieuNhat : Form
    {
        public ThongKe10KhachHangMuaNhieuNhat()
        {
            InitializeComponent();
        }
        KHACHHANG kh = new KHACHHANG();
        private void ThongKe10KhachHangMuaNhieuNhat_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select top 10 * from (select tenKH, count(PYC.maKH) as soLuong from KhachHang as KH join PhieuYeuCau as PYC on KH.maKH = PYC.maKH group by tenKH) ThongKeKhachHang order by soLuong desc");
            dataGridViewThongKe10KhachHang.ReadOnly = true;
            dataGridViewThongKe10KhachHang.RowTemplate.Height = 80;
            dataGridViewThongKe10KhachHang.DataSource = kh.getKhachHang(command);
            dataGridViewThongKe10KhachHang.AllowUserToAddRows = false;


            //
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 2", 1500);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 3", 1400);
            //chartAVG.Series["ChartAVG"].Points.AddXY("thang 4", 1200);
            int RowCount = dataGridViewThongKe10KhachHang.Rows.Count; //hang`
            int ColumnCount = dataGridViewThongKe10KhachHang.Columns.Count; //cot
            int r;
            string ten_tam;
            int giatri;
            for (r = 0; r < RowCount; r++) //chay hang`
            {
                ten_tam = dataGridViewThongKe10KhachHang.Rows[r].Cells[0].Value.ToString();
                for (int c = 1; c < ColumnCount; c++)
                {
                    giatri = Convert.ToInt32(dataGridViewThongKe10KhachHang.Rows[r].Cells[c].Value);
                    chartThongKe10KhachHang.Series["Thống Kê Khách Hàng"].Points.AddXY(ten_tam, giatri);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            Hide();
            f9.Show();
        }
    }
}
