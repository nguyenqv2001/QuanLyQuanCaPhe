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
        NhaCungCap ncc;
        public FormNCC()
        {
            InitializeComponent();
            ncc = new NhaCungCap();
        }

        public void ShowAllNCC()
        {
            DataTable dt = ncc.getAllNCC();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            // kiểm tra dữ liệu nhập trong textBox MaNV có trống không
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTen.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbDiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiachi.Focus();
                return false;

            }


            if (string.IsNullOrEmpty(tbSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSDT.Focus();
                return false;

            }

            return true;
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

        private void btThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhaCungCap ncc = new NhaCungCap();

                ncc.maNCC = tbID.Text;
                ncc.tenNCC = tbTen.Text;
                ncc.diaChi = tbDiachi.Text;
                ncc.SDT = tbSDT.Text;

                if (string.IsNullOrEmpty(tbLink.Text))
                {
                    ncc.hinhAnh = "null";

                }
                else { ncc.hinhAnh = tbLink.Text; }

                if (ncc.InsertNCC(ncc))
                {
                    ShowAllNCC();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.maNCC = tbID.Text;
                if (ncc.DeleteNCC(ncc))
                {
                    tbID.Text = tbTen.Text = tbDiachi.Text = tbSDT.Text = picNcc.ImageLocation = tbLink.Text = "";
                    ShowAllNCC();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhaCungCap ncc = new NhaCungCap();

                ncc.maNCC = tbID.Text;
                ncc.tenNCC = tbTen.Text;
                ncc.diaChi = tbDiachi.Text;
                ncc.SDT = tbSDT.Text;

                if (string.IsNullOrEmpty(tbLink.Text))
                {
                    ncc.hinhAnh = "null";

                }
                else { ncc.hinhAnh = tbLink.Text; }

                if (ncc.UpdateNCC(ncc))
                {
                    ShowAllNCC();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbSDT.Text = tbDiachi.Text = tbLink.Text = "";
            tbID.Focus();
        }

        private void btprev_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;

            if (rno > 0)
            {
                rno--;
                tbID.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenNCC"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[rno].Cells["diaChi"].Value.ToString();
                tbSDT.Text = dataGridView1.Rows[rno].Cells["SDT"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                picNcc.ImageLocation = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("nhà cung cấp đầu"); }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;
            if (rno < dataGridView1.RowCount - 2)
            {
                rno++;

                tbID.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenNCC"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[rno].Cells["diaChi"].Value.ToString();
                tbSDT.Text = dataGridView1.Rows[rno].Cells["SDT"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                picNcc.ImageLocation = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("nhà cung cấp cuối"); }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Hide();
            form7.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbID.Text = dataGridView1.Rows[index].Cells["maNCC"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[index].Cells["tenNCC"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[index].Cells["diaChi"].Value.ToString();
                tbSDT.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();
                picNcc.ImageLocation = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();

            }
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            ShowAllNCC();
        }
    }
}
