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
    public partial class firstque : Form
    {
        public firstque()
        {
            InitializeComponent();
            
        }
        KBC k = new KBC();
        
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry You have Choosed the Wrong Answer.");
            this.Hide();
            k.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You have Given The Right Answer.");
            MessageBox.Show(" You have Won 100$.");
            secondque s = new secondque();
            s.Show();
            this.Hide();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void firstque_Load(object sender, EventArgs e)
        {
            
            SoundPlayer soundPlayer = new SoundPlayer("sound.wav");
            soundPlayer.Play();
        }
    }
}
