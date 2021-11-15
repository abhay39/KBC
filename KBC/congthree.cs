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
    public partial class congthree : Form
    {
        public congthree()
        {
            InitializeComponent();
        }

        private void congthree_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressbar.Value = startpoint;
            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;

                timer1.Stop();
                this.Close();
                KBC sq = new KBC();
                sq.Show();
            }
        }
    }
}
