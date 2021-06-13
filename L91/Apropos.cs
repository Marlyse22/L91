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
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            Accueil F = new Accueil();
            F.Show();this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            Fichiers F = new Fichiers();
            F.Show(); this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
            UserForm F = new UserForm();
            F.Show(); this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            Mesinfos F = new Mesinfos();
            F.Show();this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            Apropos F = new Apropos();
            F.Show();this.Hide();
        }
    }
}
