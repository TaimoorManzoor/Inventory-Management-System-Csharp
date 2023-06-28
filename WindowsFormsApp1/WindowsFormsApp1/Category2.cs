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
    public partial class Category2 : Sample
    {
        public Category2()
        {
            InitializeComponent();
        }

        private void Category2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet16.CATEGORYS' table. You can move, or remove it, as needed.

        }

        private void customeraddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int category_id = int.Parse(Category_ID.Text);
            string category_name, description;
            category_name = CategoryName.Text;
            description = Description.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "category_ADD";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CATEGORY_ID", category_id);
                command.Parameters.AddWithValue("@CATEGORY_NAME", category_name);
                command.Parameters.AddWithValue("@DESCRIPTION", description);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Cateegory_Click(object sender, EventArgs e)
        {
            int category_id = int.Parse(Category_ID.Text);
            string category_name, description;
            category_name = CategoryName.Text;
            description = Description.Text;
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "category_UPDATE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CATEGORY_ID", category_id);
                command.Parameters.AddWithValue("@CATEGORY_NAME", category_name);
                command.Parameters.AddWithValue("@DESCRIPTION", description);

                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data update successfully");
                }
                else
                {
                    MessageBox.Show("Data not update successfully");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "category_VIEW";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                // check
                int resulth = command.ExecuteNonQuery();
                this.cATEGORYSTableAdapter.Fill(this.projectsDataSet16.CATEGORYS);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int category_id = int.Parse(Category_ID.Text);
            try
            {
                // part 1 connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "category_DELETE";
                SqlCommand command = new SqlCommand(query, con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CATEGORY_ID", category_id);
            

                // check
                int resulth = command.ExecuteNonQuery();
                if (resulth > 0)
                {
                    MessageBox.Show("Data Delete successfully");
                }
                else
                {
                    MessageBox.Show("Data not Delete successfully");

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int search = int.Parse(textBox1.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=projects;Integrated Security=True");
                // open connection
                con.Open();
                // query variable 
                string query = "category_FILTER";
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
