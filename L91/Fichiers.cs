using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L91
{
    public partial class Fichiers : Form
    {
        /* Create Object Instance */
        ftp ftpClient = new ftp(@"ftp://ftp.cluster020.hosting.ovh.net", "user", "password");

        public Fichiers()
        {
            InitializeComponent(); 
        }
        
    
        private void Form1_Load(object sender, EventArgs e)
        {
             
            
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("hey");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
           
            Fichiers F = new Fichiers();
            F.Show(); this.Hide();
        }

        private void home_panel2_Click(object sender, EventArgs e)
        {

           
            Accueil F = new Accueil();
            F.Show(); this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            Accueil F = new Accueil();
            F.Show();this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
            Mesinfos F = new Mesinfos();
            F.Show(); this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            UserForm F = new UserForm();
            F.Show();this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            Fichiers F = new Fichiers();
            F.Show(); this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
            Apropos F = new Apropos();
            F.Show(); this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void connexionftp_Click(object sender, EventArgs e)
        {
            string url = tbhost.Text;
            string user = tbuser.Text;
            string password = tbmdp.Text;
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            request.Credentials = new NetworkCredential(user, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            try
            {
                WebResponse response = (FtpWebResponse)request.GetResponse();
                MessageBox.Show("connected");
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    listView1.Items.Add(reader.ReadLine());
                    
                    
                }

                //Clean-up
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error connecting to the FTP Server" + ex);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
