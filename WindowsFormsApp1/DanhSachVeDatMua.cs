using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]

    class DanhSachVeDatMua
    {
        private static List<Ve> ListVeDatMua = new List<Ve>();

        internal static List<Ve> ListVeDatMua1 { get => ListVeDatMua; set => ListVeDatMua = value; }
    }
}
