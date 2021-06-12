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
            if (usernameTXT.Text == null || mdpTXT.Text == null)
            {
                MessageBox.Show("Données vides");
            }
            else
            {
                string username = usernameTXT.Text;
                string mdp = mdpTXT.Text;
                string MySQLConectionString = "datasource = sql356.main-hosting.eu; port = 3306; username = u559094014_latitude91; password = Latitude91; database = u559094014_latitude91";

                // Query
                string query = "SELECT * FROM utilisateur WHERE user_name =" + usernameTXT.Text + " AND mdp = " + mdpTXT.Text + "";

                // Db connect

                MySqlConnection databaseconnection = new MySqlConnection(MySQLConectionString);
                MySqlCommand commmandeDatabase = new MySqlCommand(query, databaseconnection);
                commmandeDatabase.CommandTimeout = 60;


                if (databaseconnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("La connexion est passée avec succes "); ;
                }
                else
                {
                    MessageBox.Show("Cette connexion ne marche pas");

                }
                try
                {
                    databaseconnection.Open();

                    MySqlDataReader myReader = commmandeDatabase.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        MessageBox.Show("Exécuté avec succès");
                        while (myReader.Read())
                        {
                            Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exécuté avec succès mais aucune ligne");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur :" + ex.Message);
                }
            }


            /*
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
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
