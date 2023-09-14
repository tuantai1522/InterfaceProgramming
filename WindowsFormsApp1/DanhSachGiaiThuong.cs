using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]

    class DanhSachGiaiThuong
    {
        private static List<GiaiThuong> ListGiaiThuong = new List<GiaiThuong>();

        internal static List<GiaiThuong> ListGiaiThuong1 { get => ListGiaiThuong; set => ListGiaiThuong = value; }
    }
}
