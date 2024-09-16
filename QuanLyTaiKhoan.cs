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
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoanBLL tk;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            tk = new TaiKhoanBLL();
        }

        public void ShowAllTAIKHOAN()
        {
            DataTable dt = tk.getAllTAIKHOAN();
            dataGridView1.DataSource = dt;
        }

        public bool CheckData()
        {
            // kiểm tra dữ liệu nhập trong textBox tài khoan có trống không
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Bạn chưa nhập UserID.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập username.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTen.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập password.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbRole.Text))
            {
                MessageBox.Show("Bạn chưa nhập Chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbRole.Focus();
                return false;

            }         
            return true;
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            ShowAllTAIKHOAN();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbTen.Text = tbPass.Text = tbRole.Text = "";
            tbID.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbID.Text = dataGridView1.Rows[index].Cells["UserID"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[index].Cells["username"].Value.ToString();
                tbPass.Text = dataGridView1.Rows[index].Cells["password"].Value.ToString();
                tbRole.Text = dataGridView1.Rows[index].Cells["role"].Value.ToString();               
            }
        }
        // Chức năng thêm tài khoản
        private void btThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                TAIKHOAN taikhoan = new TAIKHOAN();

                taikhoan.UserID = Int32.Parse(tbID.Text);
                taikhoan.username = tbTen.Text;
                taikhoan.password = tbPass.Text;
                taikhoan.role = Int32.Parse(tbRole.Text);
                
                if (tk.InsertTAIKHOAN(taikhoan))
                {
                    ShowAllTAIKHOAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        // Chuc nang sua thong tin tai khoan
        private void btSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                TAIKHOAN taikhoan = new TAIKHOAN();

                taikhoan.UserID = Int32.Parse(tbID.Text);
                taikhoan.username = tbTen.Text;
                taikhoan.password = tbPass.Text;
                taikhoan.role = Int32.Parse(tbRole.Text);               
                if (tk.UpdateTAIKHOAN(taikhoan))
                {
                    ShowAllTAIKHOAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        // Chuc nang xoa tai khoan
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TAIKHOAN taikhoan = new TAIKHOAN();

                taikhoan.UserID = Int32.Parse(tbID.Text);              
                if (tk.DeleteTAIKHOAN(taikhoan))
                {
                    tbID.Text = tbTen.Text = tbTen.Text = tbPass.Text = tbRole.Text = "";
                    ShowAllTAIKHOAN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
