using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    [Serializable]

    class GiaiThuong
    {
        private DateTime NgayMua;
        private int LoaiVe;
        private List<int>ThongTinVeTrungThuong = new List<int>();
        private double SoTienTrung;


        public GiaiThuong()
        {
            SoTienTrung = 0;
            LoaiVe  = 0;
            NgayMua = new DateTime(2000, 1, 1);
            ThongTinVeTrungThuong1 = null;
        }

        public GiaiThuong(DateTime ngayMua, int loaiVe, List<int> thongTinVeTrungThuong, double soTienTrung)
        {
            NgayMua = ngayMua;
            LoaiVe = loaiVe;
            ThongTinVeTrungThuong = thongTinVeTrungThuong;
            SoTienTrung = soTienTrung;
        }

        public DateTime NgayMua1 { get => NgayMua; set => NgayMua = value; }
        public int LoaiVe1 { get => LoaiVe; set => LoaiVe = value; }
        public List<int> ThongTinVeTrungThuong1 { get => ThongTinVeTrungThuong; set => ThongTinVeTrungThuong = value; }
        public double SoTienTrung1 { get => SoTienTrung; set => SoTienTrung = value; }
    }
}
