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
    public partial class Payment : Sample
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet14.Payments' table. You can move, or remove it, as needed.


        }

        private void add_Click(object sender, EventArgs e)
        {
            int paymentid, total_amount;
            paymentid = int.Parse(payment_id.Text);
            total_amount = int.Parse(totoalamount.Text);
            string payment_type = paymenttype.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "add_payment";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bill_number", paymentid);
                command.Parameters.AddWithValue("@payment_type", payment_type);
                command.Parameters.AddWithValue("@total_amount", total_amount);
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

        private void updatepayment_Click(object sender, EventArgs e)
        {
            int paymentid, total_amount;
            paymentid = int.Parse(payment_id.Text);
            total_amount = int.Parse(totoalamount.Text);
            string payment_type = paymenttype.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "Update_payment";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bill_number", paymentid);
                command.Parameters.AddWithValue("@payment_type", payment_type);
                command.Parameters.AddWithValue("@total_amount", total_amount);
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

        private void DeletePayment_Click(object sender, EventArgs e)
        {
            int paymentid;
            paymentid = int.Parse(payment_id.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "delete_payment";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bill_number", paymentid);
                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data deleted  successfully");
                }
                else
                {
                    MessageBox.Show("Data has not deleted  successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ViewPayment_Click(object sender, EventArgs e)
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
                    this.paymentsTableAdapter.Fill(this.projectsDataSet14.Payments);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "payment_Filter";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", search);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
