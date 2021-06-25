using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace pong
{
    public partial class TypeGame : Form
    {
        SocketManager socket;
        public TypeGame()
        {
            InitializeComponent();
            socket = new SocketManager();
        }

        private void choivoimay_Click(object sender, EventArgs e)
        {
            Play f = new Play();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Choivoimay f = new Choivoimay();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play f = new Play();
            f.Show();
            this.Close();
        }
        void Listen()
        {
            string data = (string)socket.Receive();

            MessageBox.Show(data);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                socket.CreateServer();

                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
                button2.Enabled = false;
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send(DangNhap.user+" đã vào phòng");
            }
        }

        private void TypeGame_Shown(object sender, EventArgs e)
        {
            //txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            //if (string.IsNullOrEmpty(txbIP.Text))
            //{
            //    txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //}
        }

        private void txbIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
