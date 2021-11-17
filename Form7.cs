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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormNNL nnl = new FormNNL();
            Hide();
            nnl.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormThucPham tp = new FormThucPham();
            Hide();
            tp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNCC ncc = new FormNCC();
            Hide();
            ncc.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }
    }
}
