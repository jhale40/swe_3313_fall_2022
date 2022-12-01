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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms
{
    public partial class FormAddCustomer : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings; 
        private ICustomerService _customerService;
        public string? PhoneNumber;
        public string? FirstName;
        public string? LastName;
        
        public FormAddCustomer(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
        }

        private void bReturnToFormMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }


        //FORM ON LOAD METHOD
        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PhoneNumber);

            /*var customer = new Customer()
            {
                Phone = PhoneNumber,
                FirstName = FirstName,
                LastName = LastName,
            };

            if (_customerService.Customers[customer.Phone] == null)
            {
                MessageBox.Show("YAYYYY");

            }*/

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            
            PhoneNumber = textBoxPhone.Text;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            FirstName = textBoxFirstName.Text;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            LastName = textBoxLastName.Text;
        }
    }
}
