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
    public partial class order2 : Sample
    {
        public order2()
        {
            InitializeComponent();
        }

        private void order2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet5.orders' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectsDataSet4.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.projectsDataSet4.payment);
            // TODO: This line of code loads data into the 'projectsDataSet3.CustomerS' table. You can move, or remove it, as needed.
            this.customerSTableAdapter.Fill(this.projectsDataSet3.CustomerS);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void orderadd_Click(object sender, EventArgs e)
        {
            string date_of_order;
            int order_id, bill_number, customer_id;
            order_id = int.Parse(orderid.Text);
            bill_number = int.Parse(billnumber.Text);
            customer_id = int.Parse(ordercustomerid.Text);
            date_of_order = dateTimeorder.Value.ToShortDateString();

            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "ORDERS_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ORDER_ID", order_id);
                command.Parameters.AddWithValue("@DATE_OF_ORDER", date_of_order);
                command.Parameters.AddWithValue("@CUSTOMER_ID", customer_id);
                command.Parameters.AddWithValue("@BILL_NUMBER", bill_number);

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

        private void orderdelete_Click(object sender, EventArgs e)
        {
            int order_id;
            order_id = int.Parse(orderid.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "orders_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ORDER_ID", order_id);

                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data has delete successfully");
                }
                else
                {
                    MessageBox.Show("Data has not delete successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void orderupdate_Click(object sender, EventArgs e)
        {
            string date_of_order;
            int order_id, bill_number, customer_id;
            order_id = int.Parse(orderid.Text);
            bill_number = int.Parse(billnumber.Text);
            customer_id = int.Parse(ordercustomerid.Text);
            date_of_order = dateTimeorder.Value.ToShortDateString();

            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "ORDERS_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ORDER_ID", order_id);
                command.Parameters.AddWithValue("@DATE_OF_ORDER", date_of_order);
                command.Parameters.AddWithValue("@CUSTOMER_ID", customer_id);
                command.Parameters.AddWithValue("@BILL_NUMBER", bill_number);

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

        private void orderview_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // part 1 connection
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                    // open connection
                    con.Open();
                    // query variable 
                    string query = "orders_VIEW";
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    // check
                    int resulth = command.ExecuteNonQuery();
                    this.ordersTableAdapter.Fill(this.projectsDataSet5.orders);
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
                string query = "orders_Filter";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", search);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                OrderDataGridview.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void OrderDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


