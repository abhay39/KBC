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
    public partial class detaillspage : Form
    {
        public detaillspage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public static string agentname;
        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "" || addresstb.Text == "" || phonetb.Text == "" || emailtb.Text == "")
            {
                MessageBox.Show("Please Input all the details below.");
            }
            else
            {
                firstque fq = new firstque();
                fq.Show();
                this.Hide();
                nametb.Text = agentname;
                
            }
            
        }
    }
}
