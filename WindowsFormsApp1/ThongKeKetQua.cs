using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ThongKeKetQua : Form
    {
        public ThongKeKetQua()
        {
            InitializeComponent();
        }

        private void ThemVaoListView(GiaiThuong Prize)
        {
            ListViewItem item = new ListViewItem(Prize.NgayMua1.ToString("MM/dd/yyyy"));

            item.SubItems.Add(Prize.LoaiVe1.ToString() + " vé");

            int temp = Prize.ThongTinVeTrungThuong1.Count;

            string a = Prize.ThongTinVeTrungThuong1[0].ToString();

            int j = 0;
            while (j < temp - 1)
            {
                a += " ";
                a += Prize.ThongTinVeTrungThuong1[++j];
            }

            item.SubItems.Add(a.ToString());

            item.SubItems.Add(string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", Prize.SoTienTrung1));


            lvThongKe.Items.Add(item);
        }

        //Sắp xếp theo ngày tăng dần
        private void SapXepTheoNgay()
        {
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
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lvThongKe.Clear();

            lvThongKe.Columns.Add("Ngày quay", 180, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Hạng mục", 150, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Kết quả", 200, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Số tiền trúng", 170, HorizontalAlignment.Center);

            lvThongKe.View = View.Details;
            lvThongKe.GridLines = true;
            lvThongKe.FullRowSelect = true;

            int size = DanhSachGiaiThuong.ListGiaiThuong1.Count;
            DateTime NgayBatDau = dtpNgayBatDau.Value;
            DateTime NgayKetThuc = dtpNgayKetThuc.Value;


            if (size > 0)
            {
                SapXepTheoNgay();
                for (int i = 0; i < size; ++i)
                {
                    
                    if (rdAll.Checked)
                    {
                        ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                    }
                    else if (rdLuaChon.Checked)
                    {
                        if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date >= NgayBatDau.Date && DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date <= NgayKetThuc.Date)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                        }
                    }
                    else
                    {
                        if (DanhSachGiaiThuong.ListGiaiThuong1[i].NgayMua1.Date == DateTime.Now.Date)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i]);
                        }
                    }
                }
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(125, 213, 111);

            lvThongKe.BackColor = Color.FromArgb(224, 164, 105);

            lvThongKe.Columns.Add("Ngày quay", 180, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Hạng mục", 150, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Kết quả", 200, HorizontalAlignment.Center);
            lvThongKe.Columns.Add("Số tiền trúng", 170, HorizontalAlignment.Center);

            lvThongKe.View = View.Details;
            lvThongKe.GridLines = true;
            lvThongKe.FullRowSelect = true;
        }
    }

}
