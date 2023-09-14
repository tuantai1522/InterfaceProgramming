using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]

    public static class DanhSachNguoiDung
    {
        private static List<NguoiDung> listNguoiDung = new List<NguoiDung>();
        internal static List<NguoiDung> ListNguoiDung { get => listNguoiDung; set => listNguoiDung = value; }
    }
}
