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
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbSDT.Text = tbDiachi.Text = "";
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
