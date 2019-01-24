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
    public partial class Quetta_Gladiator : Form
    {
        public Quetta_Gladiator()
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
            playerList_Quetta1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upcoming_Match_Quetta1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            match_Result_Quetta1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addMatch_quetta1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player_ScoreBoard_Quetta1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            edit_Player_Quetta1.BringToFront();
        }
    }
}
