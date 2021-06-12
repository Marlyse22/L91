using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L91
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            label1.Text = panel1.Width.ToString();
            if(panel2.Width >=700)
            {
                timer1.Stop();
                Authentification a1 = new Authentification();
                a1.Show();
                this.Hide(); 

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
