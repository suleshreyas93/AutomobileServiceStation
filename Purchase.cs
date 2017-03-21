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
    public partial class Purchase : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-7-PC;Initial Catalog=master;Integrated Security=True");
        SqlCommand cmd;
        public Purchase()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select * from purchaseparty", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = " party_name";

             SqlCommand cmd1 = new SqlCommand("select * from excise", con);
             SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
             DataTable dt1 = new DataTable();
             da1.Fill(dt1);

             comboBox2.DataSource = dt1;
             comboBox2.DisplayMember = "excise";

             SqlCommand cmd2 = new SqlCommand("Select * from vat", con);
             SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
             DataTable dt2 = new DataTable();
             da2.Fill(dt2);

             comboBox3.DataSource = dt2;
             comboBox3.DisplayMember = "vat";

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from spareparts", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from spareparts where product_id='" + search.Text + "'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                Decimal a = Convert.ToDecimal(order_quantity.Text) * Convert.ToDecimal(rate.Text);
                amount.Text = a.ToString();
                Decimal b = Convert.ToDecimal(comboBox2.Text) * a;
                Decimal c = b / 100;
                ttl_excise.Text = (c + a).ToString();
                Decimal d = Convert.ToDecimal(comboBox3.Text) * Convert.ToDecimal(ttl_excise.Text);
                Decimal f = d / 100;
                grand_ttl.Text = (c + a + f).ToString();



                SqlCommand cmd3 = new SqlCommand("update spareparts set quantity=quantity+'" + order_quantity.Text + "' where product_id='" + product_id.Text.ToString() + "'", con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("DataBase Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }
            catch (FormatException)
            {
                MessageBox.Show("please enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {



            con.Open();

            SqlDataReader dr;
            SqlCommand cmd3 = new SqlCommand();
            dr = cmd3.ExecuteReader();
            if (dr.Read())
            {
                pro_name.Text = dr["product_name"].ToString();


                SqlCommand cmd = new SqlCommand("insert into purchase values('" + product_id.Text + "','" + pro_name.Text + "','" +description.Text + "','" + size.Text + "', '"+unit_price.Text+"','" + comboBox1.Text + "','" + order_quantity.Text + "','" + rate.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + amount.Text + "','" + ttl_excise.Text + "','" + grand_ttl.Text + "')", con);
                cmd.ExecuteNonQuery();


            }
            else
            {


                SqlCommand cmd6 = new SqlCommand("insert into spareparts values('" + product_id.Text + "','" + pro_name.Text + "','" + order_quantity.Text + "','" + unit_price.Text + "')", con);
                cmd6.ExecuteNonQuery();

                MessageBox.Show("Order Placed Successfully", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            con.Close();




        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from purchase where product_id='" + product_id.Text.ToString() + "'", con);
            SqlDataReader dr;
            dr = cmd2.ExecuteReader();
            if (dr.Read())
            {

                pro_name.ReadOnly = true;
                description.ReadOnly = true;
                size.ReadOnly = true;
                rate.ReadOnly = true;

                pro_name.Text = dr["product_name"].ToString();
                description.Text = dr["product_desc"].ToString();
                size.Text = dr["size"].ToString();
                rate.Text = dr["rate"].ToString();

                dr.Close();
            }
            con.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet5.vat' table. You can move, or remove it, as needed.
            this.vatTableAdapter.Fill(this.masterDataSet5.vat);
            // TODO: This line of code loads data into the 'masterDataSet4.excise' table. You can move, or remove it, as needed.
            this.exciseTableAdapter.Fill(this.masterDataSet4.excise);
            // TODO: This line of code loads data into the 'masterDataSet3.purchaseparty' table. You can move, or remove it, as needed.
            this.purchasepartyTableAdapter.Fill(this.masterDataSet3.purchaseparty);
            // TODO: This line of code loads data into the 'masterDataSet2.spareparts' table. You can move, or remove it, as needed.
            this.sparepartsTableAdapter.Fill(this.masterDataSet2.spareparts);

        }
    }
}
