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
    public partial class Karachi_Kingz : Form
    {
        public Karachi_Kingz()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player_List_Karachi_Kingz1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upcoming_Match_Karachi_Kingz1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matches_Result_Karachi_Kingz1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addMatchKarachiKingz1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            players_ScoreBoard1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            edit_Player1.BringToFront();
        }
    }
}
