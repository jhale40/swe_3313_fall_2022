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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAnonymousDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneDataGridViewTextBoxColumn,
            this.rewardPointsDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.isAnonymousDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 101);
            this.dataGridView1.TabIndex = 1;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CoffeePointOfSale.Services.Customer.Customer);
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // rewardPointsDataGridViewTextBoxColumn
            // 
            this.rewardPointsDataGridViewTextBoxColumn.DataPropertyName = "RewardPoints";
            this.rewardPointsDataGridViewTextBoxColumn.HeaderText = "RewardPoints";
            this.rewardPointsDataGridViewTextBoxColumn.Name = "rewardPointsDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // isAnonymousDataGridViewCheckBoxColumn
            // 
            this.isAnonymousDataGridViewCheckBoxColumn.DataPropertyName = "IsAnonymous";
            this.isAnonymousDataGridViewCheckBoxColumn.HeaderText = "IsAnonymous";
            this.isAnonymousDataGridViewCheckBoxColumn.Name = "isAnonymousDataGridViewCheckBoxColumn";
            this.isAnonymousDataGridViewCheckBoxColumn.ReadOnly = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToMain;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rewardPointsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAnonymousDataGridViewCheckBoxColumn;
        private BindingSource customerBindingSource;
    }
}