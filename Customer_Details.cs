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
    public partial class Customer_Details : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        
        public Customer_Details()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string services = string.Empty;
                foreach (String s in CheckBoxList1.CheckedItems)
                {
                    services += s + ",";
                }
               
                cmd = new SqlCommand("insert into Customer_Details values('" + name.Text + "','" + cust_id.Text + "','" + contact_no.Text + "','" + address.Text + "','" + veichle_name.Text + "','" + veichle_no.Text + "','" +this.dateTimePicker1.Text + "','" + services + "')", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into Pending values('" + cust_id.Text + "','" + veichle_name.Text + "','" + services + "','"+name.Text+"')", con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Database Updated Successfully");

                


                Jobcard f2 = new Jobcard();
                f2.Show();

                this.Close();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select cust_id,contact_no,address,veichle_name,veichle_no,dop from Customer_Details where cust_name='" + name.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cust_id.Text = dr["cust_id"].ToString();
                contact_no.Text = dr["contact_no"].ToString();
                address.Text = dr["address"].ToString();
                veichle_name.Text = dr["veichle_name"].ToString();
                veichle_no.Text = dr["veichle_no"].ToString();
                dateTimePicker1.Text = dr["dop"].ToString();
            }

           
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string services = string.Empty;
            foreach (String s in CheckBoxList1.CheckedItems)
            {
                services += s + ",";
            }
            SqlCommand cmd1 = new SqlCommand("update Customer_Details set ser_req='" + CheckBoxList1.CheckedItems + "' where cust_id='" + cust_id.Text.ToString() + "'", con);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("insert into Pending values('" + cust_id.Text + "','" + veichle_name.Text + "','" + services + "','" + name.Text + "')", con);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Databse Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Jobcard f2 = new Jobcard();
            f2.Show();

            con.Close();
            this.Close();
        }

        private void Customer_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
