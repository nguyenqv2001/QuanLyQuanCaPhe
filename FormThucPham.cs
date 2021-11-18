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
        NThucPham tp;
        public FormThucPham()
        {
            InitializeComponent();
            tp = new NThucPham();
        }
        public void ShowAllTP()
        {
            DataTable dt = tp.getAllTP();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            // kiểm tra dữ liệu nhập trong textBox MaNV có trống không
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã thực phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên thực phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTen.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbDonvi.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDonvi.Focus();
                return false;

            }


            if (string.IsNullOrEmpty(tbNSX.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNSX.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbHSD.Text))
            {
                MessageBox.Show("Bạn chưa nhập hạn sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbHSD.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbID_NCC.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID_NCC.Focus();
                return false;

            }

            return true;
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NThucPham tp = new NThucPham();

                tp.maTP = tbID.Text;
                tp.tenTP = tbTen.Text;
                tp.DVT = tbDonvi.Text;
                tp.NSX = DateTime.Parse(tbNSX.Text);
                tp.HSD = DateTime.Parse(tbHSD.Text);
                tp.maNCC = tbID_NCC.Text;

                if (tp.InsertTP(tp))
                {
                    ShowAllTP();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Hide();
            form7.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NThucPham tp = new NThucPham();

                tp.maTP = tbID.Text;
                tp.tenTP = tbTen.Text;
                tp.DVT = tbDonvi.Text;
                tp.NSX = DateTime.Parse(tbNSX.Text);
                tp.HSD = DateTime.Parse(tbHSD.Text);
                tp.maNCC = tbID_NCC.Text;

                if (tp.UpdateTP(tp))
                {
                    ShowAllTP();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;

            if (rno > 0)
            {
                rno--;
                tbID.Text = dataGridView1.Rows[rno].Cells["maThucPham"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenThucPham"].Value.ToString();
                tbDonvi.Text = dataGridView1.Rows[rno].Cells["donViTinh"].Value.ToString();
                tbNSX.Text = dataGridView1.Rows[rno].Cells["NSX"].Value.ToString();
                tbHSD.Text = dataGridView1.Rows[rno].Cells["HSD"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("thực phẩm đầu"); }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;
            if (rno < dataGridView1.RowCount - 2)
            {
                rno++;

                tbID.Text = dataGridView1.Rows[rno].Cells["maThucPham"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenThucPham"].Value.ToString();
                tbDonvi.Text = dataGridView1.Rows[rno].Cells["donViTinh"].Value.ToString();
                tbNSX.Text = dataGridView1.Rows[rno].Cells["NSX"].Value.ToString();
                tbHSD.Text = dataGridView1.Rows[rno].Cells["HSD"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("thực phẩm cuối"); }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NThucPham tp = new NThucPham();
                tp.maTP = tbID.Text;
                if (tp.DeleteTP(tp))
                {
                    tbID.Text = tbTen.Text = tbNSX.Text = tbHSD.Text = tbDonvi.Text = tbID_NCC.Text = "";
                    ShowAllTP();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbNSX.Text = tbHSD.Text = tbDonvi.Text = tbID_NCC.Text = "";
            tbID.Focus();
        }

        private void FormThucPham_Load(object sender, EventArgs e)
        {
            ShowAllTP();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbID.Text = dataGridView1.Rows[index].Cells["maThucPham"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[index].Cells["tenThucPham"].Value.ToString();
                tbDonvi.Text = dataGridView1.Rows[index].Cells["donViTinh"].Value.ToString();
                tbNSX.Text = dataGridView1.Rows[index].Cells["NSX"].Value.ToString();
                tbHSD.Text = dataGridView1.Rows[index].Cells["HSD"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[index].Cells["maNCC"].Value.ToString();

            }
        }
    }
}
