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
    public partial class TimKiemMonAn : Form
    {
        public TimKiemMonAn()
        {
            InitializeComponent();
        }

        MONAN monan = new MONAN();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (radioButtonTenMon.Checked)
            {
                string tenMon = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maMon, tenMon, donGiaMon, donViTinh, maNhom, hinhAnh FROM MonAn WHERE tenMon LIKE '%" + tenMon + "%'");

                dataGridViewTimKiemMonAn.DataSource = monan.getMonAn(command);
            }
            else if (radioButtonLoaiMon.Checked)
            {
                string loaiMon = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maMon, tenMon, donGiaMon, donViTinh, maNhom, hinhAnh FROM MonAn WHERE maNhom LIKE '%" + loaiMon + "%'");
                dataGridViewTimKiemMonAn.DataSource = monan.getMonAn(command);
            }
        }
    }
}
