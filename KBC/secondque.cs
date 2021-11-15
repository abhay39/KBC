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
    public partial class secondque : Form
    {
        public secondque()
        {
            InitializeComponent();
        }
        KBC k = new KBC();
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void secondque_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer soundPlayer = new SoundPlayer("sound.wav");
            soundPlayer.Play();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You have Given The Right Answer.");
            MessageBox.Show(" You have Won 200$.");
            thirdque tq = new thirdque();
            tq.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry You have Choosed the Wrong Answer.");
            this.Hide();
            k.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry You have Choosed the Wrong Answer.");
            this.Hide();
            k.Show();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry You have Choosed the Wrong Answer.");
            this.Hide();
            k.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            KBC k = new KBC();
            k.Show();
        }
    }
}
