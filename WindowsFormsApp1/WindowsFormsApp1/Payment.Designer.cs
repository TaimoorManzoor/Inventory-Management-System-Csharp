namespace WindowsFormsApp1
{
    partial class Payment
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
            this.payment_id = new System.Windows.Forms.TextBox();
            this.paymenttype = new System.Windows.Forms.TextBox();
            this.totoalamount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.updatepayment = new System.Windows.Forms.Button();
            this.DeletePayment = new System.Windows.Forms.Button();
            this.ViewPayment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet14 = new WindowsFormsApp1.projectsDataSet14();
            this.paymentsTableAdapter = new WindowsFormsApp1.projectsDataSet14TableAdapters.PaymentsTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totoalamount);
            this.panel1.Controls.Add(this.paymenttype);
            this.panel1.Controls.Add(this.payment_id);
            this.panel1.Size = new System.Drawing.Size(564, 650);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.payment_id, 0);
            this.panel1.Controls.SetChildIndex(this.paymenttype, 0);
            this.panel1.Controls.SetChildIndex(this.totoalamount, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(963, 650);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(173, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Payment Information";
            // 
            // payment_id
            // 
            this.payment_id.Location = new System.Drawing.Point(172, 243);
            this.payment_id.MaxLength = 50;
            this.payment_id.Name = "payment_id";
            this.payment_id.Size = new System.Drawing.Size(225, 30);
            this.payment_id.TabIndex = 27;
            this.payment_id.Text = "Bill ID";
            // 
            // paymenttype
            // 
            this.paymenttype.Location = new System.Drawing.Point(172, 299);
            this.paymenttype.MaxLength = 50;
            this.paymenttype.Name = "paymenttype";
            this.paymenttype.Size = new System.Drawing.Size(225, 30);
            this.paymenttype.TabIndex = 27;
            this.paymenttype.Text = "Payment Type";
            // 
            // totoalamount
            // 
            this.totoalamount.Location = new System.Drawing.Point(172, 356);
            this.totoalamount.MaxLength = 50;
            this.totoalamount.Name = "totoalamount";
            this.totoalamount.Size = new System.Drawing.Size(225, 30);
            this.totoalamount.TabIndex = 27;
            this.totoalamount.Text = "Total Amount";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 100);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Controls.Add(this.add, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updatepayment, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeletePayment, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewPayment, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(3, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(149, 94);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // updatepayment
            // 
            this.updatepayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatepayment.Location = new System.Drawing.Point(158, 3);
            this.updatepayment.Name = "updatepayment";
            this.updatepayment.Size = new System.Drawing.Size(149, 94);
            this.updatepayment.TabIndex = 0;
            this.updatepayment.Text = "Update";
            this.updatepayment.UseVisualStyleBackColor = true;
            this.updatepayment.Click += new System.EventHandler(this.updatepayment_Click);
            // 
            // DeletePayment
            // 
            this.DeletePayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePayment.Location = new System.Drawing.Point(313, 3);
            this.DeletePayment.Name = "DeletePayment";
            this.DeletePayment.Size = new System.Drawing.Size(149, 94);
            this.DeletePayment.TabIndex = 0;
            this.DeletePayment.Text = "Delete";
            this.DeletePayment.UseVisualStyleBackColor = true;
            this.DeletePayment.Click += new System.EventHandler(this.DeletePayment_Click);
            // 
            // ViewPayment
            // 
            this.ViewPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPayment.Location = new System.Drawing.Point(468, 3);
            this.ViewPayment.Name = "ViewPayment";
            this.ViewPayment.Size = new System.Drawing.Size(149, 94);
            this.ViewPayment.TabIndex = 0;
            this.ViewPayment.Text = "View";
            this.ViewPayment.UseVisualStyleBackColor = true;
            this.ViewPayment.Click += new System.EventHandler(this.ViewPayment_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Location = new System.Drawing.Point(778, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billnumberDataGridViewTextBoxColumn,
            this.paymenttypeDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(963, 550);
            this.dataGridView1.TabIndex = 3;
            // 
            // billnumberDataGridViewTextBoxColumn
            // 
            this.billnumberDataGridViewTextBoxColumn.DataPropertyName = "bill_number";
            this.billnumberDataGridViewTextBoxColumn.HeaderText = "bill_number";
            this.billnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billnumberDataGridViewTextBoxColumn.Name = "billnumberDataGridViewTextBoxColumn";
            this.billnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymenttypeDataGridViewTextBoxColumn
            // 
            this.paymenttypeDataGridViewTextBoxColumn.DataPropertyName = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.HeaderText = "payment_type";
            this.paymenttypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paymenttypeDataGridViewTextBoxColumn.Name = "paymenttypeDataGridViewTextBoxColumn";
            this.paymenttypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.projectsDataSet14;
            // 
            // projectsDataSet14
            // 
            this.projectsDataSet14.DataSetName = "projectsDataSet14";
            this.projectsDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(623, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search By ID";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 650);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox payment_id;
        public System.Windows.Forms.TextBox totoalamount;
        public System.Windows.Forms.TextBox paymenttype;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button updatepayment;
        private System.Windows.Forms.Button DeletePayment;
        private System.Windows.Forms.Button ViewPayment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projectsDataSet14 projectsDataSet14;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private projectsDataSet14TableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label4;
    }
}