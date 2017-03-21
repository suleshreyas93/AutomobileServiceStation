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
    public partial class Job_Details : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True ");
        SqlCommand cmd;

        public Job_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into jobspares values('" + job_spares_id.Text + "','" + item_code.Text + "','" + item_name.Text + "','" + units_sold.Text + "','" + unit_price.Text + "','" + handling.Text + "','" + vat.Text + "')", con);
            cmd.ExecuteNonQuery();

            Jobcard f2 = new Jobcard();
            f2.Refresh();

            this.Close();
            MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
