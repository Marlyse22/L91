using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace L91
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void validatBtn_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mdpTXT.UseSystemPasswordChar = false;
            }
            else
            {
                mdpTXT.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTXT.Text;
            string mdp = mdpTXT.Text;

            // Db connect

            MySqlConnection con = new MySqlConnection("server = ; user id = u559094014_latitude91	; database = u559094014_latitude91");
            MySqlDataAdapter sda = new MySqlDataAdapter("");


            if (usernameTXT.Text == "you")
            {
                if (mdpTXT.Text == "mdp")
                {
                    MainWin mw = new MainWin();
                    mw.Show();
                    this.Hide();

                }
                else
                {
                    label3.Visible = true;

                }
            }
            else
            {

            }
        }
    }
}
