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
    public partial class Form6 : Form
    {
        NhanVien nhanvien;
        public Form6()
        {
            InitializeComponent();
            nhanvien = new NhanVien();
        }
        public void ShowAllNHANVIEN()
        {
            DataTable dt = nhanvien.getAllNHANVIEN();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            // kiểm tra dữ liệu nhập trong textBox MaNV có trống không
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTen.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbDiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDiachi.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbChucvu.Text))
            {
                MessageBox.Show("Bạn chưa nhập Chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbChucvu.Focus();
                return false;

            }


            if (string.IsNullOrEmpty(tbSdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSdt.Focus();
                return false;

            }


            return true;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanVien nhanvien = new NhanVien();

                nhanvien.maNV = tbID.Text;
                nhanvien.tenNV = tbTen.Text;
                nhanvien.diaChi = tbDiachi.Text;
                nhanvien.SDT = tbSdt.Text;
                nhanvien.chucVu = tbChucvu.Text;
                if (string.IsNullOrEmpty(tbLink.Text))
                {
                    nhanvien.hinhAnh = "null";

                }
                else { nhanvien.hinhAnh = tbLink.Text; }

                if (nhanvien.InsertNHANVIEN(nhanvien))
                {
                    ShowAllNHANVIEN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.maNV = tbID.Text;
                if (nhanvien.DeleteNHANVIEN(nhanvien))
                {
                    tbID.Text = tbTen.Text = tbDiachi.Text = tbSdt.Text = tbChucvu.Text = picNV.ImageLocation = tbLink.Text = "";
                    ShowAllNHANVIEN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhanVien nhanvien = new NhanVien();

                nhanvien.maNV = tbID.Text;
                nhanvien.tenNV = tbTen.Text;
                nhanvien.diaChi = tbDiachi.Text;
                nhanvien.SDT = tbSdt.Text;
                nhanvien.chucVu = tbChucvu.Text;
                //nhanvien.hinhAnh = picNV.ImageLocation;
                if (string.IsNullOrEmpty(tbLink.Text))
                {
                    nhanvien.hinhAnh = "null";

                }
                else { nhanvien.hinhAnh = tbLink.Text; }
                if (nhanvien.UpdateNHANVIEN(nhanvien))
                {
                    ShowAllNHANVIEN();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID.Text = tbTen.Text = tbDiachi.Text = tbSdt.Text = tbChucvu.Text = picNV.ImageLocation = tbLink.Text = "";
            tbID.Focus();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;
            if (rno < dataGridView1.RowCount - 2)
            {
                rno++;

                tbID.Text = dataGridView1.Rows[rno].Cells["maNV"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenNV"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[rno].Cells["diaChi"].Value.ToString();
                tbSdt.Text = dataGridView1.Rows[rno].Cells["SDT"].Value.ToString();
                tbChucvu.Text = dataGridView1.Rows[rno].Cells["chucVu"].Value.ToString();
                picNV.ImageLocation = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("nhân viên cuối"); }
        }

        private void btprev_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;

            if (rno > 0)
            {
                rno--;
                tbID.Text = dataGridView1.Rows[rno].Cells["maNV"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[rno].Cells["tenNV"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[rno].Cells["diaChi"].Value.ToString();
                tbSdt.Text = dataGridView1.Rows[rno].Cells["SDT"].Value.ToString();
                tbChucvu.Text = dataGridView1.Rows[rno].Cells["chucVu"].Value.ToString();
                picNV.ImageLocation = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[rno].Cells["hinhAnh"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("nhân viên đầu"); }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ShowAllNHANVIEN();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbID.Text = dataGridView1.Rows[index].Cells["maNV"].Value.ToString();
                tbTen.Text = dataGridView1.Rows[index].Cells["tenNV"].Value.ToString();
                tbDiachi.Text = dataGridView1.Rows[index].Cells["diaChi"].Value.ToString();
                tbSdt.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                tbChucvu.Text = dataGridView1.Rows[index].Cells["chucVu"].Value.ToString();
                tbLink.Text = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();
                picNV.ImageLocation = dataGridView1.Rows[index].Cells["hinhAnh"].Value.ToString();

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }
    }
}
