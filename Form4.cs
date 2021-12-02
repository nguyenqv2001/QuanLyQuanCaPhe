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
        public void ShowAllBANANCT()
        {
            string sql = "SELECT * FROM THONGKEBANHANG where maBan LIKE '%" + maBan + "%'";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        //
        QuanLyBanAnBLL bananbll;
        //
        public Form4()
        {
            InitializeComponent();
            bananbll = new QuanLyBanAnBLL();
        }
        public void ShowAllBANAN()
        {
            DataTable dt = bananbll.getAllBANAN();
            dataGridView1.DataSource = dt;

            // xet trang thai cho tung ban an
            string sql = "SELECT maBan,tinhTrang FROM BanAn";
            dc = new DataConnection();
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable tt = new DataTable();
            da.Fill(tt);
            con.Close();
            // khoi tao trang thai trong
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button18.BackColor = Color.Red;
            button19.BackColor = Color.Red;
            button20.BackColor = Color.Red;
            button21.BackColor = Color.Red;
            button22.BackColor = Color.Red;
            button23.BackColor = Color.Red;
            button24.BackColor = Color.Red;
            //
            if (Convert.ToInt32(tt.Rows[0]["tinhTrang"]) == 1)
            {
                button1.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[1]["tinhTrang"]) == 1)
            {
                button2.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[2]["tinhTrang"]) == 1)
            {
                button3.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[3]["tinhTrang"]) == 1)
            {
                button4.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[4]["tinhTrang"]) == 1)
            {
                button5.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[5]["tinhTrang"]) == 1)
            {
                button6.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[6]["tinhTrang"]) == 1)
            {
                button7.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[7]["tinhTrang"]) == 1)
            {
                button8.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[8]["tinhTrang"]) == 1)
            {
                button9.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[9]["tinhTrang"]) == 1)
            {
                button10.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[10]["tinhTrang"]) == 1)
            {
                button11.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[11]["tinhTrang"]) == 1)
            {
                button12.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[12]["tinhTrang"]) == 1)
            {
                button13.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[13]["tinhTrang"]) == 1)
            {
                button14.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[14]["tinhTrang"]) == 1)
            {
                button15.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[15]["tinhTrang"]) == 1)
            {
                button16.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[16]["tinhTrang"]) == 1)
            {
                button17.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[17]["tinhTrang"]) == 1)
            {
                button18.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[18]["tinhTrang"]) == 1)
            {
                button19.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[19]["tinhTrang"]) == 1)
            {
                button20.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[20]["tinhTrang"]) == 1)
            {
                button21.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[21]["tinhTrang"]) == 1)
            {
                button22.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[22]["tinhTrang"]) == 1)
            {
                button23.BackColor = Color.Green;
            }
            if (Convert.ToInt32(tt.Rows[23]["tinhTrang"]) == 1)
            {
                button24.BackColor = Color.Green;
            }
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
            ShowAllBANANCT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maBan = "B02";
            ShowAllBANANCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maBan = "B03";
            ShowAllBANANCT();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maBan = "B04";
            ShowAllBANANCT();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maBan = "B05";
            ShowAllBANANCT();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maBan = "B06";
            ShowAllBANANCT();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maBan = "B07";
            ShowAllBANANCT();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maBan = "B08";
            ShowAllBANANCT();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maBan = "B09";
            ShowAllBANANCT();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maBan = "B10";
            ShowAllBANANCT();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            maBan = "B11";
            ShowAllBANANCT();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            maBan = "B12";
            ShowAllBANANCT();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            maBan = "B13";
            ShowAllBANANCT();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            maBan = "B14";
            ShowAllBANANCT();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            maBan = "B15";
            ShowAllBANANCT();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            maBan = "B16";
            ShowAllBANANCT();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            maBan = "B17";
            ShowAllBANANCT();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            maBan = "B18";
            ShowAllBANANCT();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            maBan = "B19";
            ShowAllBANANCT();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            maBan = "B20";
            ShowAllBANANCT();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            maBan = "B21";
            ShowAllBANANCT();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            maBan = "B22";
            ShowAllBANANCT();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            maBan = "B23";
            ShowAllBANANCT();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            maBan = "B24";
            ShowAllBANANCT();
        }
        
        // button them hoa don
        private void button26_Click(object sender, EventArgs e)
        {
            QUANLYBANAN banan = new QUANLYBANAN();

            banan.maPhieuYeuCau = Int32.Parse(textBox7.Text);
            banan.maKH = textBox4.Text;
            banan.maNV = textBox5.Text;
            banan.ngayYeuCau = textBox6.Text;
            banan.maMon = textBox3.Text;
            banan.soLuongMon = Int32.Parse(textBox1.Text);
            banan.maBan = textBox2.Text;

            if (bananbll.InsertHOADON(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , không tạo được hóa đơn", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (bananbll.InsertMONAN(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , không thêm được món ăn", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (bananbll.UpdateBANAN(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , không update được trạng thái bàn", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            ShowAllBANAN();
        }
        // button them mon
        private void button27_Click(object sender, EventArgs e)
        {
            QUANLYBANAN banan = new QUANLYBANAN();

            banan.maPhieuYeuCau = Int32.Parse(textBox7.Text);
            banan.maMon = textBox3.Text;
            banan.soLuongMon = Int32.Parse(textBox1.Text);
            banan.maBan = textBox2.Text;

            if (bananbll.InsertMONAN(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ShowAllBANAN();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            QUANLYBANAN banan = new QUANLYBANAN();
            banan.maBan = textBox2.Text;
            // update trang thai ban an khi thanh toan
            if (bananbll.UpdateBANANTT(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , không update được trạng thái bàn", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            // Qua Form hoa don de in ra hoa don
            Form f5 = new Form5();
            Hide();
            f5.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        // button xoa hoa don
        private void button32_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                QUANLYBANAN banan = new QUANLYBANAN();

                banan.maPhieuYeuCau = Int32.Parse(textBox7.Text);
                if (bananbll.DeleteMONANALL(banan))
                {
                    ShowAllBANAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , Không xóa được tất cả món ăn!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (bananbll.DeleteHOADON(banan))
                {
                    ShowAllBANAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , không xóa được hóa đơn !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        // button sua hoa don
        private void button33_Click(object sender, EventArgs e)
        {
            QUANLYBANAN banan = new QUANLYBANAN();

            banan.maPhieuYeuCau = Int32.Parse(textBox7.Text);
            banan.maKH = textBox4.Text;
            banan.maNV = textBox5.Text;
            banan.ngayYeuCau = textBox6.Text;
            banan.maMon = textBox3.Text;
            banan.soLuongMon = Int32.Parse(textBox1.Text);
            banan.maBan = textBox2.Text;
            if (bananbll.UpdateHOADON(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (bananbll.UpdateMONAN(banan))
            {
                ShowAllBANAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        //---------------------------------------------------------------------------------------

        // button xoa mon
        private void button31_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                QUANLYBANAN banan = new QUANLYBANAN();

                banan.maPhieuYeuCau = Int32.Parse(textBox7.Text);
                banan.maMon = textBox3.Text;
                if (bananbll.DeleteMONAN(banan))
                {
                    ShowAllBANAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        // button sua mon
        private void button34_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            ShowAllBANAN();
        }
    }
}
