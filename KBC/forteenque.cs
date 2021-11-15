using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBC
{
    public partial class forteenque : Form
    {
        public forteenque()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" You have Given The Right Answer.");
            MessageBox.Show(" You have Won 500000$.");
            fifteenque tq = new fifteenque();
            tq.Show();
            this.Hide();
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
            MessageBox.Show("Sorry You have Choosed the Wrong Answer.");
            this.Hide();
            k.Show();
        }
        KBC k = new KBC();
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            k.Show();
        }
    }
}
