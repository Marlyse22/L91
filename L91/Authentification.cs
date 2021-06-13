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
        MySqlConnection con = new MySqlConnection("server=sql356.main-hosting.eu; port = 3306;user id=u559094014_latitude91;password=;database=u559094014_latitude91;sslMode=none");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;
        int maxrow;


        private void doLogIn()
        {
            try
            {
                sql = "SELECT * FROM `utilisateur` WHERE `user_name`='" + usernameTXT.Text + "'  AND `mdp`='" + mdpTXT.Text + "'";
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


                maxrow = dt.Rows.Count;
                if (maxrow > 0)
                {
                    MessageBox.Show("Bienvenue " + dt.Rows[0].Field<string>("role") + "Bonjour, " + dt.Rows[0].Field<string>("prenom"));
                    
                    visibleAll(false);
                    MainWin mn = new MainWin();
                    mn.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ce compte n'existe pas ! Veuillez contacter l'administrateur ");
                    usernameTXT.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();

            }
        }
        private void visibleAll(Boolean result)
        {
            
            valider.Visible = result;
            mdpTXT.Visible = result;
            usernameTXT.Visible = result;
            label1.Visible = result;
            label2.Visible = result;
            mdpTXT.Clear();
            usernameTXT.Clear();
            usernameTXT.Focus();
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
            this.AcceptButton = valider;
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


        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            doLogIn();
        }
    }
}
