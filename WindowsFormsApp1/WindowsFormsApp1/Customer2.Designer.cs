namespace WindowsFormsApp1
{
    partial class Customer2
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
            this.customeremail = new System.Windows.Forms.TextBox();
            this.customerphonenumber = new System.Windows.Forms.TextBox();
            this.customeraddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customername = new System.Windows.Forms.TextBox();
            this.customerid = new System.Windows.Forms.TextBox();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet2 = new WindowsFormsApp1.projectsDataSet2();
            this.customerSTableAdapter = new WindowsFormsApp1.projectsDataSet2TableAdapters.CustomerSTableAdapter();
            this.customerview = new System.Windows.Forms.Button();
            this.customerupdate = new System.Windows.Forms.Button();
            this.customerdelete = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customersearch = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.customeremail);
            this.panel1.Controls.Add(this.customerphonenumber);
            this.panel1.Controls.Add(this.customeraddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customername);
            this.panel1.Controls.Add(this.customerid);
            this.panel1.Size = new System.Drawing.Size(564, 635);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.customerid, 0);
            this.panel1.Controls.SetChildIndex(this.customername, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.customeraddress, 0);
            this.panel1.Controls.SetChildIndex(this.customerphonenumber, 0);
            this.panel1.Controls.SetChildIndex(this.customeremail, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.CustomerDataGridView);
            this.panel2.Size = new System.Drawing.Size(854, 635);
            this.panel2.Controls.SetChildIndex(this.CustomerDataGridView, 0);
            this.panel2.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 599);
            // 
            // customeremail
            // 
            this.customeremail.Location = new System.Drawing.Point(170, 411);
            this.customeremail.MaxLength = 50;
            this.customeremail.Name = "customeremail";
            this.customeremail.Size = new System.Drawing.Size(225, 30);
            this.customeremail.TabIndex = 20;
            this.customeremail.Text = "Email";
            // 
            // customerphonenumber
            // 
            this.customerphonenumber.Location = new System.Drawing.Point(170, 357);
            this.customerphonenumber.MaxLength = 50;
            this.customerphonenumber.Name = "customerphonenumber";
            this.customerphonenumber.Size = new System.Drawing.Size(225, 30);
            this.customerphonenumber.TabIndex = 21;
            this.customerphonenumber.Text = "Phone Number";
            // 
            // customeraddress
            // 
            this.customeraddress.Location = new System.Drawing.Point(170, 301);
            this.customeraddress.MaxLength = 50;
            this.customeraddress.Name = "customeraddress";
            this.customeraddress.Size = new System.Drawing.Size(225, 30);
            this.customeraddress.TabIndex = 18;
            this.customeraddress.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(166, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Customer Information";
            // 
            // customername
            // 
            this.customername.Location = new System.Drawing.Point(170, 254);
            this.customername.MaxLength = 50;
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(225, 30);
            this.customername.TabIndex = 15;
            this.customername.Text = "Customer Name";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(170, 197);
            this.customerid.MaxLength = 50;
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(225, 30);
            this.customerid.TabIndex = 16;
            this.customerid.Text = "Customer ID";
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AutoGenerateColumns = false;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.CustomerDataGridView.DataSource = this.customerSBindingSource;
            this.CustomerDataGridView.Location = new System.Drawing.Point(3, 103);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersWidth = 62;
            this.CustomerDataGridView.RowTemplate.Height = 28;
            this.CustomerDataGridView.Size = new System.Drawing.Size(959, 544);
            this.CustomerDataGridView.TabIndex = 4;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerSBindingSource
            // 
            this.customerSBindingSource.DataMember = "CustomerS";
            this.customerSBindingSource.DataSource = this.projectsDataSet2;
            // 
            // projectsDataSet2
            // 
            this.projectsDataSet2.DataSetName = "projectsDataSet2";
            this.projectsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerSTableAdapter
            // 
            this.customerSTableAdapter.ClearBeforeFill = true;
            // 
            // customerview
            // 
            this.customerview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerview.Location = new System.Drawing.Point(513, 3);
            this.customerview.Name = "customerview";
            this.customerview.Size = new System.Drawing.Size(164, 94);
            this.customerview.TabIndex = 0;
            this.customerview.Text = "View";
            this.customerview.UseVisualStyleBackColor = true;
            this.customerview.Click += new System.EventHandler(this.customerview_Click);
            // 
            // customerupdate
            // 
            this.customerupdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerupdate.Location = new System.Drawing.Point(343, 3);
            this.customerupdate.Name = "customerupdate";
            this.customerupdate.Size = new System.Drawing.Size(164, 94);
            this.customerupdate.TabIndex = 0;
            this.customerupdate.Text = "Update";
            this.customerupdate.UseVisualStyleBackColor = true;
            this.customerupdate.Click += new System.EventHandler(this.customerupdate_Click);
            // 
            // customerdelete
            // 
            this.customerdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerdelete.Location = new System.Drawing.Point(173, 3);
            this.customerdelete.Name = "customerdelete";
            this.customerdelete.Size = new System.Drawing.Size(164, 94);
            this.customerdelete.TabIndex = 0;
            this.customerdelete.Text = "Delete";
            this.customerdelete.UseVisualStyleBackColor = true;
            this.customerdelete.Click += new System.EventHandler(this.customerdelete_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomer.Location = new System.Drawing.Point(3, 3);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(164, 94);
            this.AddCustomer.TabIndex = 0;
            this.AddCustomer.Text = "Add";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.AddCustomer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerdelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerupdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.customerview, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.customersearch, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // customersearch
            // 
            this.customersearch.ForeColor = System.Drawing.Color.CadetBlue;
            this.customersearch.Location = new System.Drawing.Point(683, 3);
            this.customersearch.Name = "customersearch";
            this.customersearch.Size = new System.Drawing.Size(100, 26);
            this.customersearch.TabIndex = 1;
            this.customersearch.Text = "Search";
            this.customersearch.TextChanged += new System.EventHandler(this.customersearch_TextChanged);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 42);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Customer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 635);
            this.Name = "Customer2";
            this.Text = "Customer2";
            this.Load += new System.EventHandler(this.Customer2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox customeremail;
        private System.Windows.Forms.TextBox customerphonenumber;
        private System.Windows.Forms.TextBox customeraddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customername;
        public System.Windows.Forms.TextBox customerid;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private projectsDataSet2 projectsDataSet2;
        private System.Windows.Forms.BindingSource customerSBindingSource;
        private projectsDataSet2TableAdapters.CustomerSTableAdapter customerSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button customerdelete;
        private System.Windows.Forms.Button customerupdate;
        private System.Windows.Forms.Button customerview;
        private System.Windows.Forms.TextBox customersearch;
        private System.Windows.Forms.Button Back;
    }
}