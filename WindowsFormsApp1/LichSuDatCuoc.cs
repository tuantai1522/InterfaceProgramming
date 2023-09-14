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
    public partial class LichSuDatCuoc : Form
    {
        public LichSuDatCuoc()
        {
            InitializeComponent();
        }



        private void LichSuDatCuoc_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(125, 213, 111);
            lvVeDaMua.BackColor = Color.FromArgb(125, 213, 111);

            lvVeDaMua.GridLines = true;
            lvVeDaMua.FullRowSelect = true;
            lvVeDaMua.View = View.Details;

            lvVeDaMua.Columns.Add("Ngày mua", 180, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Số lượng vé", 150, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Các số được chọn", 200, HorizontalAlignment.Center);

        }


        private void ThemVaoListView(Ve Ticket)
        {
            ListViewItem item = new ListViewItem(Ticket.NgayMua1.ToString("MM/dd/yyyy"));

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

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            lvVeDaMua.Clear();

            lvVeDaMua.GridLines = true;
            lvVeDaMua.FullRowSelect = true;
            lvVeDaMua.View = View.Details;

            lvVeDaMua.Columns.Add("Ngày mua", 180, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Số lượng vé", 150, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Các số được chọn", 200, HorizontalAlignment.Center);

            DateTime NgayBatDau = dtpNgayBatDau.Value;
            DateTime NgayKetThuc = dtpNgayKetThuc.Value;


            //Duyệt danh sách vé đã mua

            int size = DanhSachVeDatMua.ListVeDatMua1.Count;
            if (size != 0) // khi dữ liệu chưa có ai mua thì đọc file sẽ lỗi
            {
                for (int i = 0; i < size; ++i)
                {
                    ThemVaoListView(DanhSachVeDatMua.ListVeDatMua1[i]);
                }
            }
        }


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
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            lvVeDaMua.Clear();

            lvVeDaMua.GridLines = true;
            lvVeDaMua.FullRowSelect = true;
            lvVeDaMua.View = View.Details;

            lvVeDaMua.Columns.Add("Ngày mua", 180, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Loại vé", 120, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Số lượng vé", 150, HorizontalAlignment.Center);
            lvVeDaMua.Columns.Add("Các số được chọn", 200, HorizontalAlignment.Center);

            DateTime NgayBatDau = dtpNgayBatDau.Value.Date;
            DateTime NgayKetThuc = dtpNgayKetThuc.Value.Date;


            //Duyệt danh sách vé đã mua

            int size = DanhSachVeDatMua.ListVeDatMua1.Count;
            if (size != 0) // khi dữ liệu chưa có ai mua thì đọc file sẽ lỗi
            {
                for (int i = 0; i < size; ++i)
                {
                    if (rdLuaChon.Checked)
                    {
                        if ((DanhSachVeDatMua.ListVeDatMua1[i].TenTaiKhoan1 == DangNhap.TenDangNhap) && (DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date >= NgayBatDau && DanhSachVeDatMua.ListVeDatMua1[i].NgayMua1.Date <= NgayKetThuc))
                        {
                            ThemVaoListView(DanhSachVeDatMua.ListVeDatMua1[i]);
                        }
                    }
                    else
                    {
                        if ((DanhSachVeDatMua.ListVeDatMua1[i].TenTaiKhoan1 == DangNhap.TenDangNhap))
                        {
                            ThemVaoListView(DanhSachVeDatMua.ListVeDatMua1[i]);

                        }
                    }

                }
            }
        }
    }
}
