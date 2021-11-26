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
    public partial class Form4 : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }
        public void ShowAllTHONGKE()
        {
            string sql = "SELECT * FROM THONGKEBANHANG";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllBANAN()
        {
            string sql = "SELECT * FROM THONGKEBANHANG where maBan LIKE '%"+ maBan + "%'";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }


        string maBan;
        private void button1_Click(object sender, EventArgs e)
        {
            maBan = "B01";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maBan = "B02";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maBan = "B03";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maBan = "B04";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maBan = "B05";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maBan = "B06";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maBan = "B07";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maBan = "B08";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maBan = "B09";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maBan = "B10";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            maBan = "B11";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            maBan = "B12";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            maBan = "B13";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            maBan = "B14";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            maBan = "B15";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            maBan = "B16";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            maBan = "B17";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            maBan = "B18";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            maBan = "B19";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            maBan = "B20";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            maBan = "B21";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            maBan = "B22";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            maBan = "B23";
            textBox2.Text = maBan;
            ShowAllBANAN();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            maBan = "B24";
            textBox2.Text = maBan; 
            ShowAllBANAN();
        }
        
        // button them
        private void button26_Click(object sender, EventArgs e)
        {
            
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            ShowAllBANAN();
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ShowAllTHONGKE();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            Hide();
            f5.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ShowAllTHONGKE();
        }

        string ID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = dataGridView1.Rows[index].Cells["maPhieuYeuCau"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[index].Cells["maPhieuYeuCau"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[index].Cells["ngayYeuCau"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[index].Cells["maNV"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[index].Cells["maKH"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells["maMon"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[index].Cells["soLuongMon"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[index].Cells["maBan"].Value.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
