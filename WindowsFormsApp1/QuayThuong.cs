using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class QuayThuong : Form
    {
        public QuayThuong()
        {
            InitializeComponent();
        }

        private void QuayThuong_Load(object sender, EventArgs e)
        {
            lvVeDaMua.BackColor = Color.FromArgb(131, 76, 107);
            lvKetQua.BackColor = Color.FromArgb(131, 76, 107);


            //Form quay số
            cbLuaChon.Items.Add("Quay 3 số");
            cbLuaChon.Items.Add("Quay 4 số");
            cbLuaChon.Items.Add("Quay 5 số");
            cbLuaChon.SelectedIndex = 0;

            tcMenu.SelectedIndex = 0;

            //Form lịch sử đặt cược
            cbSapXep.Items.Add("Ngày mua");
            cbSapXep.Items.Add("Tên");
            cbSapXep.SelectedIndex = 0;

            lvVeDaMua.Clear();
            lvVeDaMua.GridLines = true;
            lvVeDaMua.FullRowSelect = true;
            lvVeDaMua.View = View.Details;
            lvVeDaMua.Columns.Add("Tên tài khoản", 180, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Ngày mua", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Số lượng vé", 150, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Các số được chọn", 200, HorizontalAlignment.Center);

            //Form thống kê kết quả
            cbLoaive.Items.Add("Tất cả");
            cbLoaive.Items.Add("3 vé");
            cbLoaive.Items.Add("4 vé");
            cbLoaive.Items.Add("5 vé");
            cbLoaive.SelectedIndex = 0;

            lvKetQua.Clear();
            lvKetQua.View = View.Details;
            lvKetQua.FullRowSelect = true;
            lvKetQua.GridLines = true;
            lvKetQua.Columns.Add("Tên tài khoản", 150, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Số vé", 100, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Ngày mua", 150, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Thông tin trúng", 200, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Số tiền trúng", 180, HorizontalAlignment.Center);



        }


        //Form Quay số
        private void cbLuaChon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbLuaChon.SelectedIndex == 0)
            {
                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                txtSo4.Clear();
                txtSo5.Clear();
                txtSo4.Visible = false;
                txtSo5.Visible = false;
            }
            else if (cbLuaChon.SelectedIndex == 1)
            {
                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                txtSo4.Clear();
                txtSo5.Clear();
                txtSo4.Visible = true;
                txtSo5.Visible = false;

            }
            else
            {
                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                txtSo4.Clear();
                txtSo5.Clear();
                txtSo4.Visible = true;
                txtSo5.Visible = true;

            }
        }

        private void ThemVaoListQuaySo(int LuaChon)
        {
            GiaiThuong Prize = new GiaiThuong();

            Prize.NgayMua1 = DateTime.Now.Date;

            Prize.LoaiVe1 = LuaChon;

            List<int> VeTrungThuong = new List<int>();
            VeTrungThuong.Add(int.Parse(txtSo1.Text));
            VeTrungThuong.Add(int.Parse(txtSo2.Text));
            VeTrungThuong.Add(int.Parse(txtSo3.Text));

            if (txtSo4.Visible)
            {
                VeTrungThuong.Add(int.Parse(txtSo4.Text));
            }


            if (txtSo4.Visible && txtSo5.Visible)
            {
                VeTrungThuong.Add(int.Parse(txtSo5.Text));
            }


            Prize.ThongTinVeTrungThuong1 = VeTrungThuong;

            Random rd = new Random();
            //Chỉ có 3 số được chọn
            if (txtSo4.Visible == false && txtSo5.Visible == false)
            {
                double SoTienTrung = rd.Next(2000000, 3000000);
                Prize.SoTienTrung1 = SoTienTrung;

            }


            //Có 4 số được chọn
            if (txtSo4.Visible == true && txtSo5.Visible == false)
            {
                double SoTienTrung = rd.Next(3000000, 4000000);
                Prize.SoTienTrung1 = SoTienTrung;

            }

            //Có 5 số được chọn
            if (txtSo4.Visible == true && txtSo5.Visible == true)
            {
                double SoTienTrung = rd.Next(4000000, 5000000);
                Prize.SoTienTrung1 = SoTienTrung;
            }

            DanhSachGiaiThuong.ListGiaiThuong1.Add(Prize);

            string directoryPath = Application.StartupPath + @"\GiaiThuong.TXT";

            FileStream fs = null;
            fs = new FileStream(directoryPath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, DanhSachGiaiThuong.ListGiaiThuong1);
            fs.Close();

            MessageBox.Show("Bạn đã quay số thành công", "Thông báo", MessageBoxButtons.OK);
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int So1 = rd.Next(0, 99);
            int So2 = rd.Next(0, 99);
            int So3 = rd.Next(0, 99);
            int So4 = rd.Next(0, 99);
            int So5 = rd.Next(0, 99);

            txtSo1.Text = So1.ToString();
            txtSo2.Text = So2.ToString();
            txtSo3.Text = So3.ToString();
            if (txtSo4.Visible)
            {
                txtSo4.Text = So4.ToString();
            }

            if (txtSo4.Visible && txtSo5.Visible)
            {
                txtSo5.Text = So5.ToString();
            }

            ThemVaoListQuaySo(cbLuaChon.SelectedIndex + 3);
        }


        //Form lịch sử đặt cược
        private void SapXepTheoNgay()
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
        private void SapXepTheoTen()
        {
            for (int i = 0; i < DanhSachVeDatMua.ListVeDatMua1.Count - 1; ++i)
            {
                for (int j = i + 1; j < DanhSachVeDatMua.ListVeDatMua1.Count; ++j)
                {

                    if (DanhSachVeDatMua.ListVeDatMua1[i].TenTaiKhoan1[0] > DanhSachVeDatMua.ListVeDatMua1[j].TenTaiKhoan1[0])
                    {
                        Ve temp = DanhSachVeDatMua.ListVeDatMua1[i];
                        DanhSachVeDatMua.ListVeDatMua1[i] = DanhSachVeDatMua.ListVeDatMua1[j];
                        DanhSachVeDatMua.ListVeDatMua1[j] = temp;
                    }

                }
            }
        }
        private void ThemVaoListViewLichSuDatCuoc(Ve Ticket)
        {
            ListViewItem item = new ListViewItem(Ticket.TenTaiKhoan1.ToString());

            item.SubItems.Add(Ticket.NgayMua1.Date.ToString("MM/dd/yyyy"));

            item.SubItems.Add(Ticket.LoaiVe1.ToString());

            item.SubItems.Add(Ticket.SoVe1.ToString());

            int temp = Ticket.ThongTinVeMua1.Count;

            string a = Ticket.ThongTinVeMua1[0].ToString();

            int j = 0;
            while (j < temp - 1)
            {
                a += " ";
                a += Ticket.ThongTinVeMua1[++j];
            }
            item.SubItems.Add(a.ToString());


            lvVeDaMua.Items.Add(item);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime NgayBatDau = dtpNgayBatDau_LSĐC.Value.Date;
            DateTime NgayKetThuc = dtpNgayKetThuc_LSĐC.Value.Date;

            lvVeDaMua.Clear();

            lvVeDaMua.GridLines = true;
            lvVeDaMua.FullRowSelect = true;
            lvVeDaMua.View = View.Details;

            lvVeDaMua.Columns.Add("Tên tài khoản", 180, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Ngày mua", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Số lượng vé", 150, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Các số được chọn", 200, HorizontalAlignment.Center);



            if (cbSapXep.SelectedIndex == 0) // Số ngày mua giảm dần
            {
                SapXepTheoNgay();
            }
            else if (cbSapXep.SelectedIndex == 1) // Tên
            {
                SapXepTheoTen();
            }
            int size = DanhSachVeDatMua.ListVeDatMua1.Count;

            if (size >  0) // khi dữ liệu chưa có ai mua thì đọc file sẽ lỗi
            {
                for (int i = 0; i < size; ++i)
                {
                    if (rdTatCa_LSĐC.Checked)
                    {
                        ThemVaoListViewLichSuDatCuoc(DanhSachVeDatMua.ListVeDatMua1[i]);
                    }
                    else if(rdLuaChon_LSĐC.Checked)
                    {
                        if (DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date >= NgayBatDau && DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date <= NgayKetThuc)
                        {
                            ThemVaoListViewLichSuDatCuoc(DanhSachVeDatMua.ListVeDatMua1[i]);
                        }
                    }
                    else if(rdToday_LSĐC.Checked)
                    {
                        if (DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date == DateTime.Now.Date)
                        {
                            ThemVaoListViewLichSuDatCuoc(DanhSachVeDatMua.ListVeDatMua1[i]);
                        }
                    }
                }
            }
        }


        //Form thống kê giải thưởng
        private bool KiemTraTrungThuong(GiaiThuong Prize, Ve Ticket)
        {
            for (int i = 0; i < Prize.ThongTinVeTrungThuong1.Count; ++i)
            {
                bool check = false;
                for (int j = 0; j < Ticket.ThongTinVeMua1.Count; ++j)
                {
                    if (Prize.ThongTinVeTrungThuong1[i] == Ticket.ThongTinVeMua1[j]) // List số được mua
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    return false;
                }
            }
            if (Prize.NgayMua1 == Ticket.NgayMua1
                && Prize.LoaiVe1 == Ticket.LoaiVe1) // Ngày mua
            {
                return true;
            }
            return false;
        }
        private void ThemVaoListViewThongKeGiaiThuong(GiaiThuong Prize, Ve Ticket)
        {
            ListViewItem item = new ListViewItem(Ticket.TenTaiKhoan1.ToString());

            item.SubItems.Add(Prize.LoaiVe1.ToString());

            item.SubItems.Add(Ticket.SoVe1.ToString());

            item.SubItems.Add(Ticket.NgayMua1.Date.ToString("MM/dd/yy"));

            int temp = Ticket.ThongTinVeMua1.Count;
            string a = Ticket.ThongTinVeMua1[0].ToString();

            for (int k = 1; k < temp; ++k)
            {
                a += " ";
                a += Ticket.ThongTinVeMua1[k];
            }

            item.SubItems.Add(a);

            item.SubItems.Add(string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Ticket.SoVe1 * Prize.SoTienTrung1));

            lvKetQua.Items.Add(item);
        }
        //Hiển thị các kết quả trúng thưởng
        private void XuLyFileKetQuaGiaiThuong()
        {
            int size_DanhSachVe = DanhSachVeDatMua.ListVeDatMua1.Count;
            int size_DanhSachTrungThuong = DanhSachGiaiThuong.ListGiaiThuong1.Count;
            DateTime NgayBatDau = dtpNgayBatDau_LSĐC.Value.Date;
            DateTime NgayKetThuc = dtpNgayKetThuc_LSĐC.Value.Date;
            for (int i = 0; i < size_DanhSachTrungThuong; ++i)
            {
                //Danh sách vé mua
                for (int j = 0; j < size_DanhSachVe; ++j)
                {
                    if (rdTatCa_TKGT.Checked)
                    {
                        if (KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j])) // List vé được mua
                        {
                            if (cbLoaive.SelectedIndex == 0)
                            {
                                ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                            }
                            else if (cbLoaive.SelectedIndex == 1)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 3)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }

                            }
                            else if (cbLoaive.SelectedIndex == 2)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 4)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }
                            else
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 5)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }

                        }
                    }
                    else if (rdLuaChon_TKGT.Checked)
                    {
                        if ((DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1 >= NgayBatDau && DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1 <= NgayKetThuc)
                            && KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]))
                        {
                            if (cbLoaive.SelectedIndex == 0)
                            {
                                ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                            }
                            else if (cbLoaive.SelectedIndex == 1)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 3)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }

                            }
                            else if (cbLoaive.SelectedIndex == 2)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 4)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }
                            else
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 5)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1 == DateTime.Now.Date)
                            && KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]))
                        {
                            if (cbLoaive.SelectedIndex == 0)
                            {
                                ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                            }
                            else if (cbLoaive.SelectedIndex == 1)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 3)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }

                            }
                            else if (cbLoaive.SelectedIndex == 2)
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 4)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }
                            else
                            {
                                if (DanhSachGiaiThuong.ListGiaiThuong1[i].LoaiVe1 == 5)
                                {
                                    ThemVaoListViewThongKeGiaiThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                                }
                            }

                        }
                    }
                }

            }
        }

        private void cbLoaive_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvKetQua.Clear();

            lvKetQua.Columns.Add("Tên tài khoản", 150, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Số vé", 100, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Ngày mua", 150, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Thông tin trúng", 200, HorizontalAlignment.Center);
            lvKetQua.Columns.Add("Số tiền trúng", 180, HorizontalAlignment.Center);

            lvKetQua.View = View.Details;
            lvKetQua.FullRowSelect = true;
            lvKetQua.GridLines = true;

            int size_DanhSachVe = DanhSachVeDatMua.ListVeDatMua1.Count;
            int size_DanhSachTrungThuong = DanhSachGiaiThuong.ListGiaiThuong1.Count;

            if (size_DanhSachTrungThuong > 0)
            {
                XuLyFileKetQuaGiaiThuong();
            }

        }



        private void QuayThuong_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
