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
    public partial class Islamabad_United : Form
    {
        public Islamabad_United()
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

        private void button1_Click(object sender, EventArgs e)
        {
            player_List_IU1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upcoming_Match_IU1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            match_Result_IU1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_Match_IU1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player_ScoreBoard1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editPlayer_IU1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
