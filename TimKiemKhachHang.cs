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
    public partial class TimKiemKhachHang : Form
    {
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {

        }

        KHACHHANG kh = new KHACHHANG();

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked)
            {
                string idKhachHang = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maKH, tenKH, diaChi, SDT, maPhieuYeuCau, hinhAnh FROM KhachHang WHERE maKH LIKE '%" + idKhachHang + "%'");

                dataGridViewDuLieu.DataSource = kh.getKhachHang(command);
            }
            else if (radioButtonTen.Checked)
            {
                string tenKhachHang = textBoxDuLieu.Text;
                SqlCommand command = new SqlCommand("SELECT maKH, tenKH, diaChi, SDT, maPhieuYeuCau, hinhAnh FROM KhachHang WHERE tenKH LIKE '%" + tenKhachHang + "%'");

                dataGridViewDuLieu.DataSource = kh.getKhachHang(command);
            }
        }
    }
}
