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
        NhapNguyenLieuBLL nlbll;
        public FormNNL()
        {
            InitializeComponent();
            nlbll = new NhapNguyenLieuBLL();
        }
        public void ShowAllNNL()
        {
            DataTable dt = nlbll.getAllNNL();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            
            if (string.IsNullOrEmpty(tbID_phieunhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID_phieunhap.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbID_NCC.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID_NCC.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbID_NV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbID_NV.Focus();
                return false;

            }


            if (string.IsNullOrEmpty(tbNgaynhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày nhập hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNgaynhap.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbDongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá nguyên liệu .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDongia.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(tbSoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng nguyên liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSoluong.Focus();
                return false;

            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                NhapNguyenLieu nl = new NhapNguyenLieu();

                nl.maPN = int.Parse(tbID_phieunhap.Text);
                nl.maNCC = tbID_NCC.Text;
                nl.maNV = tbID_NV.Text;
                nl.maTP = tbID_ThucPham.Text;
                nl.donGiaNhap = int.Parse(tbDongia.Text);
                nl.soLuong = int.Parse(tbSoluong.Text);
                nl.ngaynhap = DateTime.Parse(tbNgaynhap.Text);


                if (nlbll.InsertNNLCT(nl) && nlbll.InsertNNL(nl))
                {
                    tbID_phieunhap.Text = tbDongia.Text = tbNgaynhap.Text = tbSoluong.Text = tbID_NCC.Text = tbID_NV.Text = tbID_ThucPham.Text = tbTong.Text = "";
                    ShowAllNNL();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                NhapNguyenLieu nl = new NhapNguyenLieu();

                nl.maPN = int.Parse(tbID_phieunhap.Text);
                nl.maNCC = tbID_NCC.Text;
                nl.maNV = tbID_NV.Text;
                nl.maTP = tbID_ThucPham.Text;
                nl.donGiaNhap = int.Parse(tbDongia.Text);
                nl.soLuong = int.Parse(tbSoluong.Text);
                nl.ngaynhap = DateTime.Parse(tbNgaynhap.Text);


                if (nlbll.UpdateNNL(nl) && nlbll.UpdateNNLCT(nl))
                {
                    tbID_phieunhap.Text = tbDongia.Text = tbNgaynhap.Text = tbSoluong.Text = tbID_NCC.Text = tbID_NV.Text = tbID_ThucPham.Text = tbTong.Text = "";
                    ShowAllNNL();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btprev_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;

            if (rno > 0)
            {
                rno--;
                tbID_phieunhap.Text = dataGridView1.Rows[rno].Cells["maPhieuNhap"].Value.ToString();
                tbNgaynhap.Text = dataGridView1.Rows[rno].Cells["ngayNhap"].Value.ToString();
                tbID_NV.Text = dataGridView1.Rows[rno].Cells["maNV"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                tbID_ThucPham.Text = dataGridView1.Rows[rno].Cells["maThucPham"].Value.ToString();
                tbDongia.Text = dataGridView1.Rows[rno].Cells["donGiaNhap"].Value.ToString();
                tbSoluong.Text = dataGridView1.Rows[rno].Cells["soLuong"].Value.ToString();
                tbTong.Text = dataGridView1.Rows[rno].Cells["ThanhTien"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("phiếu nhập đầu"); }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            int rno = dataGridView1.CurrentCell.RowIndex;
            if (rno < dataGridView1.RowCount - 2)
            {
                rno++;

                tbID_phieunhap.Text = dataGridView1.Rows[rno].Cells["maPhieuNhap"].Value.ToString();
                tbNgaynhap.Text = dataGridView1.Rows[rno].Cells["ngayNhap"].Value.ToString();
                tbID_NV.Text = dataGridView1.Rows[rno].Cells["maNV"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[rno].Cells["maNCC"].Value.ToString();
                tbID_ThucPham.Text = dataGridView1.Rows[rno].Cells["maThucPham"].Value.ToString();
                tbDongia.Text = dataGridView1.Rows[rno].Cells["donGiaNhap"].Value.ToString();
                tbSoluong.Text = dataGridView1.Rows[rno].Cells["soLuong"].Value.ToString();
                tbTong.Text = dataGridView1.Rows[rno].Cells["ThanhTien"].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, rno];
            }
            else
            { MessageBox.Show("phiếu nhập cuối"); }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhapNguyenLieu nl = new NhapNguyenLieu();
                nl.maPN = int.Parse(tbID_phieunhap.Text);
                if (nlbll.DeleteNNL(nl) && nlbll.DeleteNNLCT(nl))
                {
                    tbID_phieunhap.Text = tbDongia.Text = tbNgaynhap.Text = tbSoluong.Text = tbID_NCC.Text = tbID_NV.Text = tbID_ThucPham.Text = tbTong.Text = "";
                    ShowAllNNL();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi , xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbID_phieunhap.Text = tbDongia.Text = tbNgaynhap.Text = tbSoluong.Text = tbID_NCC.Text = tbID_NV.Text = tbID_ThucPham.Text = tbTong.Text = "";
            tbID_phieunhap.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            Hide();
            form7.ShowDialog();
        }

        private void FormNNL_Load(object sender, EventArgs e)
        {
            ShowAllNNL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbID_phieunhap.Text = dataGridView1.Rows[index].Cells["maPhieuNhap"].Value.ToString();
                tbNgaynhap.Text = dataGridView1.Rows[index].Cells["ngayNhap"].Value.ToString();
                tbID_NV.Text = dataGridView1.Rows[index].Cells["maNV"].Value.ToString();
                tbID_NCC.Text = dataGridView1.Rows[index].Cells["maNCC"].Value.ToString();
                tbID_ThucPham.Text = dataGridView1.Rows[index].Cells["maThucPham"].Value.ToString();
                tbDongia.Text = dataGridView1.Rows[index].Cells["donGiaNhap"].Value.ToString();
                tbSoluong.Text = dataGridView1.Rows[index].Cells["soLuong"].Value.ToString();
                tbTong.Text = dataGridView1.Rows[index].Cells["ThanhTien"].Value.ToString();

            }
        }
    }
}
