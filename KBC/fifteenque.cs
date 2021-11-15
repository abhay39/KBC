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
    public partial class fifteenque : Form
    {
        public fifteenque()
        {
            InitializeComponent();
        }
        KBC k = new KBC();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You have Given The Right Answer.");
            MessageBox.Show(" You have Won 1000000$.");
            congthree three = new congthree();
            three.Show();
            this.Close();
            SoundPlayer soundPlayer = new SoundPlayer("million.wav");
            soundPlayer.Play();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            k.Show();
        }
    }
}
