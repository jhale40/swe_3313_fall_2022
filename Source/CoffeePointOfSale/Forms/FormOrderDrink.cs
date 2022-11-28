using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private ICustomerService _customerService;
        private IDrinkMenuService _drinkMenuService;
        public FormOrderDrink(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
        }

        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            var c = _customerService.Customers.currentCustomer;
            SetTitle($"Order Drink for ( {c.FirstName} {c.LastName} )");

            PopulateCheckBox();


            //Test writing code to create Order and put Drink in it with and without customization
            ////New Order might start on CustomerListForm when Orderdrink button is selected

            var drink = _drinkMenuService.DrinkMenuList[0];
            var order = new Order() 
            { 
                TransactionDate = DateTime.Now, PaymentMethod = "Credit", Subtotal = drink.BasePrice, 
                Tax = (drink.BasePrice * _appSettings.Tax.Rate), 
                Total = ((drink.BasePrice * _appSettings.Tax.Rate) + (drink.BasePrice)) 
            };
            /*Order currentOrder = new Order
            {
                DrinkList = new List<Drink>() { new Drink { BasePrice = 2.50M, Name = "Coffee" } }
            };*/




            //Test writing code to add Order to Customers.json with existing customer
            //when payment type is selected on Payment Screen

            var KenBlock = _customerService.Customers["770-987-6543"];
            KenBlock.OrderList.Add(order);
            //_customerService.Write();// Need this but Add Drink to DrinkList first, Only use Write() when valid payment
               //Have method that returns Drink(maybe customizations too) or creates Drinklist
               //Map out plan for methods to work together




            //Test adding new Customer
            var newcustomer = new Customer() { FirstName = "John", LastName = "Doe", Phone = "999-888-7777" };

            if (_customerService.Customers[newcustomer.Phone] == null)
            {
                _customerService.Customers.Add(newcustomer);
                _customerService.Write();
            }

        }

        private void PopulateCheckBox()
        {
            /*var drinkMenuList = _drinkMenuService.DrinkMenuList;
            for (var index = 0; index < drinkMenuList.Count; index++)
            {
                var drink = drinkMenuList[index];
                //List<Customization> customizations = drink.CustomizationList;
                var customization = drink.CustomizationList;
                checkedListBox.Items.Add(customization);
            }*/

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[0];
            //List<Customization> customizations = drink.CustomizationList;


            for (var index = 0; index < drink.CustomizationList.Count; index++)
            {
                var customization = drink.CustomizationList[index];
                checkedListBox.Items.Add(customization.ToString());

            }


        }




        // Exit button Returns to Main Screen
        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }



        // When Customizations are selected in the CheckListBox, they will be sent to the OrderList box 
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                listBox.Items.Add(checkedListBox.SelectedItem);
            }
            else
            {
                listBox.Items.Remove(checkedListBox.SelectedItem);
            }
        }
    }
}
