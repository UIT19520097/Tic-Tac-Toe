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
    public partial class Rank : Form
    {
        public Rank()
        {
            InitializeComponent();
            lichsu.Text = DatabaseControler.Instance.showbxh();
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            GiaoDienDaDangKi f = new GiaoDienDaDangKi();
            f.Show();
            this.Close();
        }

        private void Rank_Load(object sender, EventArgs e)
        {

        }

        private void lichsu_Click(object sender, EventArgs e)
        {

        }
    }
}
