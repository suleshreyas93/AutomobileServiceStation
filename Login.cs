using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace servicestation
{
    public partial class Login : Form
    {
        
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username='" + username.Text + "' and password='" + password.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MAIN main = new MAIN();
                main.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
