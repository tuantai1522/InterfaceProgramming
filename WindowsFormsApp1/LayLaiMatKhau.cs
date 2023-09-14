using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LayLaiMatKhau : Form
    {
        public LayLaiMatKhau()
        {
            InitializeComponent();
        }
        private void LayLaiMatKhau_Load(object sender, EventArgs e)
        {
            cbLuaChon.Items.Add("Email");
            cbLuaChon.Items.Add("Tên tài khoản");

            cbLuaChon.SelectedIndex = 0;
        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            bool Check = false;
            if (cbLuaChon.SelectedIndex == 0)
            {
                for (int i = 0; i < DanhSachNguoiDung.ListNguoiDung.Count; ++i)
                {
                    if (txtDuLieu.Text == DanhSachNguoiDung.ListNguoiDung[i].Email1)
                    {
                        txtKetQua.Text = DanhSachNguoiDung.ListNguoiDung[i].MatKhau1;
                        Check = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DanhSachNguoiDung.ListNguoiDung.Count; ++i)
                {
                    if (txtDuLieu.Text == DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1)
                    {
                        txtKetQua.Text = DanhSachNguoiDung.ListNguoiDung[i].MatKhau1;
                        Check = true;
                        break;
                    }
                }
            }

            if (Check == false)
            {
                txtKetQua.Text = "Không tim thấy";
            }
        }



        

        private void LayLaiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
