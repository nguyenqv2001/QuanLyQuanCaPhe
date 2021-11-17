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
    public partial class TaoHoaDon : Form
    {
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            comboBoxKhachHang.DataSource = kh.getKhachHang2();
            comboBoxKhachHang.DisplayMember = "tenKH";
            comboBoxKhachHang.ValueMember = "maKH";
            comboBoxKhachHang.SelectedItem = null;

            comboBoxNhanVien.DataSource = nv.getNhanVien();
            comboBoxNhanVien.DisplayMember = "tenNV";
            comboBoxNhanVien.ValueMember = "maNV";
            comboBoxNhanVien.SelectedItem = null;
        }

        HOADON hd = new HOADON();
        KHACHHANG kh = new KHACHHANG();
        NHANVIEN2 nv = new NHANVIEN2();
        private void buttonThem_Click(object sender, EventArgs e)
        {
            string maPhieuYeuCau = textBoxMaPhieuYeuCau.Text;
            string maKH = (comboBoxKhachHang.SelectedValue).ToString();
            string maNV = (comboBoxNhanVien.SelectedValue).ToString();
            DateTime ngayYeuCau = dateTimePickerNgayNhap.Value;
            try
            {
                if (hd.checkHoaDon(maPhieuYeuCau) == false)
                {
                    MessageBox.Show("Hóa đơn này đã tồn tại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hd.insertHoaDon(maPhieuYeuCau, maKH, maNV, ngayYeuCau))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hóa đơn đã tồn tại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void fillComboKhachHang(int index)
        {
            comboBoxKhachHang.DataSource = kh.getKhachHang2();
            comboBoxKhachHang.DisplayMember = "tenKH";
            comboBoxKhachHang.ValueMember = "maKH";
            comboBoxKhachHang.SelectedItem = index;
        }

        public void fillComboNhanVien(int index)
        {


            comboBoxNhanVien.DataSource = nv.getNhanVien();
            comboBoxNhanVien.DisplayMember = "tenNV";
            comboBoxNhanVien.ValueMember = "maNV";
            comboBoxNhanVien.SelectedItem = index;
        }
    }
}
