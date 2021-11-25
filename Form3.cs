using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class Form3 : Form
    {
        //
        QuanLyThongTinMonAnBLL monanbll;
        //
        public Form3()
        {
            InitializeComponent();
            monanbll = new QuanLyThongTinMonAnBLL();
        }

        public void ShowAllMONAN()
        {
            DataTable dt = monanbll.getAllMONAN();
            dataGridView1.DataSource = dt;
        }

        // button thoat
        private void button4_Click(object sender, EventArgs e)
        {
                      
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
              
        }

        private void btprev_Click(object sender, EventArgs e)
        {

        }


        // button them 
        private void button1_Click(object sender, EventArgs e)
        {
            QUANLYMONAN monan = new QUANLYMONAN();

            monan.maMon = textBox1.Text;
            monan.tenMon = textBox2.Text;
            monan.donGiaMon = int.Parse(textBox3.Text);
            monan.donViTinh = textBox4.Text;
            monan.maNhom = textBox5.Text;
            monan.hinhAnh = textBox6.Text;

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                monan.hinhAnh = "null";

            }
            else { monan.hinhAnh = textBox6.Text; }

            if (monanbll.InsertMONAN(monan))
            {
                ShowAllMONAN();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowAllMONAN();
        }

        

        // kiem tra nhap lieu
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Bạn chưa nhập hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox6.Focus();
                return false;

            }
            return true;
        }

        string ID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = dataGridView1.Rows[index].Cells["maMon"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[index].Cells["maMon"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[index].Cells["tenMon"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells["donGiaMon"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[index].Cells["donViTinh"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[index].Cells["maNhom"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();
                picNV.ImageLocation = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();
            }
        }

        // button sua
        private void button2_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                QUANLYMONAN monan = new QUANLYMONAN();

                monan.maMon = textBox1.Text;
                monan.tenMon = textBox2.Text;
                monan.donGiaMon = int.Parse(textBox3.Text);
                monan.donViTinh = textBox4.Text;
                monan.maNhom = textBox5.Text;
                monan.hinhAnh = textBox6.Text;

                if (monanbll.UpdateMONAN(monan))
                {
                    ShowAllMONAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // button xoa
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                QUANLYMONAN monan = new QUANLYMONAN();

                monan.maMon = textBox1.Text;
                if (monanbll.DeleteMONAN(monan))
                {
                    ShowAllMONAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
