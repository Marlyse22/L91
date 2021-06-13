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
    }
}
