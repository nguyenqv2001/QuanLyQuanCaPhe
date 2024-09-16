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
    public partial class TaoHoaDonChiTiet : Form
    {
        HOADON hd = new HOADON();
        MONAN ma = new MONAN();
        MY_DB mydb = new MY_DB();
        BAN b = new BAN();
        HOADONCHITIET hdct = new HOADONCHITIET();
        public TaoHoaDonChiTiet()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tenMonAn = comboBoxMaMon.SelectedValue.ToString();
                textBoxTenMon.Text = tenMonAn;

            }
            catch
            {

                textBoxTenMon.Text = "";

            }

        }

        /*public void ShowComboboxMaMonAn()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM MonAn", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaMon.DataSource = table;
            comboBoxMaMon.DisplayMember = "maMon";
            comboBoxMaMon.ValueMember = "tenMon";

        }*/

        private void dateTimePickerNgayThanhToan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string maPhieuYeuCau = (comboBoxMaPhieuYeuCau.SelectedValue).ToString();
            string maMon = textBoxMaMon.Text;
            //string maMon = (comboBoxMaMon.SelectedValue).ToString();
            string tenMon = textBoxTenMon.Text;
            int donGiaMon = Convert.ToInt32(textBoxDonGiaMon.Text);
            string maBan = (comboBoxMaBan.SelectedValue).ToString();
            int donGiaBan = Convert.ToInt32(textBoxDonGiaBan.Text);
            DateTime ngayThanhToan = dateTimePickerNgayThanhToan.Value;
            int soLuongMon = Convert.ToInt32(textBoxSoLuongMon.Text);
            int soLuongBan = Convert.ToInt32(textBoxSoLuongBan.Text);
            /*try
            {
                if (hdct.checkHoaDonChiTiet(maPhieuYeuCau) == false)
                {
                    MessageBox.Show("Hóa đơn này đã tồn tại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hdct.insertHoaDonChiTiet(maPhieuYeuCau, maMon, tenMon, donGiaMon, maBan, donGiaBan, ngayThanhToan, soLuongMon, soLuongBan))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hóa đơn đã tồn tại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
            if (hdct.checkHoaDonChiTiet(maPhieuYeuCau) == false)
            {
                MessageBox.Show("Hóa đơn này đã tồn tại", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (hdct.insertHoaDonChiTiet(maPhieuYeuCau, maMon, tenMon, donGiaMon, maBan, donGiaBan, ngayThanhToan, soLuongMon, soLuongBan))
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thêm hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void fillComboMaPhieuYeuCau(int index)
        {
            comboBoxMaPhieuYeuCau.DataSource = hd.getHoaDon();
            comboBoxMaPhieuYeuCau.DisplayMember = "maPhieuYeuCau";
            comboBoxMaPhieuYeuCau.ValueMember = "maPhieuYeuCau";
            comboBoxMaPhieuYeuCau.SelectedItem = index;
        }

        public void fillComboMaMon(int index)
        {
            comboBoxMaMon.DataSource = ma.getMonAn2();
            comboBoxMaMon.DisplayMember = "maMon";
            comboBoxMaMon.ValueMember = "maMon";
            comboBoxMaMon.SelectedItem = null;
        }

        private void TaoHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            comboBoxMaMon.DataSource = ma.getMonAn2();
            comboBoxMaMon.DisplayMember = "maMon";
            comboBoxMaMon.ValueMember = "tenMon";
            comboBoxMaMon.SelectedItem = null;
            //ShowComboboxMaMonAn();

            comboBoxMaPhieuYeuCau.DataSource = hd.getHoaDon();
            comboBoxMaPhieuYeuCau.DisplayMember = "maPhieuYeuCau";
            comboBoxMaPhieuYeuCau.ValueMember = "maPhieuYeuCau";
            comboBoxMaPhieuYeuCau.SelectedItem = null;

            comboBoxMaBan.DataSource = b.getBan();
            comboBoxMaBan.DisplayMember = "maBan";
            comboBoxMaBan.ValueMember = "maBan";
            comboBoxMaBan.SelectedItem = null;


        }

        private void comboBoxMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tenMonAn = comboBoxMaMon.SelectedValue.ToString();
                textBoxTenMon.Text = tenMonAn;

            }
            catch
            {

                textBoxTenMon.Text = "";

            }
        }
    }
}
