using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class KBC : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer("sound.wav");
        public KBC()
        {
            InitializeComponent();
            soundPlayer.Play();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            detaillspage dp = new detaillspage();
            dp.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            aboutus ac = new aboutus();
            ac.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
