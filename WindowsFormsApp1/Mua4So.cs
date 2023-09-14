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
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApp1
{
    public partial class Mua4So : Form
    {
        public Mua4So()
        {
            InitializeComponent();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chưa", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Ghi vào trong file
                string directoryPath = Application.StartupPath + @"\DanhSachVeDaMua.TXT";
                
                //Ghi file
                string today = DateTime.Now.ToString("MM/dd/yyyy");

                //Thêm vào danh sách vé đã mua
                List<int> SoDaMua = new List<int>();

                SoDaMua.Add(int.Parse(txtSo1.Text));
                SoDaMua.Add(int.Parse(txtSo2.Text));
                SoDaMua.Add(int.Parse(txtSo3.Text));
                SoDaMua.Add(int.Parse(txtSo4.Text));

                Ve Ticket = new Ve(DangNhap.TenDangNhap, DateTime.Parse(today), 4, cbSoLuongVe.SelectedIndex + 1, SoDaMua);

                DanhSachVeDatMua.ListVeDatMua1.Add(Ticket);

                FileStream fs = null;
                fs = new FileStream(directoryPath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, DanhSachVeDatMua.ListVeDatMua1);
                fs.Close();

                MessageBox.Show("Bạn đã mua thành công", "Thông báo", MessageBoxButtons.OK);



                //GHi file thành công và xóa dữ liệu ở các ô textbox
                txtSo1.Clear();
                txtSo2.Clear();
                txtSo3.Clear();
                txtSo4.Clear();
                cbSoLuongVe.SelectedIndex = 0;
            }
        }






        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length != 0 && txtSo2.Text.Length != 0 && txtSo3.Text.Length != 0 && txtSo4.Text.Length != 0)
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void Mua4So_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 180, 135);

            for (int i = 1; i <= 10; ++i)
            {
                cbSoLuongVe.Items.Add(i);
            }

            cbSoLuongVe.SelectedIndex = 0;
        }


        private void cbSoLuongVe_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true; // không cho phép nhập
            }
        }

        private void cbSoLuongVe_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //Chỉ xử lý khi độ dài khác 0
                if (cbSoLuongVe.Text.Length != 0)
                {
                    //Xóa ở ký tự cuối cùng
                    cbSoLuongVe.Text = cbSoLuongVe.Text.Remove(cbSoLuongVe.Text.Length - 1);

                    //Lùi lại con trỏ ở vị trí trước đó
                    cbSoLuongVe.Select(cbSoLuongVe.Text.Length, 1);
                }
            }
        }

        private void txtSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') || txtSo1.Text.Length >= 2)
            {
                e.Handled = true; // không cho phép nhập
            }
        }

        private void txtSo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //Chỉ xử lý khi độ dài khác 0
                if (txtSo1.Text.Length != 0)
                {
                    //Xóa ở ký tự cuối cùng
                    txtSo1.Text = txtSo1.Text.Remove(txtSo1.Text.Length - 1);

                    //Lùi lại con trỏ ở vị trí trước đó
                    txtSo1.Select(txtSo1.Text.Length, 1);
                }
            }
        }

        private void txtSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || txtSo2.Text.Length >= 2)
            {
                e.Handled = true; // không cho phép nhập
            }
        }

        private void txtSo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //Chỉ xử lý khi độ dài khác 0
                if (txtSo2.Text.Length != 0)
                {
                    //Xóa ở ký tự cuối cùng
                    txtSo2.Text = txtSo2.Text.Remove(txtSo2.Text.Length - 1);

                    //Lùi lại con trỏ ở vị trí trước đó
                    txtSo2.Select(txtSo2.Text.Length, 1);
                }
            }
        }

        private void txtSo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || txtSo3.Text.Length >= 2)
            {
                e.Handled = true; // không cho phép nhập
            }
        }

        private void txtSo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //Chỉ xử lý khi độ dài khác 0
                if (txtSo3.Text.Length != 0)
                {
                    //Xóa ở ký tự cuối cùng
                    txtSo3.Text = txtSo3.Text.Remove(txtSo3.Text.Length - 1);

                    //Lùi lại con trỏ ở vị trí trước đó
                    txtSo3.Select(txtSo3.Text.Length, 1);
                }
            }
        }

        private void txtSo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' || txtSo4.Text.Length >= 2)
            {
                e.Handled = true; // không cho phép nhập
            }
        }

        private void txtSo4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                //Chỉ xử lý khi độ dài khác 0
                if (txtSo4.Text.Length != 0)
                {
                    //Xóa ở ký tự cuối cùng
                    txtSo4.Text = txtSo4.Text.Remove(txtSo4.Text.Length - 1);

                    //Lùi lại con trỏ ở vị trí trước đó
                    txtSo4.Select(txtSo4.Text.Length, 1);
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int So1 = rd.Next(0, 99);
            int So2 = rd.Next(0, 99);
            int So3 = rd.Next(0, 99);
            int So4 = rd.Next(0, 99);

            txtSo1.Text = So1.ToString();
            txtSo2.Text = So2.ToString();
            txtSo3.Text = So3.ToString();
            txtSo4.Text = So4.ToString();
        }
    }
}
