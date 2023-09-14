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
    public partial class LichSuTrungThuong : Form
    {
        public LichSuTrungThuong()
        {
            InitializeComponent();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(125, 213, 111);

            lvKetQua.BackColor = Color.FromArgb(180, 142, 206);

            cbLuaChon.Items.Add("Tất cả");
            cbLuaChon.Items.Add("3 vé");
            cbLuaChon.Items.Add("4 vé");
            cbLuaChon.Items.Add("5 vé");

            cbLuaChon.SelectedIndex = 0;

        }
        private bool KiemTraTrungThuong(GiaiThuong Prize, Ve Ticket, int LuaChon)
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
            if (cbLuaChon.SelectedIndex == LuaChon
                && Prize.NgayMua1 == Ticket.NgayMua1 // Ngày mua
                && DangNhap.TenDangNhap == Ticket.TenTaiKhoan1
                && Prize.LoaiVe1 == Ticket.LoaiVe1) // Tài khoản mua)
            {
                return true;
            }
            return false;
        }

        private void ThemVaoListView(GiaiThuong Prize, Ve Ticket)
        {
            ListViewItem item = new ListViewItem(Ticket.LoaiVe1.ToString());

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

        private void cbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvKetQua.Clear();

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


            //Danh sách trúng thưởng
            for (int i = 0; i < size_DanhSachTrungThuong; ++i)
            {
                //Danh sách vé mua
                for (int j = 0; j < size_DanhSachVe; ++j)
                {
                    if (KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j], 0)) // List vé được mua
                    {
                        ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                    }
                    else if (KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j], 1)) // List vé được mua
                    {
                        if (DanhSachVeDatMua.ListVeDatMua1[j].LoaiVe1 == 3)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                        }
                    }
                    else if (KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j], 2)) // List vé được mua
                    {
                        if (DanhSachVeDatMua.ListVeDatMua1[j].LoaiVe1 == 4)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                        }
                    }
                    else if (KiemTraTrungThuong(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j], 3)) // List vé được mua
                    {
                        if (DanhSachVeDatMua.ListVeDatMua1[j].LoaiVe1 == 5)
                        {
                            ThemVaoListView(DanhSachGiaiThuong.ListGiaiThuong1[i], DanhSachVeDatMua.ListVeDatMua1[j]);
                        }
                    }
                }
            }
        }

    }
}
