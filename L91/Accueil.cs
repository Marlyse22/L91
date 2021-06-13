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
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void home_panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil F = new Accueil();
            F.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichiers F = new Fichiers();
            F.Show();
        }

        private void panel2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Fichiers F = new Fichiers();
            F.Show();
        }

        private void main_panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fichiers F = new Fichiers();
            F.Show();
        }
    }
}
