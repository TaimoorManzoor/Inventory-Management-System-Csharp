namespace WindowsFormsApp1
{
    partial class Product2
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
            this.label3 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.productprice = new System.Windows.Forms.TextBox();
            this.productunit = new System.Windows.Forms.TextBox();
            this.productSupplier = new System.Windows.Forms.TextBox();
            this.productCategory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewproduct = new System.Windows.Forms.Button();
            this.updateproduct = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.addproduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet1 = new WindowsFormsApp1.projectsDataSet1();
            this.projectsDataSet = new WindowsFormsApp1.projectsDataSet();
            this.projectsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp1.projectsDataSet1TableAdapters.ProductsTableAdapter();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.productCategory);
            this.panel1.Controls.Add(this.productSupplier);
            this.panel1.Controls.Add(this.productunit);
            this.panel1.Controls.Add(this.productprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.productname);
            this.panel1.Controls.Add(this.productid);
            this.panel1.Size = new System.Drawing.Size(564, 622);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.productid, 0);
            this.panel1.Controls.SetChildIndex(this.productname, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.productprice, 0);
            this.panel1.Controls.SetChildIndex(this.productunit, 0);
            this.panel1.Controls.SetChildIndex(this.productSupplier, 0);
            this.panel1.Controls.SetChildIndex(this.productCategory, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductDataGridView);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Size = new System.Drawing.Size(1056, 622);
            this.panel2.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.ProductDataGridView, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 577);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(174, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Information";
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(170, 292);
            this.productname.MaxLength = 50;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(225, 30);
            this.productname.TabIndex = 9;
            this.productname.Text = "Product Name";
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(170, 235);
            this.productid.MaxLength = 50;
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(225, 30);
            this.productid.TabIndex = 10;
            this.productid.Text = "Product ID";
            // 
            // productprice
            // 
            this.productprice.Location = new System.Drawing.Point(170, 339);
            this.productprice.MaxLength = 50;
            this.productprice.Name = "productprice";
            this.productprice.Size = new System.Drawing.Size(225, 30);
            this.productprice.TabIndex = 13;
            this.productprice.Text = "Product Price";
            // 
            // productunit
            // 
            this.productunit.Location = new System.Drawing.Point(170, 395);
            this.productunit.MaxLength = 50;
            this.productunit.Name = "productunit";
            this.productunit.Size = new System.Drawing.Size(225, 30);
            this.productunit.TabIndex = 14;
            this.productunit.Text = "Product Unit";
            // 
            // productSupplier
            // 
            this.productSupplier.Location = new System.Drawing.Point(170, 449);
            this.productSupplier.MaxLength = 50;
            this.productSupplier.Name = "productSupplier";
            this.productSupplier.Size = new System.Drawing.Size(225, 30);
            this.productSupplier.TabIndex = 14;
            this.productSupplier.Text = "Supplier ID";
            // 
            // productCategory
            // 
            this.productCategory.Location = new System.Drawing.Point(170, 504);
            this.productCategory.MaxLength = 50;
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(225, 30);
            this.productCategory.TabIndex = 14;
            this.productCategory.Text = "Category ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.viewproduct, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateproduct, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteproduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addproduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // viewproduct
            // 
            this.viewproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewproduct.Location = new System.Drawing.Point(558, 3);
            this.viewproduct.Name = "viewproduct";
            this.viewproduct.Size = new System.Drawing.Size(179, 94);
            this.viewproduct.TabIndex = 3;
            this.viewproduct.Text = "View";
            this.viewproduct.UseVisualStyleBackColor = true;
            this.viewproduct.Click += new System.EventHandler(this.viewproduct_Click);
            // 
            // updateproduct
            // 
            this.updateproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateproduct.Location = new System.Drawing.Point(373, 3);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(179, 94);
            this.updateproduct.TabIndex = 2;
            this.updateproduct.Text = "Update ";
            this.updateproduct.UseVisualStyleBackColor = true;
            this.updateproduct.Click += new System.EventHandler(this.updateproduct_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteproduct.Location = new System.Drawing.Point(188, 3);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(179, 94);
            this.deleteproduct.TabIndex = 1;
            this.deleteproduct.Text = "Delete";
            this.deleteproduct.UseVisualStyleBackColor = true;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // addproduct
            // 
            this.addproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproduct.Location = new System.Drawing.Point(3, 3);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(179, 94);
            this.addproduct.TabIndex = 0;
            this.addproduct.Text = "Add";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(928, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(743, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search By Product ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productunitDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn});
            this.ProductDataGridView.DataSource = this.productsBindingSource;
            this.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGridView.Location = new System.Drawing.Point(0, 100);
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.RowHeadersWidth = 62;
            this.ProductDataGridView.RowTemplate.Height = 28;
            this.ProductDataGridView.Size = new System.Drawing.Size(1056, 522);
            this.ProductDataGridView.TabIndex = 3;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productunitDataGridViewTextBoxColumn
            // 
            this.productunitDataGridViewTextBoxColumn.DataPropertyName = "product_unit";
            this.productunitDataGridViewTextBoxColumn.HeaderText = "product_unit";
            this.productunitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productunitDataGridViewTextBoxColumn.Name = "productunitDataGridViewTextBoxColumn";
            this.productunitDataGridViewTextBoxColumn.Width = 150;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.projectsDataSet1;
            // 
            // projectsDataSet1
            // 
            this.projectsDataSet1.DataSetName = "projectsDataSet1";
            this.projectsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsDataSet
            // 
            this.projectsDataSet.DataSetName = "projectsDataSet";
            this.projectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsDataSetBindingSource
            // 
            this.projectsDataSetBindingSource.DataSource = this.projectsDataSet;
            this.projectsDataSetBindingSource.Position = 0;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(3, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 42);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Product2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 622);
            this.Name = "Product2";
            this.Text = "Product2";
            this.Load += new System.EventHandler(this.Product2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox productunit;
        private System.Windows.Forms.TextBox productprice;
        private System.Windows.Forms.TextBox productCategory;
        private System.Windows.Forms.TextBox productSupplier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button viewproduct;
        private System.Windows.Forms.Button updateproduct;
        private System.Windows.Forms.Button deleteproduct;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        public System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.BindingSource projectsDataSetBindingSource;
        private projectsDataSet projectsDataSet;
        private projectsDataSet1 projectsDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private projectsDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
    }
}