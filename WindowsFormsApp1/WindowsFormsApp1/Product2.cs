using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Product2 : Sample
    {
        public Product2()
        {
            InitializeComponent();
        }

        private void Product2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet1.Products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter.Fill(this.projectsDataSet1.Products);
        }
        private void addproduct_Click(object sender, EventArgs e)
        {
            int product_id, product_unit, product_price, supplier_id, category_id;
            string product_name;
            product_id = int.Parse(productid.Text);
            product_unit = int.Parse(productunit.Text);
            product_price = int.Parse(productprice.Text);
            supplier_id = int.Parse(productSupplier.Text);
            category_id= int.Parse(productCategory.Text);
            product_name = productname.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "productS_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PRODUCT_ID", product_id);
                command.Parameters.AddWithValue("@PRODUCT_NAME", product_name);
                command.Parameters.AddWithValue("@PRODUCT_UNIT", product_unit);
                command.Parameters.AddWithValue("@PRODUCT_PRICE", product_price);
                command.Parameters.AddWithValue("@SUPPLIER_ID", supplier_id);
                command.Parameters.AddWithValue("@CATEGORY_ID", category_id);
               
                // check
                int resulth=command.ExecuteNonQuery();
                if (resulth>0)
                {
                    MessageBox.Show("Data save successfully");
                }
                else 
                {
                    MessageBox.Show("Data not save successfully");

                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void viewproduct_Click(object sender, EventArgs e)
        {
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "products_view";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                // check
                int resulth = command.ExecuteNonQuery();
                 this.productsTableAdapter.Fill(this.projectsDataSet1.Products);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void updateproduct_Click(object sender, EventArgs e)
        {
            int product_ids, product_units, product_prices, supplier_ids, category_ids;
            string product_names;
            product_ids = int.Parse(productid.Text);
            product_units = int.Parse(productunit.Text);
            product_prices = int.Parse(productprice.Text);
            supplier_ids = int.Parse(productSupplier.Text);
            category_ids = int.Parse(productCategory.Text);
            product_names = productname.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "productS_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PRODUCT_ID", product_ids);
                command.Parameters.AddWithValue("@PRODUCT_NAME", product_names);
                command.Parameters.AddWithValue("@PRODUCT_UNIT", product_units);
                command.Parameters.AddWithValue("@PRODUCT_PRICE", product_prices);
                command.Parameters.AddWithValue("@SUPPLIER_ID", supplier_ids);
                command.Parameters.AddWithValue("@CATEGORY_ID", category_ids);

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

        private void deleteproduct_Click(object sender, EventArgs e)
        {
            int product_ids;
            product_ids = int.Parse(productid.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "products_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PRODUCT_ID", product_ids);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int product_id;
            product_id = int.Parse(textBox1.Text);
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
            try
            {
                // part 1 connection
               
                // open connection
                con.Open();
                // query variable 
                string query = "products_SEARCH";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PRODUCT_ID", product_id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ProductDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            finally 
            {
                con.Close();
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer back = new Customer();
            back.Show();
        }
    }
}
