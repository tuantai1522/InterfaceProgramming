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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        static public string TenDangNhap;
        static public string MatKhau;
        static public string SoDienThoai;
        static public string Email;
        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy FormDangKy = new DangKy();
            FormDangKy.Show();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu hợp lệ của txtTenDangNhap và txtMatKhau
            if (txtTenDangNhap.Text.ToLower() == "admin" && txtMatKhau.Text.ToLower() == "admin")
            {
                QuayThuong FormQuayThuong = new QuayThuong();
                FormQuayThuong.ShowDialog();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                return;
            }
            bool Check = true;

            bool CheckAccount = false;
            //Kiểm tra tên đăng nhập/Email và mật khẩu có đúng không
            for (int i = 0; i < DanhSachNguoiDung.ListNguoiDung.Count; ++i)
            {
                if ((txtTenDangNhap.Text == DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1 || txtTenDangNhap.Text == DanhSachNguoiDung.ListNguoiDung[i].Email1) && txtMatKhau.Text == DanhSachNguoiDung.ListNguoiDung[i].MatKhau1)
                {
                    CheckAccount = true;
                    TenDangNhap = DanhSachNguoiDung.ListNguoiDung[i].TenDangNhap1;
                    MatKhau = DanhSachNguoiDung.ListNguoiDung[i].MatKhau1;
                    Email = DanhSachNguoiDung.ListNguoiDung[i].Email1;
                    SoDienThoai = DanhSachNguoiDung.ListNguoiDung[i].SoDienThoai1;


                    break;
                }
            }

            if (CheckAccount == false)
            {
                MessageBox.Show("Tên đăng nhập/Email hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
            }

            if (Check && CheckAccount)
            {
                Menu FormMenu = new Menu();
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                FormMenu.ShowDialog();
            }

        }

        private void linkLayLaiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LayLaiMatKhau FormLayLaiMatKhau = new LayLaiMatKhau();
            FormLayLaiMatKhau.Show();
        }

        private void DocFileDanhSachThongTinNguoiDung()
        {
            string directoryPath = Application.StartupPath + @"\ThongTinNguoiDung.TXT";

            if (File.Exists(directoryPath))
            {
                // Ghi chưa có người dùng nào
                if (new FileInfo(directoryPath).Length > 0)
                {
                    FileStream fs = new FileStream(directoryPath, FileMode.Open);

                    BinaryFormatter bf = new BinaryFormatter();

                    object data = bf.Deserialize(fs);

                    DanhSachNguoiDung.ListNguoiDung = data as List<NguoiDung>;

                    fs.Close();
                }
            }


        }
        private void DocFileDanhSachVeDaMua()
        {
            string directoryPath = Application.StartupPath + @"\DanhSachVeDaMua.TXT";

            if (File.Exists(directoryPath))
            {
                // Ghi chưa có người dùng nào
                if (new FileInfo(directoryPath).Length > 0)
                {
                    FileStream fs = new FileStream(directoryPath, FileMode.Open);

                    BinaryFormatter bf = new BinaryFormatter();

                    object data = bf.Deserialize(fs);

                    DanhSachVeDatMua.ListVeDatMua1 = data as List<Ve>;

                    fs.Close();
                }
            }
        }
        private void DocFileDanhSachGiaiThuong()
        {
            string directoryPath = Application.StartupPath + @"\GiaiThuong.TXT";

            if (File.Exists(directoryPath))
            {
                // Ghi chưa có người dùng nào
                if (new FileInfo(directoryPath).Length > 0)
                {
                    FileStream fs = new FileStream(directoryPath, FileMode.Open);

                    BinaryFormatter bf = new BinaryFormatter();

                    object data = bf.Deserialize(fs);

                    DanhSachGiaiThuong.ListGiaiThuong1 = data as List<GiaiThuong>;

                    fs.Close();
                }
            }
        }
        private void SapXepTheoNgayDanhSachVeDatMua()
        {
            //0: tăng dần
            //1: giảm dần
            for (int i = 0; i < DanhSachVeDatMua.ListVeDatMua1.Count - 1; ++i)
            {
                for (int j = i + 1; j < DanhSachVeDatMua.ListVeDatMua1.Count; ++j)
                {
                    if (DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date < DanhSachVeDatMua.ListVeDatMua1[j].NgayMua1.Date)
                    {
                        Ve temp = DanhSachVeDatMua.ListVeDatMua1[i];
                        DanhSachVeDatMua.ListVeDatMua1[i] = DanhSachVeDatMua.ListVeDatMua1[j];
                        DanhSachVeDatMua.ListVeDatMua1[j] = temp;

                    }
                }

            }
        }

        private void SapXepTheoNgayDanhSachGiaiThuong()
        {
            //0: tăng dần
            //1: giảm dần
            for (int i = 0; i < DanhSachGiaiThuong.ListGiaiThuong1.Count - 1; ++i)
            {
                for (int j = i + 1; j < DanhSachGiaiThuong.ListGiaiThuong1.Count; ++j)
                {
                    if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date < DanhSachGiaiThuong.ListGiaiThuong1[j].NgayMua1.Date)
                    {
                        GiaiThuong temp = DanhSachGiaiThuong.ListGiaiThuong1[i];
                        DanhSachGiaiThuong.ListGiaiThuong1[i] = DanhSachGiaiThuong.ListGiaiThuong1[j];
                        DanhSachGiaiThuong.ListGiaiThuong1[j] = temp;

                    }
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DocFileDanhSachThongTinNguoiDung();

            DocFileDanhSachGiaiThuong();

            DocFileDanhSachVeDaMua();

            SapXepTheoNgayDanhSachVeDatMua();

            SapXepTheoNgayDanhSachGiaiThuong();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }    
            else
            {
                e.Cancel = true;
            }    
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                btnDangNhap.Enabled = true;
            }    
            else
            {
                btnDangNhap.Enabled = false;
            }    
        }

    }
}
