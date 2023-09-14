using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]

    class Ve
    {
        private string TenTaiKhoan;
        private DateTime NgayMua;
        private int LoaiVe;
        private int SoVe;
        private List<int>ThongTinVeMua = new List<int>();

        public Ve()
        {
            TenTaiKhoan = "";
            ThongTinVeMua = null;
            NgayMua = new DateTime(2000, 1, 1);
            SoVe = 0;
            LoaiVe = 0;
        }

        public Ve(string tenTaiKhoan, DateTime ngayMua, int loaiVe, int soVe, List<int> thongTinVeMua)
        {
            TenTaiKhoan = tenTaiKhoan;
            NgayMua = ngayMua;
            LoaiVe = loaiVe;
            SoVe = soVe;
            ThongTinVeMua1 = thongTinVeMua;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public DateTime NgayMua1 { get => NgayMua; set => NgayMua = value; }
        public int SoVe1 { get => SoVe; set => SoVe = value; }
        public List<int> ThongTinVeMua1 { get => ThongTinVeMua; set => ThongTinVeMua = value; }
        public int LoaiVe1 { get => LoaiVe; set => LoaiVe = value; }
    }
}
