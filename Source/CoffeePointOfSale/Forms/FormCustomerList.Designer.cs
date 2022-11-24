namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
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
            this.bReturnToMain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bReturnToMain
            // 
            this.bReturnToMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bReturnToMain.Location = new System.Drawing.Point(1181, 650);
            this.bReturnToMain.Name = "bReturnToMain";
            this.bReturnToMain.Size = new System.Drawing.Size(115, 38);
            this.bReturnToMain.TabIndex = 0;
            this.bReturnToMain.Text = "Exit";
            this.bReturnToMain.UseVisualStyleBackColor = false;
            this.bReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.rewardPointsDataGridViewTextBoxColumn,
            this.Order});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 488);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // rewardPointsDataGridViewTextBoxColumn
            // 
            this.rewardPointsDataGridViewTextBoxColumn.DataPropertyName = "RewardPoints";
            this.rewardPointsDataGridViewTextBoxColumn.HeaderText = "RewardPoints";
            this.rewardPointsDataGridViewTextBoxColumn.Name = "rewardPointsDataGridViewTextBoxColumn";
            this.rewardPointsDataGridViewTextBoxColumn.Width = 150;
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            this.Order.Text = "Order";
            this.Order.UseColumnTextForButtonValue = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CoffeePointOfSale.Services.Customer.Customer);
            // 
            // customerServiceBindingSource
            // 
            this.customerServiceBindingSource.DataSource = typeof(CoffeePointOfSale.Services.Customer.CustomerService);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bReturnToMain);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToMain;
        private DataGridView dataGridView1;
        private BindingSource customerBindingSource;
        private BindingSource customerServiceBindingSource;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rewardPointsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Order;
    }
}