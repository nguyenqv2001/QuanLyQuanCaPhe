﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void buttonThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            ThongKe10KhachHangMuaNhieuNhat tk10khmnn = new ThongKe10KhachHangMuaNhieuNhat();
            Hide();
            tk10khmnn.Show();
        }

        private void buttonThongKeThucPham_Click(object sender, EventArgs e)
        {
            ThongKeThucPham tktp = new ThongKeThucPham();
            Hide();
            tktp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void buttonThongKeDoanhThuTheoNgay_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuTheoNgay tkdttn = new ThongKeDoanhThuTheoNgay();
            Hide();
            tkdttn.Show();
        }
    }
}
