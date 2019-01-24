using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PSL_APPLICATION
{
    public partial class PSLMAINPAGE : Form
    {
        private SoundPlayer _soundplayer;
        private SoundPlayer sound;
        private SoundPlayer ms;
        private SoundPlayer kk;
        private SoundPlayer iu;
        private SoundPlayer lq;
        private SoundPlayer mashup;
        private SoundPlayer pz;
        public PSLMAINPAGE()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer("ThemeSong.wav");
            sound = new SoundPlayer("QGThemeSong.wav");
            ms = new SoundPlayer("PZThemeSong.wav");
            kk = new SoundPlayer("KKThemeSong.wav");
            iu = new SoundPlayer("IUThemeSong.wav");
            lq = new SoundPlayer("LqThemeSong.wav");
            pz = new SoundPlayer("PZThemeSong.wav");
            mashup = new SoundPlayer("Mashup.wav");
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
            kk.Play();
            Karachi_Kingz karachi = new Karachi_Kingz();
            this.Hide();
            karachi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lq.Play();
            Lahore_Qalanders lahore = new Lahore_Qalanders();
            this.Hide();
            lahore.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pz.Play();
            Peshawar_Zalmi peshawar = new Peshawar_Zalmi();
            this.Hide();
            peshawar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sound.Play();   
            Quetta_Gladiator quetta = new Quetta_Gladiator();
            this.Hide();
            quetta.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iu.Play();
            Islamabad_United islambad = new Islamabad_United();
            this.Hide();
            islambad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ms.Play();
            MultanSultan multan = new MultanSultan();
            this.Hide();
            multan.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
