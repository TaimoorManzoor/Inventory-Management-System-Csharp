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
    public partial class Supplier2 : Sample
    {
        public Supplier2()
        {
            InitializeComponent();
        }

        private void Supplier2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet15.SUPPLIERS' table. You can move, or remove it, as needed.
         

        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            int SUPPLIER_id = int.Parse(SupplierId.Text);
            string SUPPLIER_name, SUPPLIER_address, SUPPLIER_phone, SUPPLIER_email;
            SUPPLIER_name = SupplierId.Text;
            SUPPLIER_address = SupplierAddress.Text;
            SUPPLIER_phone = Supplier_phonenumber.Text;
            SUPPLIER_email = Supplier_email.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "SUPPLIERS_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SUPPLIER_ID", SUPPLIER_id);
                command.Parameters.AddWithValue("@NAME", SUPPLIER_name);
                command.Parameters.AddWithValue("@ADDRESS", SUPPLIER_address);
                command.Parameters.AddWithValue("@PHONE", SUPPLIER_phone);
                command.Parameters.AddWithValue("@EMAIL", SUPPLIER_email);

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

        private void UpdateSupplier_Click(object sender, EventArgs e)
        {
            int SUPPLIER_id = int.Parse(SupplierId.Text);
            string SUPPLIER_name, SUPPLIER_address, SUPPLIER_phone, SUPPLIER_email;
            SUPPLIER_name = SupplierId.Text;
            SUPPLIER_address = SupplierAddress.Text;
            SUPPLIER_phone = Supplier_phonenumber.Text;
            SUPPLIER_email = Supplier_email.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "SUPPLIERS_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SUPPLIER_ID", SUPPLIER_id);
                command.Parameters.AddWithValue("@NAME", SUPPLIER_name);
                command.Parameters.AddWithValue("@ADDRESS", SUPPLIER_address);
                command.Parameters.AddWithValue("@PHONE", SUPPLIER_phone);
                command.Parameters.AddWithValue("@EMAIL", SUPPLIER_email);

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

        private void ViewSupplier_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // part 1 connection
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                    // open connection
                    con.Open();
                    // query variable 
                    string query = "SUPPLIERS_VIEWS";
                    SqlCommand command = new SqlCommand(query, con);
                    command.CommandType = CommandType.StoredProcedure;
                    // check
                    int resulth = command.ExecuteNonQuery();
                    this.sUPPLIERSTableAdapter.Fill(this.projectsDataSet15.SUPPLIERS);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            int SUPPLIER_id = int.Parse(SupplierId.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "SUPPLIERS_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SUPPLIER_ID", SUPPLIER_id);


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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer back = new Customer();
            back.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Supplier_TextChanged(object sender, EventArgs e)
        {
            int search = int.Parse(Search_Supplier.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "supplier_Filter";
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
