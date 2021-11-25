using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyQuanCaPhe
{
    public partial class Form5 : Form
    {  
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public Form5()
        {
            
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void ShowAllHD()
        {
            string sql = "SELECT * FROM HOADONTHANHTOAN";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string MaKhachHang = tbKH.Text;

            string sql = "SELECT * FROM HOADONTHANHTOAN WHERE maKH LIKE '%" + MaKhachHang + "%'";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong = tong + Convert.ToInt32(row["ThanhTien"]);
            }
            tbTong.Text = tong.ToString();
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            string MaKhachHang = tbKH.Text;
            int MaHD = int.Parse(tbHD.Text);
            dc = new DataConnection();
            string sql = "SELECT * FROM HOADONTHANHTOAN WHERE maKH LIKE '%" + MaKhachHang + "%' and maPhieuYeuCau LIKE '%" + MaHD + "%' ";
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong = tong + Convert.ToInt32(row["ThanhTien"]);
            }
            tbTong.Text = tong.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ShowAllHD();
        }
    }
}
