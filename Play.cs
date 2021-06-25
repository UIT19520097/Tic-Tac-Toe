using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace pong
{
    public partial class Play : Form
    {
        //Vars
        int xspeed;
        int yspeed;
        int lastx;
        int lastx_cpu;
        int score_player;
        int score_cpu;
        int topBounds;
        int bottomBounds;
        int leftBounds;
        int rightBounds;
        bool paused = false;
        int pad2; // cho nay luu toa do paddle2 la cai paddle cua doi thu
        public Play()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            //Set up all the initial speed
            xspeed = 2;
            yspeed = 2;

            //Make the buttons no longer clickable
            ball.Enabled = false;
            paddle.Enabled = false;

            //Last mouse X position stored here (so we can add curve based on how fast the mouse was moved)
            lastx = MousePosition.X;
            lastx_cpu = paddle2.Location.X;
            
            //Scores
            score_player = 0;
            score_cpu = 0;

            //Screen Boundaries
            topBounds = 0;
            bottomBounds = this.Height;
            leftBounds = 0;
            rightBounds = this.Width;

            //Hide the pause text (since it defaults on)
            pause_txt.Visible = false;

            //Double Buffer (without this technique the screen will flash)
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        private Socket _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public object _currentData;
        public const int _buffer = 1024;
        int port;
        IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint iPEndPoint;
        //Moves the ball each frame

        private void moveBall(object sender, EventArgs e)
        {
            //Adjusting the bounds (a bit sloppy but useful for testing)
            topBounds = 0;
            bottomBounds = this.Height-23;
            leftBounds = 0;
            rightBounds = this.Width;

            //If not paused we can advance the position of everything
            if (!paused)
            {
                //Player 1
                paddle.Location = new Point((int)(MousePosition.X - paddle.Width), paddle.Location.Y);
                ball.Location = new Point(ball.Location.X + xspeed, ball.Location.Y + yspeed);
                string text = DangNhap.user + ": " + MousePosition.X.ToString(); // lay ten nguoi choi + vi tri paddle
                string text_sended = _client.LocalEndPoint.ToString() + "|" + text; // lay chuoi o tren gan them IP vao truoc de gui cho giong bai04/lab3 
                Send(text_sended); // khi paddle cua minh di chuyen se gui toa do toi server va server gui toi cac client khac, cac lient khac se tach ra lay toa do de dieu khien paddle2
                //paddle2 cua form Play la paddle cua doi thu, 
                //Computer
                if (ball.Location.X > paddle2.Location.X)
                {
                    paddle2.Location = new Point(pad2, paddle2.Location.Y);
                }
                else
                {
                paddle2.Location = new Point(pad2, paddle2.Location.Y);
                }

                //Ball Control:  Left Wall
                if (ball.Location.X < leftBounds)
                {
                    xspeed *= -1;
                    while (ball.Location.X - 1 < leftBounds)
                    {
                        ball.Location = new Point(ball.Location.X + 1, ball.Location.Y);
                    }
                }

                //Ball Control:  Right Wall
                if (ball.Location.X + ball.Width > rightBounds)
                {
                    xspeed *= -1;
                    while (ball.Location.X + 1 > rightBounds)
                    {
                        ball.Location = new Point(ball.Location.X - 1, ball.Location.Y);
                    }
                }

                //Ball Control: Player Paddle
                if (ball.Location.Y + ball.Height > paddle.Location.Y && ball.Location.X > (int)(paddle.Location.X - ball.Width / 2) && ball.Location.X + ball.Width < (int)(paddle.Location.X + paddle.Width + ball.Width / 2) && ball.Location.Y < (int)(paddle.Location.Y + paddle.Height / 2))
                {
                    yspeed *= -1;
                    xspeed = Math.Abs(MousePosition.X - lastx);
                    if (xspeed > 4)
                    {
                        xspeed = 4;
                    }
                    else if (xspeed < -4)
                    {
                        xspeed = -4;
                    }
                    else if (xspeed == 0)
                    {
                        Random a = new Random();
                        if (a.NextDouble() > .5)
                        {
                            xspeed = 2;
                        }
                        else
                        {
                            xspeed = -2;
                        }
                    }
  
                    while (ball.Location.Y + 1 + ball.Height > paddle.Location.Y)
                    {
                        ball.Location = new Point(ball.Location.X, ball.Location.Y - 1);
                    }
                    Random r = new Random();
                    BackColor= Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                }

                //Ball Control: CPU Paddle
                if (ball.Location.Y < paddle2.Location.Y + paddle2.Height && ball.Location.X > (int)(paddle2.Location.X - ball.Width / 2) && ball.Location.X + ball.Width < (int)(paddle2.Location.X + paddle.Width + ball.Width / 2) && ball.Location.Y > (int)(paddle2.Location.Y + paddle2.Height / 2))
                {
                    yspeed *= -1;
                    xspeed = Math.Abs(paddle.Location.X - lastx_cpu);
                    if (xspeed > 4)
                    {
                        xspeed = 4;
                    }
                    else if (xspeed < -4)
                    {
                        xspeed = -4;
                    }
                    else if (xspeed == 0)
                    {
                        Random a = new Random();
                        if (a.NextDouble() > .5)
                        {
                            xspeed = 2;
                        }
                        else
                        {
                            xspeed = -2;
                        }
                    }
                    while (ball.Location.Y - 1 < paddle2.Location.Y + paddle2.Height)
                    {
                        ball.Location = new Point(ball.Location.X, ball.Location.Y + 1);
                    }
                }

                //Ball Control: CPU Scoring
                if (ball.Location.Y > bottomBounds)
                {
                    ball.Location = new Point(120, 100);
                    Random b = new Random();
                    if (b.NextDouble() > .5)
                    {
                        xspeed = 2;
                    }
                    else
                    {
                        xspeed = -2;
                    }
                    yspeed = -2;
                    score_cpu++;
                    points2.Text = "CPU: " + score_cpu;
                } //Ball Control - Player Scoring
                else if (ball.Location.Y < topBounds)
                {
                    ball.Location = new Point(120, 100);
                    Random b = new Random();
                    if (b.NextDouble() > .5)
                    {
                        xspeed = 2;
                    }
                    else
                    {
                        xspeed = -2;
                    }
                    yspeed = 2;
                    score_player++;
                    points1.Text = "Player: " + score_player;
                }
                lastx = MousePosition.X;
                lastx_cpu = paddle2.Location.X;
            }
        }


        private void movePaddles(object sender, EventArgs e)
        {
            //Properly position the paddles
            paddle.Location = new Point(paddle.Location.X, bottomBounds - 46);
            paddle2.Location = new Point(pad2,topBounds + 12);
            pause_txt.Location = new Point((int)rightBounds / 2 - pause_txt.Width / 2, (int)bottomBounds / 2 - pause_txt.Height / 2);
        }

        private void pause(object sender, EventArgs e) // vi choi game online nen e tat pause, vi pause no se ko dong bo 2 ben 
        {
            //Toggle pausing by clicking
           // if (!paused)
            //{
            //    paused = true;
            //    pause_txt.Visible = true;
        //    }
       //     else
        //    {
          //      paused = false;
           //     pause_txt.Visible = false;
          //  }
        }
        void Connect()
        {
            port = 8080;
            iPEndPoint = new IPEndPoint(iPAddress, port);
            while (true)
            {
                try
                {
                    _client.Connect(iPEndPoint);
                    Thread listen = new Thread(Receive);
                    listen.IsBackground = true;
                    listen.Start();
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    port++;
                }
            }
        }
        private void Send(string data_need_to_send)
        {
            try
            {
                _client.Send(Serialize(data_need_to_send));

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void Receive()
        {//cho nay em nhan tin nhan, trong do co toa do paddle cua ben kia, co dang: "ten user"+'#" +toa do
            _currentData = new object();
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[_buffer * 5];
                    _client.Receive(buffer);
                    _currentData = Deserialize(buffer);
                    string data = _currentData as string;
                    string[] arrListStr = data.Split('#'); // tach lay toa do, cat ra bang dau #, toa do o arrliststr[1] 
                    int x = Int32.Parse(arrListStr[1]); // gan toa do do x roi paddle 2 co toa do x
                    if (arrListStr[0]!=DangNhap.user) // kiem tra neu toa do cua doi thu hay khong, neu do cua minh thi ko chay, vi server sẽ gui ve toa do cua minh khi nhan duoc
                        pad2 = x; // !!!!!! Em chua tim duoc paddle 2 nhan toa do cho nao, chi nao giup em di!!!!!!
                    paddle2.Location = new Point(x, paddle2.Location.Y); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }
        //Double Buffer (required function)
        protected override void OnPaint(PaintEventArgs pe)
        {
            
        }

        private void paddle_Click(object sender, EventArgs e)
        {

        }

        private void pause_txt_Click(object sender, EventArgs e)
        {

        }

        private void points1_Click(object sender, EventArgs e)
        {

        }

        private void paddle2_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void points2_Click(object sender, EventArgs e)
        {

        }
    }
}