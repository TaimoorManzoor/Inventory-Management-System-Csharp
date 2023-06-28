namespace WindowsFormsApp1
{
    partial class Supplier2
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
            this.Supplier_email = new System.Windows.Forms.TextBox();
            this.Supplier_phonenumber = new System.Windows.Forms.TextBox();
            this.SupplierAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.SupplierId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_Supplier = new System.Windows.Forms.TextBox();
            this.AddSupplier = new System.Windows.Forms.Button();
            this.DeleteSupplier = new System.Windows.Forms.Button();
            this.UpdateSupplier = new System.Windows.Forms.Button();
            this.ViewSupplier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsDataSet15 = new WindowsFormsApp1.projectsDataSet15();
            this.sUPPLIERSTableAdapter = new WindowsFormsApp1.projectsDataSet15TableAdapters.SUPPLIERSTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Supplier_email);
            this.panel1.Controls.Add(this.Supplier_phonenumber);
            this.panel1.Controls.Add(this.SupplierAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SupplierName);
            this.panel1.Controls.Add(this.SupplierId);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.SupplierId, 0);
            this.panel1.Controls.SetChildIndex(this.SupplierName, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.SupplierAddress, 0);
            this.panel1.Controls.SetChildIndex(this.Supplier_phonenumber, 0);
            this.panel1.Controls.SetChildIndex(this.Supplier_email, 0);
            this.panel1.Controls.SetChildIndex(this.Back, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 19);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(955, 636);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // Supplier_email
            // 
            this.Supplier_email.Location = new System.Drawing.Point(165, 440);
            this.Supplier_email.MaxLength = 50;
            this.Supplier_email.Name = "Supplier_email";
            this.Supplier_email.Size = new System.Drawing.Size(225, 30);
            this.Supplier_email.TabIndex = 26;
            this.Supplier_email.Text = "Supplier Email";
            // 
            // Supplier_phonenumber
            // 
            this.Supplier_phonenumber.Location = new System.Drawing.Point(165, 386);
            this.Supplier_phonenumber.MaxLength = 50;
            this.Supplier_phonenumber.Name = "Supplier_phonenumber";
            this.Supplier_phonenumber.Size = new System.Drawing.Size(225, 30);
            this.Supplier_phonenumber.TabIndex = 27;
            this.Supplier_phonenumber.Text = "Supplier Phone Number";
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.Location = new System.Drawing.Point(165, 330);
            this.SupplierAddress.MaxLength = 50;
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.Size = new System.Drawing.Size(225, 30);
            this.SupplierAddress.TabIndex = 25;
            this.SupplierAddress.Text = "Supplier Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(161, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Supplier Information";
            // 
            // SupplierName
            // 
            this.SupplierName.Location = new System.Drawing.Point(165, 283);
            this.SupplierName.MaxLength = 50;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(225, 30);
            this.SupplierName.TabIndex = 22;
            this.SupplierName.Text = "Supplier Name";
            // 
            // SupplierId
            // 
            this.SupplierId.Location = new System.Drawing.Point(165, 226);
            this.SupplierId.MaxLength = 50;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Size = new System.Drawing.Size(225, 30);
            this.SupplierId.TabIndex = 23;
            this.SupplierId.Text = "Supplier ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 100);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddSupplier, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteSupplier, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateSupplier, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewSupplier, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Search_Supplier, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Search_Supplier
            // 
            this.Search_Supplier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Search_Supplier.ForeColor = System.Drawing.Color.CadetBlue;
            this.Search_Supplier.Location = new System.Drawing.Point(773, 71);
            this.Search_Supplier.Name = "Search_Supplier";
            this.Search_Supplier.Size = new System.Drawing.Size(179, 26);
            this.Search_Supplier.TabIndex = 3;
            this.Search_Supplier.TextChanged += new System.EventHandler(this.Search_Supplier_TextChanged);
            // 
            // AddSupplier
            // 
            this.AddSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplier.Location = new System.Drawing.Point(3, 3);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(148, 94);
            this.AddSupplier.TabIndex = 0;
            this.AddSupplier.Text = "Add";
            this.AddSupplier.UseVisualStyleBackColor = true;
            this.AddSupplier.Click += new System.EventHandler(this.AddSupplier_Click);
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSupplier.Location = new System.Drawing.Point(157, 3);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(148, 94);
            this.DeleteSupplier.TabIndex = 0;
            this.DeleteSupplier.Text = "Delete";
            this.DeleteSupplier.UseVisualStyleBackColor = true;
            this.DeleteSupplier.Click += new System.EventHandler(this.DeleteSupplier_Click);
            // 
            // UpdateSupplier
            // 
            this.UpdateSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSupplier.Location = new System.Drawing.Point(311, 3);
            this.UpdateSupplier.Name = "UpdateSupplier";
            this.UpdateSupplier.Size = new System.Drawing.Size(148, 94);
            this.UpdateSupplier.TabIndex = 0;
            this.UpdateSupplier.Text = "Update";
            this.UpdateSupplier.UseVisualStyleBackColor = true;
            this.UpdateSupplier.Click += new System.EventHandler(this.UpdateSupplier_Click);
            // 
            // ViewSupplier
            // 
            this.ViewSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSupplier.Location = new System.Drawing.Point(465, 3);
            this.ViewSupplier.Name = "ViewSupplier";
            this.ViewSupplier.Size = new System.Drawing.Size(148, 94);
            this.ViewSupplier.TabIndex = 0;
            this.ViewSupplier.Text = "View";
            this.ViewSupplier.UseVisualStyleBackColor = true;
            this.ViewSupplier.Click += new System.EventHandler(this.ViewSupplier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sUPPLIERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(955, 536);
            this.dataGridView1.TabIndex = 3;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
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
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.projectsDataSet15;
            // 
            // projectsDataSet15
            // 
            this.projectsDataSet15.DataSetName = "projectsDataSet15";
            this.projectsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(-3, 0);
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
            this.label4.Location = new System.Drawing.Point(619, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Search by id";
            // 
            // Supplier2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 636);
            this.Name = "Supplier2";
            this.Text = "Supplier2";
            this.Load += new System.EventHandler(this.Supplier2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Supplier_email;
        private System.Windows.Forms.TextBox Supplier_phonenumber;
        private System.Windows.Forms.TextBox SupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierName;
        public System.Windows.Forms.TextBox SupplierId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.Button DeleteSupplier;
        private System.Windows.Forms.Button UpdateSupplier;
        private System.Windows.Forms.Button ViewSupplier;
        private System.Windows.Forms.TextBox Search_Supplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projectsDataSet15 projectsDataSet15;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private projectsDataSet15TableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label4;
    }
}