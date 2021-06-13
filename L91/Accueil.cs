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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            MainWin MainWin = new MainWin();
            MainWin.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
