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
    public partial class Mesinfos : Form
    {
        public Mesinfos()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=sql356.main-hosting.eu; port = 3306;user id=u559094014_latitude91;password=Latitude91;database=u559094014_latitude91;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
       
        string sql;
        private void label1_Click(object sender, EventArgs e)
        {
            Accueil F = new Accueil();
            F.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            Fichiers F = new Fichiers();
            F.Show();this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            UserForm F = new UserForm();
            F.Show();this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
            Mesinfos F = new Mesinfos();
            F.Show(); this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            Apropos F = new Apropos();
            F.Show(); this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mesinfos_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM `utilisateur` WHERE id= 1";
                
                cmd = new MySqlCommand
                {
                    Connection = con,
                    CommandText = sql
                };
                da = new MySqlDataAdapter
                {
                    SelectCommand = cmd
                };
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
             
                    tbnom.Text = dr.GetString("nom");
                    tbprenom.Text = dr.GetString("prenom");
                    tbmdp.Text = dr.GetString("mdp");
                    tbemail.Text = dr.GetString("email");
                    tbusername.Text = dr.GetString("user_name");
                    tbrole.Text = dr.GetString("role");
                }
                else
                {
                    MessageBox.Show("No data for this ID");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbmdp.UseSystemPasswordChar = false;
            }
            else
            {
                tbmdp.UseSystemPasswordChar = true;
            }
        }
    }
}
