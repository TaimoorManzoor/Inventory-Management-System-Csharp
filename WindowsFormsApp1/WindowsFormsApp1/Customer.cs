using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customer : Sample
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product2 product = new Product2();
            product.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            order2 order2 = new order2();
            order2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            orderlist3 orderlist = new orderlist3();
            orderlist.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier2 supplier = new Supplier2();
            supplier.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer2 customer2 = new Customer2();
            customer2.Show();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category2 category = new Category2();
            category.Show();

        }
    }
}
