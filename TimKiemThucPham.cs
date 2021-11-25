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
    public partial class TimKiemThucPham : Form
    {
        public TimKiemThucPham()
        {
            InitializeComponent();
        }

        THUCPHAM2 tp = new THUCPHAM2();

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                string idThucPham = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE maThucPham LIKE '%" + idThucPham + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
            else if (radioButtonTen.Checked)
            {
                string tenThucPham = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE tenThucPham LIKE '%" + tenThucPham + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
            else if (radioButtonNCC.Checked)
            {
                string maNCC = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE maNCC LIKE '%" + maNCC + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
        }

        private void TimKiemThucPham_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                string idThucPham = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE maThucPham LIKE '%" + idThucPham + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
            else if (radioButtonTen.Checked)
            {
                string tenThucPham = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE tenThucPham LIKE N'%" + tenThucPham + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
            else if (radioButtonNCC.Checked)
            {
                string maNCC = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maThucPham, tenThucPham, donViTinh, NSX, HSD," +
                    " maNCC FROM ThucPham WHERE maNCC LIKE '%" + maNCC + "%'");

                dataGridViewDuLieu.DataSource = tp.getThucPham(command);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            Hide();
            f8.ShowDialog();
        }
    }
}
