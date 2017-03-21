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
    public partial class Jobcard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;

        public Jobcard()
        {
            InitializeComponent();
            autoload();
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



                SqlCommand cmd = new SqlCommand("insert into jobcard values('" + cust_id.Text + "','" + name.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + veichle_name.Text + "','" + veichle_no.Text + "','" + model.Text + "','" + dateTimePicker1.Text + "','" + radioButton1.Text + "','" + comboBox1.Text + "','" + fuel_reading.Text + "','" + odometer_reading.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + services + "')", con);
                //'" + jobcard_id.Text + "',
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from jobspares where job_spares_id='" + cust_id.Text + "'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Database Updated Successfully");

                this.Close();

                Receipt rp = new Receipt();
                rp.Show();

                con.Close();
                comboBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void leave(object sender, EventArgs e)
        {
            Job_Details exp = new Job_Details();
            exp.ShowDialog();
        }

        private void Jobcard_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'masterDataSet1.jobspares' table. You can move, or remove it, as needed.
            this.jobsparesTableAdapter.Fill(this.masterDataSet1.jobspares);
            con.Open();
              
            cmd = new SqlCommand("select * from JOB_ALLOTED", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "EMPLOYEE_NAME";

            con.Close();

        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select cust_name,contact_no,address,veichle_name,veichle_no,dop from Customer_Details where cust_id='" + cust_id.Text + "'", con);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name.Text = dr["cust_name"].ToString();
                textBox4.Text = dr["contact_no"].ToString();
                richTextBox1.Text = dr["address"].ToString();
                veichle_name.Text = dr["veichle_name"].ToString();
                veichle_no.Text = dr["veichle_no"].ToString();
                dateTimePicker1.Text = dr["dop"].ToString();

            }

            con.Close();
        }

        private void CheckBoxList1_Leave(object sender, EventArgs e)
        {
            Job_Details jd = new Job_Details();
            jd.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void autoload()
        {
            // long nid=0;

            con.Open();
            SqlCommand c = new SqlCommand("SELECT  MAX(jobcard_id) AS Expr1 FROM       Jobcard", con);
            using (SqlDataReader dr = c.ExecuteReader())
            {
                while (dr.Read())
                {
                    label18.Text = dr.GetValue(0).ToString();
                }
            }
            label18.Text = ((Convert.ToInt32(label18.Text) + 1).ToString());
            jobcard_id.Text = label18.Text.ToString();
            con.Close();
        }



    }
}
