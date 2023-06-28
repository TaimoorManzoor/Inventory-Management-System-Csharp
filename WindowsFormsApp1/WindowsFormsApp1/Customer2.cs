using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Customer2 : Sample
    {
        public Customer2()
        {
            InitializeComponent();
        }

        private void Customer2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet2.CustomerS' table. You can move, or remove it, as needed.
            // this.customerSTableAdapter.Fill(this.projectsDataSet2.CustomerS);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            int customer_id = int.Parse(customerid.Text);
            string customer_name, customer_address, customer_phone, customer_email;
            customer_name = customername.Text;
            customer_address = customeraddress.Text;
            customer_phone = customerphonenumber.Text;
            customer_email = customeremail.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "CUSTOMER_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CUSTOMER_ID", customer_id);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", customer_name);
                command.Parameters.AddWithValue("@ADDRESS", customer_address);
                command.Parameters.AddWithValue("@PHONE", customer_phone);
                command.Parameters.AddWithValue("@EMAIL", customer_email);

                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data save successfully");
                }
                else
                {
                    MessageBox.Show("Data not save successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void customerdelete_Click(object sender, EventArgs e)
        {
            int customer_id;
            customer_id = int.Parse(customerid.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "CUSTOMER_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@customer_id", customer_id);
                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data HAS DELETED successfully");
                }
                else
                {
                    MessageBox.Show("Data HAS not DELETED successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void customerupdate_Click(object sender, EventArgs e)
        {
            int customer_id = int.Parse(customerid.Text);
            string customer_name, customer_address, customer_phone, customer_email;
            customer_name = customername.Text;
            customer_address = customeraddress.Text;
            customer_phone = customerphonenumber.Text;
            customer_email = customeremail.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "CUSTOMER_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CUSTOMER_ID", customer_id);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", customer_name);
                command.Parameters.AddWithValue("@ADDRESS", customer_address);
                command.Parameters.AddWithValue("@PHONE", customer_phone);
                command.Parameters.AddWithValue("@EMAIL", customer_email);

                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data edit successfully");
                }
                else
                {
                    MessageBox.Show("Data not edit successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void customerview_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // part 1 connection
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                    // open connection
                    con.Open();
                    // query variable 
                    string query = "CUSTOMER_VIEW";
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    // check
                    int resulth = command.ExecuteNonQuery();
                    this.customerSTableAdapter.Fill(this.projectsDataSet2.CustomerS);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer back = new Customer();
            back.Show();
        }

        private void customersearch_TextChanged(object sender, EventArgs e)
        {
            int search=int.Parse(customersearch.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "CUSTOMER_Filter";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", search);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //this.customerSTableAdapter.Fill(this.projectsDataSet2.CustomerS);
                CustomerDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

          
        }
    }
}