using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //Tiến hành lấy dữ liệu từ các textbox
            NguoiDung User = new NguoiDung();
            User.TenDangNhap1 = txtTenDangNhap.Text;
            User.MatKhau1 = txtMatKhau.Text;
            User.SoDienThoai1 = txtSoDienThoai.Text;
            User.Email1 = txtEmail.Text;

            bool Check = true;

            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Clear();
                txtTenDangNhap.Focus();
                Check = false;
            }

            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                Check = false;
            }

            if (txtXacNhanMatKhau.Text == "" || txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                txtXacNhanMatKhau.Clear();
                txtXacNhanMatKhau.Focus();
                Check = false;
            }

            if (txtSoDienThoai.Text == "")
            {
                txtSoDienThoai.Clear();
                txtSoDienThoai.Focus();
                Check = false;
            }

            if (txtEmail.Text == "")
            {
                txtEmail.Clear();
                txtEmail.Focus();
                Check = false;
            }
  

            //Kiểm tra trùng tên đăng nhập
            int size = DanhSachNguoiDung.ListNguoiDung.Count;
            for (int i = 0; i < size; ++i)
            {
                if (txtTenDangNhap.Text == DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1)
                {
                    MessageBox.Show("Tên đăng nhập đã bị trùng. Xin nhập lại tên khác", "Thông báo", MessageBoxButtons.OK);
                    txtTenDangNhap.Clear();
                    txtTenDangNhap.Focus();
                    Check = false;
                    break;
                }
            }

            //Kiểm tra tên đăng nhập hợp lệ (không có khoảng trống)
            if (txtTenDangNhap.Text.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ (không có khoảng trống). Xin nhập lại tên khác", "Thông báo", MessageBoxButtons.OK);
                Check = false;
            }

            //Ghi file
            string directoryPath = Application.StartupPath + @"\ThongTinNguoiDung.TXT";
            if (Check)
            {
                DanhSachNguoiDung.ListNguoiDung.Add(User);

                FileStream fs = null;
                fs = new FileStream(directoryPath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                 bf.Serialize(fs, DanhSachNguoiDung.ListNguoiDung);
                 fs.Close();


                MessageBox.Show("Đăng ký thành công. Bạn có thể đăng nhập với tài khoản này", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "" && txtXacNhanMatKhau.Text != "" && txtSoDienThoai.Text != "" && txtEmail.Text != "")
            {
                btnDangKy.Enabled = true;
            }
            else
            {
                btnDangKy.Enabled = false;
            }
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
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
