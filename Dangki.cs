using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pong
{
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkpass()
        {
            if(textBox3.Text.Equals(textBox4.Text))
            {
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(DatabaseControler.Instance.checktaikhoan(textBox1.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else
            {
                if(checkpass()==false)
                    MessageBox.Show("Nhập lại mật khẩu đi con di lon");
                else
                {
                    DatabaseControler.Instance.insertuser(textBox1.Text, textBox3.Text, textBox2.Text,(AppControler.LayThoiGian()).ToString());
                    MessageBox.Show("Tạo tài khoản thành công");
                    DangNhap f = new DangNhap();
                    f.Show();
                    this.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Close();
        }

        private void Dangki_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Close();
        }
    }
}
