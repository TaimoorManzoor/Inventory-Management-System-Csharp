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
    public partial class orderlist3 : Sample
    {
        public orderlist3()
        {
            InitializeComponent();
        }

        private void orderlist3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet13.OrderDetail' table. You can move, or remove it, as needed.
        //    this.orderDetailTableAdapter.Fill(this.projectsDataSet13.OrderDetail);
            // TODO: This line of code loads data into the 'projectsDataSet12.orderss' table. You can move, or remove it, as needed.
            this.orderssTableAdapter.Fill(this.projectsDataSet12.orderss);
            // TODO: This line of code loads data into the 'projectsDataSet11.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.projectsDataSet11.Products);

        }

        private void orderdetailOrderid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_orderlist_Click(object sender, EventArgs e)
        {
            int orderlistid, orderlistsize, orderlistproductid, orderlistorderid, orderlistquantity, orderlistunitprice;
            orderlistid = int.Parse(orderlist_id.Text); 
            orderlistunitprice = int.Parse(orderlist_unitprice.Text);
            orderlistsize = int.Parse(orderlist_size.Text);
            orderlistquantity = int.Parse(orderlist_quantity.Text);
            orderlistproductid = int.Parse(orderlist_productid.Text);
            orderlistorderid = int.Parse(orderdetail_Orderid.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "orderdetail_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@order_detail_id", orderlistid);
                command.Parameters.AddWithValue("@UNIT_PRICE", orderlistunitprice);
                command.Parameters.AddWithValue("@SIZE", orderlistsize);
                command.Parameters.AddWithValue("@QUNANTITY", orderlistquantity);
                command.Parameters.AddWithValue("@PRODUCT_ID", orderlistproductid);
                command.Parameters.AddWithValue("@ORDER_ID", orderlistorderid);

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

        private void delete_orderlist_Click(object sender, EventArgs e)
        {
            int orderlistid;
            orderlistid = int.Parse(orderlist_id.Text);
            MessageBox.Show(""+orderlistid);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "orderdetail_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@order_detail_id", orderlistid);

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
 //       orderlistid = int.Parse(orderlist_id.Text);
 //       orderlistunitprice = int.Parse(orderlist_unitprice.Text);
 //       orderlistsize = int.Parse(orderlist_size.Text);
 //       orderlistquantity = int.Parse(orderlist_quantity.Text);
 //       orderlistproductid = int.Parse(orderlist_productid.Text);
 //       orderlistorderid = int.Parse(orderdetail_Orderid.Text);

        private void update_orderlist_Click(object sender, EventArgs e)
        {
            int orderlistid, orderlistunitprice, orderlistsize, orderlistquantity, orderlistproductid, orderlistorderid;
            orderlistid = int.Parse(orderlist_id.Text);
            orderlistunitprice = int.Parse(orderlist_unitprice.Text);
            orderlistsize = int.Parse(orderlist_size.Text);
            orderlistquantity = int.Parse(orderlist_quantity.Text);
            orderlistproductid = int.Parse(orderlist_productid.Text);
            orderlistorderid = int.Parse(orderdetail_Orderid.Text);

            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "orderdetails_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@order_detail_id", orderlistid);
                command.Parameters.AddWithValue("@UNIT_PRICE", orderlistunitprice);
                command.Parameters.AddWithValue("@SIZE", orderlistsize);
                command.Parameters.AddWithValue("@QUNANTITY", orderlistquantity);
                command.Parameters.AddWithValue("@PRODUCT_ID", orderlistproductid);
                command.Parameters.AddWithValue("@ORDER_ID", orderlistorderid);

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

        private void view_orderlist_Click(object sender, EventArgs e)
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
                    this.orderDetailTableAdapter.Fill(this.projectsDataSet13.OrderDetail);
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

        private void orderdetailsearch_TextChanged(object sender, EventArgs e)
        {
            int search = int.Parse(orderdetailsearch.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "orderdetail_Filter";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@keyword", search);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                orderdetaillist_dataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
