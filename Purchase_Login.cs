using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace servicestation
{
    public partial class Purchase_Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        public Purchase_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Purchase_login where username='" + username.Text + "' and password='" + password.Text + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login successfull", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Purchase pc = new Purchase();
                pc.Show();

            }
                

            else
            {
                MessageBox.Show("Invalid Credentials", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

            con.Close();
        }
    }
}
