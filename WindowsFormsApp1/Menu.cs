using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = DangNhap.TenDangNhap;
            txtSoDienThoai.Text = DangNhap.SoDienThoai;
            txtEmail.Text = DangNhap.Email;

        }



        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false; 
            }
            else
            {
                e.Cancel = true;
            }    
        }


        private void sốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mua3So Form3So = new Mua3So();
            Form3So.ShowDialog();
        }

        private void sốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mua4So Form4So = new Mua4So();
            Form4So.ShowDialog();
        }

        private void sốToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Mua5So Form5So = new Mua5So();
            Form5So.ShowDialog();
        }



        private void xemLịchSửĐặtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LichSuDatCuoc FormLichSuDatCuoc = new LichSuDatCuoc();
            FormLichSuDatCuoc.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeKetQua FormThongKeKetQua = new ThongKeKetQua();
            FormThongKeKetQua.ShowDialog();
        }

        private void LichSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuTrungThuong FormLichSuTrungThuong = new LichSuTrungThuong();
            FormLichSuTrungThuong.ShowDialog();
        }

    }
}
