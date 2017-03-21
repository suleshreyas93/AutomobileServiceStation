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
    public partial class Repair_History : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        public Repair_History()
        {
            InitializeComponent();
        }

       

        private void Repair_History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet6.Pending' table. You can move, or remove it, as needed.
            this.pendingTableAdapter.Fill(this.masterDataSet6.Pending);
            con.Open();
            cmd = new SqlCommand("select * from Pending", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "cust_name";

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd2 = new SqlCommand("delete  from  Pending where cust_name='" + comboBox1.Text + "'", con);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Customer History Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (con.State.ToString().Equals("Closed"))  
                con.Open(); 
            SqlCommand cmd = new SqlCommand("select * from Pending where cust_name='" + comboBox1.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox1.Text = dr["veichle_name"].ToString();
                textBox2.Text = dr["services"].ToString();

           }
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
