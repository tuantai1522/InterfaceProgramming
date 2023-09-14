using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    class NguoiDung
    {
        private string TenDangNhap, MatKhau, SoDienThoai, Email;
        public NguoiDung()
        {
            TenDangNhap = MatKhau = SoDienThoai = Email = "";
        }

        public NguoiDung(string tenDangNhap, string matKhau, string soDienThoai, string email)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            SoDienThoai = soDienThoai;
            Email = email;
        }

        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string SoDienThoai1 { get => SoDienThoai; set => SoDienThoai = value; }
        public string Email1 { get => Email; set => Email = value; }

        public void GhiFile(string TenFile)
        {
            File.AppendAllText(TenFile, TenDangNhap);
            File.AppendAllText(TenFile, " - ");

            File.AppendAllText(TenFile, MatKhau);
            File.AppendAllText(TenFile, " - ");

            File.AppendAllText(TenFile, SoDienThoai);
            File.AppendAllText(TenFile, " - ");

            File.AppendAllText(TenFile, Email);

            File.AppendAllText(TenFile, "\n");
        }
    }


}
