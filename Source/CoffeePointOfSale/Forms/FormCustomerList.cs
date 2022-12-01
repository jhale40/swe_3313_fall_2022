using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private readonly ICustomerService _customerService;

        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _appSettings = appSettings;
            _customerService = customerService;

            InitializeComponent();
        }

        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }


        private void DemonstrateGettingCustomerList()
        {
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
                //txtDeleteThis.AppendText($"{customerIdx + 1}. {customer}{Environment.NewLine}");
                //this.dataGridView1.(this.customerBindingSource);
                //($"{customerIdx + 1}. {customer}{Environment.NewLine}");
                //dataGridView1.DataSource = ($"{customerIdx + 1}. {customer}{Environment.NewLine}");

                //customerBindingSource.DataSource = customer;
                customerBindingSource.Add(customer);
            }
        }


        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            SetTitle("Customer List");

            //this.productsTableAdapter.Fill(this.Services.Customer);

            DemonstrateGettingCustomerList();
        }



        // "Order" button after each customer in the customer list
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Order")
            {
                // Stores customer into currentCustomer variable in Customers class
                _customerService.Customers.currentCustomer = (Customer?)customerBindingSource.Current;

                // Goes to OrderDrinkForm
                Close(); //closes this form
                FormFactory.Get<FormOrderDrink>().Show(); 

                //TEST TO SHOW CUSTOMER INFORMATION//MessageBox.Show(customerBindingSource.Current.ToString());
            }
            
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            // Goes to FormAddCustomer
            Close(); //closes this form
            FormFactory.Get<FormAddCustomer>().Show();
        }
    }
}
