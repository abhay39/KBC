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
    public partial class congrateson : Form
    {
        public congrateson()
        {
            InitializeComponent();
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
                this.Dispose();
                sixque sq = new sixque();
                sq.Show();
            }
        }

        private void congrateson_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
