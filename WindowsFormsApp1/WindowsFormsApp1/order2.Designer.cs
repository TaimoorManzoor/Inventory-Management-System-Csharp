namespace WindowsFormsApp1
{
    partial class order2
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
            this.ordercustomerid = new System.Windows.Forms.ComboBox();
            this.customerSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet3 = new WindowsFormsApp1.projectsDataSet3();
            this.customerSTableAdapter = new WindowsFormsApp1.projectsDataSet3TableAdapters.CustomerSTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.orderid = new System.Windows.Forms.TextBox();
            this.billnumber = new System.Windows.Forms.ComboBox();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet4 = new WindowsFormsApp1.projectsDataSet4();
            this.paymentTableAdapter = new WindowsFormsApp1.projectsDataSet4TableAdapters.paymentTableAdapter();
            this.dateTimeorder = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderadd = new System.Windows.Forms.Button();
            this.orderdelete = new System.Windows.Forms.Button();
            this.orderupdate = new System.Windows.Forms.Button();
            this.orderview = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDataGridview = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoforderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet5 = new WindowsFormsApp1.projectsDataSet5();
            this.ordersTableAdapter = new WindowsFormsApp1.projectsDataSet5TableAdapters.ordersTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimeorder);
            this.panel1.Controls.Add(this.billnumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.orderid);
            this.panel1.Controls.Add(this.ordercustomerid);
            this.panel1.Size = new System.Drawing.Size(564, 628);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.ordercustomerid, 0);
            this.panel1.Controls.SetChildIndex(this.orderid, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.billnumber, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimeorder, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.OrderDataGridview);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(811, 628);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.OrderDataGridview, 0);
            this.panel2.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 530);
            // 
            // ordercustomerid
            // 
            this.ordercustomerid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerSBindingSource, "customer_id", true));
            this.ordercustomerid.DataSource = this.customerSBindingSource;
            this.ordercustomerid.DisplayMember = "customer_id";
            this.ordercustomerid.FormattingEnabled = true;
            this.ordercustomerid.Location = new System.Drawing.Point(145, 295);
            this.ordercustomerid.Name = "ordercustomerid";
            this.ordercustomerid.Size = new System.Drawing.Size(224, 33);
            this.ordercustomerid.TabIndex = 1;
            this.ordercustomerid.ValueMember = "customer_id";
            // 
            // customerSBindingSource
            // 
            this.customerSBindingSource.DataMember = "CustomerS";
            this.customerSBindingSource.DataSource = this.projectsDataSet3;
            // 
            // projectsDataSet3
            // 
            this.projectsDataSet3.DataSetName = "projectsDataSet3";
            this.projectsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerSTableAdapter
            // 
            this.customerSTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(156, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(145, 226);
            this.orderid.MaxLength = 50;
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(225, 30);
            this.orderid.TabIndex = 20;
            this.orderid.Text = "Order ID";
            // 
            // billnumber
            // 
            this.billnumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentBindingSource, "bill_number", true));
            this.billnumber.DataSource = this.paymentBindingSource;
            this.billnumber.DisplayMember = "bill_number";
            this.billnumber.FormattingEnabled = true;
            this.billnumber.Location = new System.Drawing.Point(144, 367);
            this.billnumber.Name = "billnumber";
            this.billnumber.Size = new System.Drawing.Size(225, 33);
            this.billnumber.TabIndex = 22;
            this.billnumber.ValueMember = "bill_number";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.projectsDataSet4;
            // 
            // projectsDataSet4
            // 
            this.projectsDataSet4.DataSetName = "projectsDataSet4";
            this.projectsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeorder
            // 
            this.dateTimeorder.Checked = false;
            this.dateTimeorder.CustomFormat = "";
            this.dateTimeorder.Location = new System.Drawing.Point(145, 420);
            this.dateTimeorder.Name = "dateTimeorder";
            this.dateTimeorder.Size = new System.Drawing.Size(225, 30);
            this.dateTimeorder.TabIndex = 23;
            this.dateTimeorder.Value = new System.DateTime(2022, 1, 8, 0, 0, 0, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(811, 100);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.82491F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.85203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.20839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.34525F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderadd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderdelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderupdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.orderview, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // orderadd
            // 
            this.orderadd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderadd.Location = new System.Drawing.Point(3, 3);
            this.orderadd.Name = "orderadd";
            this.orderadd.Size = new System.Drawing.Size(105, 94);
            this.orderadd.TabIndex = 0;
            this.orderadd.Text = "Add";
            this.orderadd.UseVisualStyleBackColor = true;
            this.orderadd.Click += new System.EventHandler(this.orderadd_Click);
            // 
            // orderdelete
            // 
            this.orderdelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderdelete.Location = new System.Drawing.Point(114, 3);
            this.orderdelete.Name = "orderdelete";
            this.orderdelete.Size = new System.Drawing.Size(139, 94);
            this.orderdelete.TabIndex = 0;
            this.orderdelete.Text = "Delete";
            this.orderdelete.UseVisualStyleBackColor = true;
            this.orderdelete.Click += new System.EventHandler(this.orderdelete_Click);
            // 
            // orderupdate
            // 
            this.orderupdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderupdate.Location = new System.Drawing.Point(259, 3);
            this.orderupdate.Name = "orderupdate";
            this.orderupdate.Size = new System.Drawing.Size(126, 94);
            this.orderupdate.TabIndex = 0;
            this.orderupdate.Text = "Update";
            this.orderupdate.UseVisualStyleBackColor = true;
            this.orderupdate.Click += new System.EventHandler(this.orderupdate_Click);
            // 
            // orderview
            // 
            this.orderview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderview.Location = new System.Drawing.Point(391, 3);
            this.orderview.Name = "orderview";
            this.orderview.Size = new System.Drawing.Size(135, 94);
            this.orderview.TabIndex = 0;
            this.orderview.Text = "View";
            this.orderview.UseVisualStyleBackColor = true;
            this.orderview.Click += new System.EventHandler(this.orderview_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Location = new System.Drawing.Point(667, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(142, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(141, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bill number";
            // 
            // OrderDataGridview
            // 
            this.OrderDataGridview.AutoGenerateColumns = false;
            this.OrderDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.dateoforderDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.billnumberDataGridViewTextBoxColumn});
            this.OrderDataGridview.DataSource = this.ordersBindingSource;
            this.OrderDataGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridview.Location = new System.Drawing.Point(0, 100);
            this.OrderDataGridview.Name = "OrderDataGridview";
            this.OrderDataGridview.RowHeadersWidth = 62;
            this.OrderDataGridview.RowTemplate.Height = 28;
            this.OrderDataGridview.Size = new System.Drawing.Size(811, 528);
            this.OrderDataGridview.TabIndex = 3;
            this.OrderDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridview_CellContentClick);
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateoforderDataGridViewTextBoxColumn
            // 
            this.dateoforderDataGridViewTextBoxColumn.DataPropertyName = "date_of_order";
            this.dateoforderDataGridViewTextBoxColumn.HeaderText = "date_of_order";
            this.dateoforderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateoforderDataGridViewTextBoxColumn.Name = "dateoforderDataGridViewTextBoxColumn";
            this.dateoforderDataGridViewTextBoxColumn.Width = 150;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // billnumberDataGridViewTextBoxColumn
            // 
            this.billnumberDataGridViewTextBoxColumn.DataPropertyName = "bill_number";
            this.billnumberDataGridViewTextBoxColumn.HeaderText = "bill_number";
            this.billnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billnumberDataGridViewTextBoxColumn.Name = "billnumberDataGridViewTextBoxColumn";
            this.billnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.projectsDataSet5;
            // 
            // projectsDataSet5
            // 
            this.projectsDataSet5.DataSetName = "projectsDataSet5";
            this.projectsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 42);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(532, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search by ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(462, 595);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 628);
            this.Name = "order2";
            this.Text = "order2";
            this.Load += new System.EventHandler(this.order2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ordercustomerid;
        private projectsDataSet3 projectsDataSet3;
        private System.Windows.Forms.BindingSource customerSBindingSource;
        private projectsDataSet3TableAdapters.CustomerSTableAdapter customerSTableAdapter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.ComboBox billnumber;
        private projectsDataSet4 projectsDataSet4;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private projectsDataSet4TableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeorder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button orderadd;
        private System.Windows.Forms.Button orderdelete;
        private System.Windows.Forms.Button orderupdate;
        private System.Windows.Forms.Button orderview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private projectsDataSet5 projectsDataSet5;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private projectsDataSet5TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoforderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView OrderDataGridview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}