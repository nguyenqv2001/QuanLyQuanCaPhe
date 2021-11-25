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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int option;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            option = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            if(option == 1)
            {
                login.role = 1;
                Form2 f2 = new Form2();
                Hide();
                f2.ShowDialog();
            }
            else
            {
                login.role = 2;
                Form2b f2b = new Form2b();
                Hide();
                f2b.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
