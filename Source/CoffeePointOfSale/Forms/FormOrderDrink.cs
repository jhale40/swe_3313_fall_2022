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

            //Test writing code to create Order and put Drink in it with and without customization
            ////New Order might start on CustomerListForm when Orderdrink button is selected

            /*Order currentOrder = new Order
            {
                DrinkList = new List<Drink>() { new Drink { BasePrice = 2.50M, Name = "Coffee" } }
            };*/
            

            

            //Test writing code to add Order to Customers.json with existing customer
            //when payment type is selected on Payment Screen


        }

        /*private void populateCheckBox()
        {
            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            for (var index = 0; index < drinkMenuList.Count; index++)
            {
                var drink = drinkMenuList[index];
                //List<Customization> customizations = drink.CustomizationList;
                checkedListBox.Items.Add(drink);
            }
        }*/

        // Exit button Returns to Main Screen
        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }
    }
}
