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
    public partial class Form1 : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }
        int option;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            option = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            string sql = "SELECT * FROM Account WHERE username LIKE '%" + username + "%' and password LIKE '%" + password + "%'";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                count = count + Convert.ToInt32(row["role"]);
            }
            if (count != 0)
            {
                
                if (count == 1 && count == option) 
                {
                    Form2 f2 = new Form2();
                    Hide();
                    f2.ShowDialog();
                }
                if (count == 2 && count == option)
                {
                    Form2b f2b = new Form2b();
                    Hide();
                    f2b.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("username hoặc password không đúng , mời bạn nhập lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
