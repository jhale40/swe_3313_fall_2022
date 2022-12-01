using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Context;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private ICustomerService _customerService;
        private readonly IDrinkMenuService _drinkMenuService;
        private Button? currentButton = null;
        private Drink? currentDrink;
        private bool drinkSelected = false;
        private bool customizationSelected = false;
        private readonly List<Customization> custList = new List<Customization>();
        //private readonly List<Drink> ReadOnlyDrinkList = new List<Drink>();
         
        //var customizations = _drinkMenuService.DrinkMenuList[0].CustomizationList;
        //List<Customization> custList = new List<Customization>();

        //private Customer currentCustomer;


        public FormOrderDrink(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            var customizations = _drinkMenuService.DrinkMenuList[0].CustomizationList;

            //currentDrink = null
            CoffeeContext.CurrentOrder.DrinkList.Add(currentDrink);


        }

        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            
            

            SetTitleToCustomer();
            PopulateCheckBox();

            //Put in a method
            var customizations = _drinkMenuService.DrinkMenuList[0].CustomizationList;

            foreach (Customization c in customizations)
            {
                custList.Add(c);
                checkedListBox.Items.Add(c.ToString());
                //var customization = customizations[c];

            }

            /*var drink = currentDrink;
            CoffeeContext.CurrentOrder = new Order()
            {
                DrinkList = new List<Drink>().Add(drink)

            };*/


            /*//var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            
            string name = "";
            decimal price = 0.0m;
            List<Customization> cList = new List<Customization>();*/
            //var drink = new Drink { CustomizationList = null};
            //currentDrink = drink;



            //var customizations = _drinkMenuService.DrinkMenuList[0].CustomizationList;

            //List<Customization> custList = new List<Customization>();







            /*//Test writing code to create Order and put Drink in it with and without customization
            ////New Order might start on CustomerListForm when Orderdrink button is selected

            var drink = _drinkMenuService.DrinkMenuList[0];
            var order = new Order() 
            { 
                TransactionDate = DateTime.Now, PaymentMethod = "Credit", Subtotal = drink.BasePrice, 
                Tax = (drink.BasePrice * _appSettings.Tax.Rate), 
                Total = ((drink.BasePrice * _appSettings.Tax.Rate) + (drink.BasePrice)) 
            };



   

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
                //_customerService.Write();
            }*/




        }// ON LOAD METHOD


        /*public Drink AddDrink()
        {
            var currentDrink = new Drink()
            {
                Name = "Coffee",
                BasePrice = 4.00M
                
            };
            return currentDrink;
        }
*/


        

        private void PopulateCheckBox()
        {

            //var drink = drinkMenuList[0];
            //currentDrink = drink;

            /*var customizations = _drinkMenuService.DrinkMenuList[0].CustomizationList;
            List<Customization> custList = new List<Customization>();*/


            foreach (Customization c in custList)
            {
                //custList.Add(c);
                checkedListBox.Items.Add(c.ToString());
                //var customization = customizations[c];

            }


            /*if (currentDrink != null)
            {
                *//*var drinkMenuList = _drinkMenuService.DrinkMenuList;
                var drink = drinkMenuList[0];
                currentDrink = drink;*//*

                for (var index = 0; index < currentDrink.CustomizationList.Count; index++)
                {

                    var customization = currentDrink.CustomizationList[index];
                    checkedListBox.Items.Add(customization.ToString());

                }

            }
            else
            {
                checkedListBox.Items.Add("Select a Drink");
            }*/


        }



        private void SetTitleToCustomer()
        {
            var customer = _customerService.Customers.currentCustomer;
            SetTitle($"Order Drink for ( {customer.FirstName} {customer.LastName} )");
        }




        // Exit button Returns to Main Screen
        private void bReturnToMain_Click(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormMain>().Show();
        }


        //Change to when Customizations are selected in the CheckListBox, they will be added to a drink customizationlist
        // When Customizations are selected in the CheckListBox, they will be sent to the OrderList box 
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //customizationSelected = false;

            if (e.NewValue == CheckState.Checked)
            {
                customizationSelected = true;
                listBox.Items.Add(checkedListBox.SelectedItem);
                //var customization = checkedListBox.SelectedItem;
                //Drink 
            }
            else
            {
                listBox.Items.Remove(checkedListBox.SelectedItem);
            }

        }


        // Highlights current Drink button selected in panelMenu
        /*Source = https://youtu.be/BtOEztT1Qzk */
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Silver;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                }
            }
        }



        // Drink Buttons
        private void bCoffee_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            //var drinkMenuList = _drinkMenuService.DrinkMenuList;
            //string c = drinkMenuList[0].Name;
            //Drink d = new Drink(drinkMenuList[0].Name, drinkMenuList[0].BasePrice);
            //currentDrink = d;*/

            //Drink d = new Drink { Name = drinkMenuList[0].Name, BasePrice = drinkMenuList[0].BasePrice };
            //currentDrink =  { Name = drinkMenuList[0].Name};

            //drinkSelected = false;
            //var drinkPrice = drinkMenuList[0].BasePrice;
            //currentDrink = { Name = drinkName, BasPrice = drinkPrice};

            

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[0];
            //drink.CustomizationList.Clear();
            currentDrink = drink;

            //var drinkTemp = drink.CustomizationList.Clear();


            //currentDrink.CustomizationList.Clear();


            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }

        private void bEspresso_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[1];
            currentDrink = drink;

            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }

        private void bIcedLatte_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[2];
            currentDrink = drink;

            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }

        private void bGreenTea_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[3];
            currentDrink = drink;

            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }

        private void b_IcedWater_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[4];
            currentDrink = drink;

            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }

        private void bLatte_Click(object sender, EventArgs e)
        {
            drinkSelected = true;
            ActivateButton(sender);

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[5];
            currentDrink = drink;

            //Testing 
            MessageBox.Show(currentDrink.ToString());
        }





        private void bAddToOrder_Click(object sender, EventArgs e)
        {
            if (drinkSelected)
            {
                //Drink? drink = currentDrink;

                // Test to see what drink is selected
                //MessageBox.Show(currentDrink.ToString());

                // If customizations are selected add them to Drink.CustomizationList 
                //set a boolean in customizations
                if (customizationSelected)
                {
                    //var custom = (Customization)checkedListBox.SelectedItem;

                    //currentDrink.CustomizationList.Add((Customization)checkedListBox.SelectedItem);
                    //drink.CustomizationList.Add(custom);

                    //var customizations = checkedListBox.SelectedItem;
                    MessageBox.Show("Custom");
                    //CoffeeContext.CurrentOrder.DrinkList.Drink.CustomizationList.Add(checkedListBox.SelectedItem);
                }

                // Adds Drink to static class Coffee context CurrentOrder
                //CoffeeContext.CurrentOrder.DrinkList.Add(drink);


                //CoffeeContext.CurrentOrder.DrinkList.Add(currentDrink);


            }
            else {
                MessageBox.Show("SELECT A DRINK");

            }

            //also need to clear checklistbox and unhighlight drink button
            //Might be a seperate matter but Order list box should print order details. If not
            //then write a method to print drinks to Orderlist box

            //drinkSelected=false;

        }
    }
}
