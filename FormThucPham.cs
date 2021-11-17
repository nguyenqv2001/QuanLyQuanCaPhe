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
    public partial class FormThucPham : Form
    {
        public FormThucPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbNSX.Text = tbHSD.Text = tbDonvi.Text = tbID_NCC.Text = "";
            tbID.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Hide();
            form7.ShowDialog();
        }
    }
}
