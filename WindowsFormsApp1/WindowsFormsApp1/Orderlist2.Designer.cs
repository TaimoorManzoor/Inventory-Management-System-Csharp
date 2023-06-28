namespace WindowsFormsApp1
{
    partial class Orderlist2
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
            this.label4 = new System.Windows.Forms.Label();
            this.orderdetailOrderid = new System.Windows.Forms.ComboBox();
            this.orderssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet7 = new WindowsFormsApp1.projectsDataSet7();
            this.label3 = new System.Windows.Forms.Label();
            this.orderdetailid = new System.Windows.Forms.TextBox();
            this.orderdetaillist_productid = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet6 = new WindowsFormsApp1.projectsDataSet6();
            this.orderdetaillistunitprice = new System.Windows.Forms.TextBox();
            this.orderdetaillistSize = new System.Windows.Forms.TextBox();
            this.orderdetaillistquantity = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new WindowsFormsApp1.projectsDataSet6TableAdapters.ProductsTableAdapter();
            this.orderssTableAdapter = new WindowsFormsApp1.projectsDataSet7TableAdapters.orderssTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addorderlist = new System.Windows.Forms.Button();
            this.deleteorderdetaillist = new System.Windows.Forms.Button();
            this.Updateorderdetail = new System.Windows.Forms.Button();
            this.vieworderdetail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OrderdetaildataGridView1 = new System.Windows.Forms.DataGridView();
            this.oRDERDETAILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUINANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet8 = new WindowsFormsApp1.projectsDataSet8();
            this.orderDetailTableAdapter = new WindowsFormsApp1.projectsDataSet8TableAdapters.OrderDetailTableAdapter();
            this.projectsDataSet9 = new WindowsFormsApp1.projectsDataSet9();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new WindowsFormsApp1.projectsDataSet9TableAdapters.ProductsTableAdapter();
            this.projectsDataSet10 = new WindowsFormsApp1.projectsDataSet10();
            this.orderssBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderssTableAdapter1 = new WindowsFormsApp1.projectsDataSet10TableAdapters.orderssTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet6)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetaildataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.orderdetaillistquantity);
            this.panel1.Controls.Add(this.orderdetaillistSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orderdetaillistunitprice);
            this.panel1.Controls.Add(this.orderdetaillist_productid);
            this.panel1.Controls.Add(this.orderdetailOrderid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.orderdetailid);
            this.panel1.Size = new System.Drawing.Size(564, 648);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetailid, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetailOrderid, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetaillist_productid, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetaillistunitprice, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetaillistSize, 0);
            this.panel1.Controls.SetChildIndex(this.orderdetaillistquantity, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrderdetaildataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(873, 648);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.OrderdetaildataGridView1, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 540);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(125, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(128, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Product ID";
            // 
            // orderdetailOrderid
            // 
            this.orderdetailOrderid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderssBindingSource1, "order_id", true));
            this.orderdetailOrderid.DataSource = this.orderssBindingSource1;
            this.orderdetailOrderid.DisplayMember = "order_id";
            this.orderdetailOrderid.FormattingEnabled = true;
            this.orderdetailOrderid.Location = new System.Drawing.Point(128, 495);
            this.orderdetailOrderid.Name = "orderdetailOrderid";
            this.orderdetailOrderid.Size = new System.Drawing.Size(225, 33);
            this.orderdetailOrderid.TabIndex = 29;
            this.orderdetailOrderid.ValueMember = "order_id";
            // 
            // orderssBindingSource
            // 
            this.orderssBindingSource.DataMember = "orderss";
            this.orderssBindingSource.DataSource = this.projectsDataSet7;
            // 
            // projectsDataSet7
            // 
            this.projectsDataSet7.DataSetName = "projectsDataSet7";
            this.projectsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(141, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Order Detail List ";
            // 
            // orderdetailid
            // 
            this.orderdetailid.Location = new System.Drawing.Point(130, 232);
            this.orderdetailid.MaxLength = 50;
            this.orderdetailid.Name = "orderdetailid";
            this.orderdetailid.Size = new System.Drawing.Size(225, 30);
            this.orderdetailid.TabIndex = 27;
            this.orderdetailid.Text = "OrderDetail ID";
            // 
            // orderdetaillist_productid
            // 
            this.orderdetaillist_productid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource1, "product_id", true));
            this.orderdetaillist_productid.DataSource = this.productsBindingSource1;
            this.orderdetaillist_productid.DisplayMember = "product_id";
            this.orderdetaillist_productid.FormattingEnabled = true;
            this.orderdetaillist_productid.Location = new System.Drawing.Point(131, 437);
            this.orderdetaillist_productid.Name = "orderdetaillist_productid";
            this.orderdetaillist_productid.Size = new System.Drawing.Size(224, 33);
            this.orderdetaillist_productid.TabIndex = 26;
            this.orderdetaillist_productid.ValueMember = "product_id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.projectsDataSet6;
            // 
            // projectsDataSet6
            // 
            this.projectsDataSet6.DataSetName = "projectsDataSet6";
            this.projectsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetaillistunitprice
            // 
            this.orderdetaillistunitprice.Location = new System.Drawing.Point(130, 283);
            this.orderdetaillistunitprice.MaxLength = 50;
            this.orderdetaillistunitprice.Name = "orderdetaillistunitprice";
            this.orderdetaillistunitprice.Size = new System.Drawing.Size(224, 30);
            this.orderdetaillistunitprice.TabIndex = 29;
            this.orderdetaillistunitprice.Text = "Unit Price";
            // 
            // orderdetaillistSize
            // 
            this.orderdetaillistSize.Location = new System.Drawing.Point(130, 333);
            this.orderdetaillistSize.MaxLength = 50;
            this.orderdetaillistSize.Name = "orderdetaillistSize";
            this.orderdetaillistSize.Size = new System.Drawing.Size(224, 30);
            this.orderdetaillistSize.TabIndex = 29;
            this.orderdetaillistSize.Text = "Size";
            // 
            // orderdetaillistquantity
            // 
            this.orderdetaillistquantity.Location = new System.Drawing.Point(131, 383);
            this.orderdetaillistquantity.MaxLength = 50;
            this.orderdetaillistquantity.Name = "orderdetaillistquantity";
            this.orderdetaillistquantity.Size = new System.Drawing.Size(224, 30);
            this.orderdetaillistquantity.TabIndex = 29;
            this.orderdetaillistquantity.Text = "Quantity";
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
            this.panel3.Size = new System.Drawing.Size(873, 100);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.addorderlist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteorderdetaillist, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Updateorderdetail, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.vieworderdetail, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addorderlist
            // 
            this.addorderlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addorderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addorderlist.Location = new System.Drawing.Point(3, 3);
            this.addorderlist.Name = "addorderlist";
            this.addorderlist.Size = new System.Drawing.Size(168, 94);
            this.addorderlist.TabIndex = 0;
            this.addorderlist.Text = "Add";
            this.addorderlist.UseVisualStyleBackColor = true;
            this.addorderlist.Click += new System.EventHandler(this.addorderlist_Click);
            // 
            // deleteorderdetaillist
            // 
            this.deleteorderdetaillist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteorderdetaillist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteorderdetaillist.Location = new System.Drawing.Point(177, 3);
            this.deleteorderdetaillist.Name = "deleteorderdetaillist";
            this.deleteorderdetaillist.Size = new System.Drawing.Size(168, 94);
            this.deleteorderdetaillist.TabIndex = 0;
            this.deleteorderdetaillist.Text = "Delete";
            this.deleteorderdetaillist.UseVisualStyleBackColor = true;
            // 
            // Updateorderdetail
            // 
            this.Updateorderdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Updateorderdetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updateorderdetail.Location = new System.Drawing.Point(351, 3);
            this.Updateorderdetail.Name = "Updateorderdetail";
            this.Updateorderdetail.Size = new System.Drawing.Size(168, 94);
            this.Updateorderdetail.TabIndex = 0;
            this.Updateorderdetail.Text = "Update";
            this.Updateorderdetail.UseVisualStyleBackColor = true;
            // 
            // vieworderdetail
            // 
            this.vieworderdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vieworderdetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vieworderdetail.Location = new System.Drawing.Point(525, 3);
            this.vieworderdetail.Name = "vieworderdetail";
            this.vieworderdetail.Size = new System.Drawing.Size(168, 94);
            this.vieworderdetail.TabIndex = 0;
            this.vieworderdetail.Text = "View";
            this.vieworderdetail.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Location = new System.Drawing.Point(699, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search";
            // 
            // OrderdetaildataGridView1
            // 
            this.OrderdetaildataGridView1.AutoGenerateColumns = false;
            this.OrderdetaildataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdetaildataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERDETAILIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.qUINANTITYDataGridViewTextBoxColumn});
            this.OrderdetaildataGridView1.DataSource = this.orderDetailBindingSource;
            this.OrderdetaildataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderdetaildataGridView1.Location = new System.Drawing.Point(0, 100);
            this.OrderdetaildataGridView1.Name = "OrderdetaildataGridView1";
            this.OrderdetaildataGridView1.RowHeadersWidth = 62;
            this.OrderdetaildataGridView1.RowTemplate.Height = 28;
            this.OrderdetaildataGridView1.Size = new System.Drawing.Size(873, 548);
            this.OrderdetaildataGridView1.TabIndex = 3;
            // 
            // oRDERDETAILIDDataGridViewTextBoxColumn
            // 
            this.oRDERDETAILIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER DETAIL ID";
            this.oRDERDETAILIDDataGridViewTextBoxColumn.HeaderText = "ORDER DETAIL ID";
            this.oRDERDETAILIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.oRDERDETAILIDDataGridViewTextBoxColumn.Name = "oRDERDETAILIDDataGridViewTextBoxColumn";
            this.oRDERDETAILIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // qUINANTITYDataGridViewTextBoxColumn
            // 
            this.qUINANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUINANTITY";
            this.qUINANTITYDataGridViewTextBoxColumn.HeaderText = "QUINANTITY";
            this.qUINANTITYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qUINANTITYDataGridViewTextBoxColumn.Name = "qUINANTITYDataGridViewTextBoxColumn";
            this.qUINANTITYDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataMember = "OrderDetail";
            this.orderDetailBindingSource.DataSource = this.projectsDataSet8;
            // 
            // projectsDataSet8
            // 
            this.projectsDataSet8.DataSetName = "projectsDataSet8";
            this.projectsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailTableAdapter
            // 
            this.orderDetailTableAdapter.ClearBeforeFill = true;
            // 
            // projectsDataSet9
            // 
            this.projectsDataSet9.DataSetName = "projectsDataSet9";
            this.projectsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.projectsDataSet9;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsDataSet10
            // 
            this.projectsDataSet10.DataSetName = "projectsDataSet10";
            this.projectsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderssBindingSource1
            // 
            this.orderssBindingSource1.DataMember = "orderss";
            this.orderssBindingSource1.DataSource = this.projectsDataSet10;
            // 
            // orderssTableAdapter1
            // 
            this.orderssTableAdapter1.ClearBeforeFill = true;
            // 
            // Orderlist2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 648);
            this.Name = "Orderlist2";
            this.Text = "Orderlist2";
            this.Load += new System.EventHandler(this.Orderlist2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetaildataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderssBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderdetailOrderid;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox orderdetailid;
        private System.Windows.Forms.ComboBox orderdetaillist_productid;
        private System.Windows.Forms.TextBox orderdetaillistquantity;
        private System.Windows.Forms.TextBox orderdetaillistSize;
        private System.Windows.Forms.TextBox orderdetaillistunitprice;
        private projectsDataSet6 projectsDataSet6;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private projectsDataSet6TableAdapters.ProductsTableAdapter productsTableAdapter;
        private projectsDataSet7 projectsDataSet7;
        private System.Windows.Forms.BindingSource orderssBindingSource;
        private projectsDataSet7TableAdapters.orderssTableAdapter orderssTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addorderlist;
        private System.Windows.Forms.Button deleteorderdetaillist;
        private System.Windows.Forms.Button Updateorderdetail;
        private System.Windows.Forms.Button vieworderdetail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView OrderdetaildataGridView1;
        private projectsDataSet8 projectsDataSet8;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private projectsDataSet8TableAdapters.OrderDetailTableAdapter orderDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERDETAILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUINANTITYDataGridViewTextBoxColumn;
        private projectsDataSet9 projectsDataSet9;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private projectsDataSet9TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private projectsDataSet10 projectsDataSet10;
        private System.Windows.Forms.BindingSource orderssBindingSource1;
        private projectsDataSet10TableAdapters.orderssTableAdapter orderssTableAdapter1;
    }
}