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
    public partial class Receipt : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand c = new SqlCommand("SELECT  cust_name,date_in,date_out,job_alloted AS Expr1 FROM       Jobcard", con);
            using (SqlDataReader dr = c.ExecuteReader())
            {
                while (dr.Read())
                {
                    label1.Text = dr.GetValue(0).ToString();
                }
            }
            //label1.Text = ((Convert.ToInt32(label1.Text) + 1).ToString());
            //jobcard_id.Text = label18.Text.ToString();
            con.Close();
        }
    }
}
