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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=sql356.main-hosting.eu; port = 3306;user id=u559094014_latitude91;password=Latitude91;database=u559094014_latitude91;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mdpTb.UseSystemPasswordChar = false;
            }
            else
            {
                mdpTb.UseSystemPasswordChar = true;
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my insert query in which i am taking input from the user through windows forms 
                sql = "INSERT INTO `utilisateur`(user_name, mdp, nom, prenom, email, role) values ('" + this.usernameTb.Text + "','" + this.mdpTb.Text + "','" + this.nomTB.Text + "','" + this.prenomTB.Text + "','" + this.emailTb.Text + "','" + this.roleLb.Text + "' );";
                
                //This is command class which will handle the query and connection object.  
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = cmd.ExecuteReader();   // Here our query will be executed and data saved into the database.  
                 
                MessageBox.Show("Utilisateur enregistrer avec succes");
                while (MyReader2.Read())
                {
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
           
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM `utilisateur`";
                con.Open();
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                da = new MySqlDataAdapter
                {
                    SelectCommand = cmd
                };
                dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
