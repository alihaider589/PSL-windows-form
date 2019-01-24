using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSL_APPLICATION
{
    public partial class MultanSultan : Form
    {
        public MultanSultan()
        {
            InitializeComponent();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerListMultan1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upcomingMatchMultan1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matchResultMultan1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addMatchMultan1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerScoreBoardMultan1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editPlayerMultan1.BringToFront();
        }
    }
}
