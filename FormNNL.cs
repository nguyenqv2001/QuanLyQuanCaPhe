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
    public partial class FormNNL : Form
    {
        public FormNNL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbID_phieunhap.Text = tbDongia.Text = tbNgaynhap.Text = tbSoluong.Text = tbID_NCC.Text = tbID_NV.Text = tbID_ThucPham.Text = "";
            tbID_phieunhap.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Hide();
            form7.ShowDialog();
        }
    }
}
