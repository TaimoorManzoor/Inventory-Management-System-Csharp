namespace WindowsFormsApp1
{
    partial class orderlist3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.orderlist_quantity = new System.Windows.Forms.TextBox();
            this.orderlist_size = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderlist_unitprice = new System.Windows.Forms.TextBox();
            this.orderlist_productid = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet11 = new WindowsFormsApp1.projectsDataSet11();
            this.orderdetail_Orderid = new System.Windows.Forms.ComboBox();
            this.orderssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet12 = new WindowsFormsApp1.projectsDataSet12();
            this.label3 = new System.Windows.Forms.Label();
            this.orderlist_id = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new WindowsFormsApp1.projectsDataSet11TableAdapters.ProductsTableAdapter();
            this.orderssTableAdapter = new WindowsFormsApp1.projectsDataSet12TableAdapters.orderssTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.add_orderlist = new System.Windows.Forms.Button();
            this.delete_orderlist = new System.Windows.Forms.Button();
            this.update_orderlist = new System.Windows.Forms.Button();
            this.view_orderlist = new System.Windows.Forms.Button();
            this.orderdetailsearch = new System.Windows.Forms.TextBox();
            this.orderdetaillist_dataGridView = new System.Windows.Forms.DataGridView();
            this.orderdetailidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet13 = new WindowsFormsApp1.projectsDataSet13();
            this.orderDetailTableAdapter = new WindowsFormsApp1.projectsDataSet13TableAdapters.OrderDetailTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet12)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetaillist_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.orderlist_quantity);
            this.panel1.Controls.Add(this.orderlist_size);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orderlist_unitprice);
            this.panel1.Controls.Add(this.orderlist_productid);
            this.panel1.Controls.Add(this.orderdetail_Orderid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.orderlist_id);
            this.panel1.Size = new System.Drawing.Size(564, 670);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.orderlist_id, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetail_Orderid, 0);
            this.panel1.Controls.SetChildIndex(this.orderlist_productid, 0);
            this.panel1.Controls.SetChildIndex(this.orderlist_unitprice, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.orderlist_size, 0);
            this.panel1.Controls.SetChildIndex(this.orderlist_quantity, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderdetaillist_dataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(803, 670);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.orderdetaillist_dataGridView, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(167, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Order ID";
            // 
            // orderlist_quantity
            // 
            this.orderlist_quantity.Location = new System.Drawing.Point(173, 368);
            this.orderlist_quantity.MaxLength = 50;
            this.orderlist_quantity.Name = "orderlist_quantity";
            this.orderlist_quantity.Size = new System.Drawing.Size(224, 30);
            this.orderlist_quantity.TabIndex = 36;
            this.orderlist_quantity.Text = "Quantity";
            // 
            // orderlist_size
            // 
            this.orderlist_size.Location = new System.Drawing.Point(172, 318);
            this.orderlist_size.MaxLength = 50;
            this.orderlist_size.Name = "orderlist_size";
            this.orderlist_size.Size = new System.Drawing.Size(224, 30);
            this.orderlist_size.TabIndex = 37;
            this.orderlist_size.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(170, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Product ID";
            // 
            // orderlist_unitprice
            // 
            this.orderlist_unitprice.Location = new System.Drawing.Point(172, 268);
            this.orderlist_unitprice.MaxLength = 50;
            this.orderlist_unitprice.Name = "orderlist_unitprice";
            this.orderlist_unitprice.Size = new System.Drawing.Size(224, 30);
            this.orderlist_unitprice.TabIndex = 38;
            this.orderlist_unitprice.Text = "Unit Price";
            // 
            // orderlist_productid
            // 
            this.orderlist_productid.DataSource = this.productsBindingSource;
            this.orderlist_productid.DisplayMember = "product_id";
            this.orderlist_productid.FormattingEnabled = true;
            this.orderlist_productid.Location = new System.Drawing.Point(173, 422);
            this.orderlist_productid.Name = "orderlist_productid";
            this.orderlist_productid.Size = new System.Drawing.Size(224, 33);
            this.orderlist_productid.TabIndex = 33;
            this.orderlist_productid.ValueMember = "product_id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.projectsDataSet11;
            // 
            // projectsDataSet11
            // 
            this.projectsDataSet11.DataSetName = "projectsDataSet11";
            this.projectsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetail_Orderid
            // 
            this.orderdetail_Orderid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderssBindingSource, "order_id", true));
            this.orderdetail_Orderid.DataSource = this.orderssBindingSource;
            this.orderdetail_Orderid.DisplayMember = "order_id";
            this.orderdetail_Orderid.FormattingEnabled = true;
            this.orderdetail_Orderid.Location = new System.Drawing.Point(170, 480);
            this.orderdetail_Orderid.Name = "orderdetail_Orderid";
            this.orderdetail_Orderid.Size = new System.Drawing.Size(225, 33);
            this.orderdetail_Orderid.TabIndex = 39;
            this.orderdetail_Orderid.ValueMember = "order_id";
            this.orderdetail_Orderid.SelectedIndexChanged += new System.EventHandler(this.orderdetailOrderid_SelectedIndexChanged);
            // 
            // orderssBindingSource
            // 
            this.orderssBindingSource.DataMember = "orderss";
            this.orderssBindingSource.DataSource = this.projectsDataSet12;
            // 
            // projectsDataSet12
            // 
            this.projectsDataSet12.DataSetName = "projectsDataSet12";
            this.projectsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(183, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Order Detail List ";
            // 
            // orderlist_id
            // 
            this.orderlist_id.Location = new System.Drawing.Point(172, 217);
            this.orderlist_id.MaxLength = 50;
            this.orderlist_id.Name = "orderlist_id";
            this.orderlist_id.Size = new System.Drawing.Size(225, 30);
            this.orderlist_id.TabIndex = 34;
            this.orderlist_id.Text = "OrderDetail ID";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // orderssTableAdapter
            // 
            this.orderssTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 100);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.add_orderlist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_orderlist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.update_orderlist, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.view_orderlist, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderdetailsearch, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // add_orderlist
            // 
            this.add_orderlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_orderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_orderlist.Location = new System.Drawing.Point(3, 3);
            this.add_orderlist.Name = "add_orderlist";
            this.add_orderlist.Size = new System.Drawing.Size(126, 94);
            this.add_orderlist.TabIndex = 0;
            this.add_orderlist.Text = "Add";
            this.add_orderlist.UseVisualStyleBackColor = true;
            this.add_orderlist.Click += new System.EventHandler(this.add_orderlist_Click);
            // 
            // delete_orderlist
            // 
            this.delete_orderlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_orderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_orderlist.Location = new System.Drawing.Point(135, 3);
            this.delete_orderlist.Name = "delete_orderlist";
            this.delete_orderlist.Size = new System.Drawing.Size(126, 94);
            this.delete_orderlist.TabIndex = 0;
            this.delete_orderlist.Text = "Delete";
            this.delete_orderlist.UseVisualStyleBackColor = true;
            this.delete_orderlist.Click += new System.EventHandler(this.delete_orderlist_Click);
            // 
            // update_orderlist
            // 
            this.update_orderlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_orderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_orderlist.Location = new System.Drawing.Point(267, 3);
            this.update_orderlist.Name = "update_orderlist";
            this.update_orderlist.Size = new System.Drawing.Size(126, 94);
            this.update_orderlist.TabIndex = 0;
            this.update_orderlist.Text = "Update";
            this.update_orderlist.UseVisualStyleBackColor = true;
            this.update_orderlist.Click += new System.EventHandler(this.update_orderlist_Click);
            // 
            // view_orderlist
            // 
            this.view_orderlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_orderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_orderlist.Location = new System.Drawing.Point(399, 3);
            this.view_orderlist.Name = "view_orderlist";
            this.view_orderlist.Size = new System.Drawing.Size(126, 94);
            this.view_orderlist.TabIndex = 0;
            this.view_orderlist.Text = "View";
            this.view_orderlist.UseVisualStyleBackColor = true;
            this.view_orderlist.Click += new System.EventHandler(this.view_orderlist_Click);
            // 
            // orderdetailsearch
            // 
            this.orderdetailsearch.Location = new System.Drawing.Point(663, 3);
            this.orderdetailsearch.Name = "orderdetailsearch";
            this.orderdetailsearch.Size = new System.Drawing.Size(137, 26);
            this.orderdetailsearch.TabIndex = 1;
            this.orderdetailsearch.TextChanged += new System.EventHandler(this.orderdetailsearch_TextChanged);
            // 
            // orderdetaillist_dataGridView
            // 
            this.orderdetaillist_dataGridView.AutoGenerateColumns = false;
            this.orderdetaillist_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdetaillist_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderdetailidDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.orderdetaillist_dataGridView.DataSource = this.orderDetailBindingSource;
            this.orderdetaillist_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderdetaillist_dataGridView.Location = new System.Drawing.Point(0, 100);
            this.orderdetaillist_dataGridView.Name = "orderdetaillist_dataGridView";
            this.orderdetaillist_dataGridView.RowHeadersWidth = 62;
            this.orderdetaillist_dataGridView.RowTemplate.Height = 28;
            this.orderdetaillist_dataGridView.Size = new System.Drawing.Size(803, 570);
            this.orderdetaillist_dataGridView.TabIndex = 3;
            // 
            // orderdetailidDataGridViewTextBoxColumn
            // 
            this.orderdetailidDataGridViewTextBoxColumn.DataPropertyName = "order_detail_id";
            this.orderdetailidDataGridViewTextBoxColumn.HeaderText = "order_detail_id";
            this.orderdetailidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderdetailidDataGridViewTextBoxColumn.Name = "orderdetailidDataGridViewTextBoxColumn";
            this.orderdetailidDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetail";
            this.orderDetailBindingSource.DataSource = this.projectsDataSet13;
            // 
            // projectsDataSet13
            // 
            this.projectsDataSet13.DataSetName = "projectsDataSet13";
            this.projectsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailTableAdapter
            // 
            this.orderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 42);
            this.Back.TabIndex = 42;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Search by ID";
            // 
            // orderlist3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 670);
            this.Name = "orderlist3";
            this.Text = "orderlist3";
            this.Load += new System.EventHandler(this.orderlist3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet12)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetaillist_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderlist_quantity;
        private System.Windows.Forms.TextBox orderlist_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderlist_unitprice;
        private System.Windows.Forms.ComboBox orderlist_productid;
        private System.Windows.Forms.ComboBox orderdetail_Orderid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox orderlist_id;
        private projectsDataSet11 projectsDataSet11;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private projectsDataSet11TableAdapters.ProductsTableAdapter productsTableAdapter;
        private projectsDataSet12 projectsDataSet12;
        private System.Windows.Forms.BindingSource orderssBindingSource;
        private projectsDataSet12TableAdapters.orderssTableAdapter orderssTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add_orderlist;
        private System.Windows.Forms.Button delete_orderlist;
        private System.Windows.Forms.Button update_orderlist;
        private System.Windows.Forms.Button view_orderlist;
        private System.Windows.Forms.DataGridView orderdetaillist_dataGridView;
        private projectsDataSet13 projectsDataSet13;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private projectsDataSet13TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdetailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox orderdetailsearch;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label6;
    }
}