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
    public partial class Orderlist2 : Sample
    {
        public Orderlist2()
        {
            InitializeComponent();
        }

        private void Orderlist2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectsDataSet10.orderss' table. You can move, or remove it, as needed.
            this.orderssTableAdapter1.Fill(this.projectsDataSet10.orderss);
            // TODO: This line of code loads data into the 'projectsDataSet9.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.projectsDataSet9.Products);
            // TODO: This line of code loads data into the 'projectsDataSet8.OrderDetail' table. You can move, or remove it, as needed.
            //this.orderDetailTableAdapter.Fill(this.projectsDataSet8.OrderDetail);
            // TODO: This line of code loads data into the 'projectsDataSet7.orderss' table. You can move, or remove it, as needed.
            //this.orderssTableAdapter.Fill(this.projectsDataSet7.orderss);
            // TODO: This line of code loads data into the 'projectsDataSet6.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.projectsDataSet6.Products);

        }

        private void addorderlist_Click(object sender, EventArgs e)
        {
            int orderdetail_id, size, quantity,unitprice,productid,orderid;
            orderdetail_id = int.Parse(orderdetailid.Text);
            size = int.Parse(orderdetaillistSize.Text);
            quantity = int.Parse(orderdetaillistquantity.Text);
            unitprice = int.Parse(orderdetaillistunitprice.Text);
            productid = int.Parse(orderdetaillist_productid.Text);
            orderid = int.Parse(orderdetailOrderid.Text);
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
                command.Parameters.AddWithValue("@order_detail_id", orderdetailid);
                command.Parameters.AddWithValue("@UNIT_PRICE", unitprice);
                command.Parameters.AddWithValue("@PRODUCT_ID", productid);
                command.Parameters.AddWithValue("@QUNANTITY", quantity);
                command.Parameters.AddWithValue("@SIZE", size);
                command.Parameters.AddWithValue("@ORDER_ID", orderid);


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
    }
}
