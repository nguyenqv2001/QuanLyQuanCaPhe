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
    public partial class Form8 : Form
    {
        
        public Form8()
        {           
            InitializeComponent();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tìmKiếmMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemMonAn tkma = new TimKiemMonAn();
            tkma.Show();

        }

        private void tìmKiếmThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemThucPham tktp = new TimKiemThucPham();
            tktp.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThuTheoNgay tkdt = new ThongKeDoanhThuTheoNgay();
            tkdt.Show();
        }

        private void thốngKêThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeThucPham tktp = new ThongKeThucPham();
            tktp.Show();
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoHoaDon thd = new TaoHoaDon();
            thd.Show();
        }

        private void tạoHóaĐơnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoHoaDonChiTiet thdct = new TaoHoaDonChiTiet();
            thdct.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang tkkh = new TimKiemKhachHang();
            Hide();
            tkkh.Show();
        }

        private void buttonTimKiemMonAn_Click(object sender, EventArgs e)
        {
            TimKiemMonAn tkma = new TimKiemMonAn();
            Hide();
            tkma.Show();
        }

        private void buttonTimKiemThucPham_Click(object sender, EventArgs e)
        {
            TimKiemThucPham tktp = new TimKiemThucPham();
            Hide();
            tktp.Show();
        }
        // button thoat
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2b f2b = new Form2b();
            Hide();
            f2b.ShowDialog();
        }

        private void buttonTimKiemPhieuThanhToanTheoNgay_Click(object sender, EventArgs e)
        {
            TimKiemPhieuThanhToan tkptt = new TimKiemPhieuThanhToan();
            Hide();
            tkptt.Show();
        }
    }
}
