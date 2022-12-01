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
            Close();// Closes this Form
            FormFactory.Get<FormMain>().Show();// Go to FormMain
        }


        //FORM ON LOAD METHOD
        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        public string? GetPhoneNumber()
        {
            return PhoneNumber;
        }

        // Creates a Customer and checks if Customers phone number exist in 
        // the Customers Dictionary. If it doesn't exist then the new Customer
        // will be added and then sent to the Order Drink Screen
        public void AddNewCustomer(string? phoneNumber)
        {
            var customer = new Customer()
            {
                Phone = phoneNumber,
                FirstName = FirstName,
                LastName = LastName,
                RewardPoints = 0
            };


            if (_customerService.Customers[customer.Phone] == null)
            {
                _customerService.Customers.Add(customer);
                _customerService.Write();

                //Set customer to currentCustomer in Customers Class
                _customerService.Customers.currentCustomer = customer;

                //Close this Form and open FormOrderDrink
                Close();// Closes this Form
                FormFactory.Get<FormOrderDrink>().Show();// Go to FormOrderDrink

            }
            else
            {
                MessageBox.Show("Customer already exist");

            }


            //_customerService.Write();              




            /*if (_customerService.Customers[customer.Phone] == null)
            {
                MessageBox.Show("YAYYYY");

            }*/

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomer(GetPhoneNumber());
            //MessageBox.Show(PhoneNumber);

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
