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
        private string PhoneNumber;
        private string FirstName;
        private string LastName;
        
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

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            PhoneNumber = textBoxPhone.Text;
            FirstName = textBoxFirstName.Text;
            LastName = textBoxLastName.Text;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAYYYY");

            /*PhoneNumber = textBoxPhone.Text;
            FirstName = textBoxFirstName.Text;
            LastName = textBoxLastName.Text;*/

            var customer = new Customer()
            {
                Phone = PhoneNumber,
                FirstName = FirstName,
                LastName = LastName,
            };

            if (_customerService.Customers[customer.Phone] == null)
            {
                MessageBox.Show("YAYYYY");

            }

        }
    }
}
