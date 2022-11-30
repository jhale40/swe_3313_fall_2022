﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Context;
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
using static System.Windows.Forms.LinkLabel;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private IAppSettings _appSettings;
        private ICustomerService _customerService;
        private IDrinkMenuService _drinkMenuService;
        private Button? currentButton = null;
        private Drink? currentDrink;
        private bool drinkSelected = false;
        private bool customizationSelected = false;

        //private Customer currentCustomer;


        public FormOrderDrink(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            
        }

        private void FormOrderDrink_Load(object sender, EventArgs e)
        {

            SetTitleToCustomer();
            PopulateCheckBox();

             






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




        private void PopulateCheckBox()
        {

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[0];
            currentDrink = drink;

                for (var index = 0; index < currentDrink.CustomizationList.Count; index++)
            {

                var customization = currentDrink.CustomizationList[index];
                checkedListBox.Items.Add(customization.ToString());

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



        // When Customizations are selected in the CheckListBox, they will be sent to the OrderList box 
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                customizationSelected = true;
                listBox.Items.Add(checkedListBox.SelectedItem);
            }
            else
            {
                customizationSelected = false;

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

            var drinkMenuList = _drinkMenuService.DrinkMenuList;
            var drink = drinkMenuList[0];
            currentDrink = drink;

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
                // Test to see what drink is selected
                //MessageBox.Show(currentDrink.ToString());

                // If customizations are selected add them to Drink.CustomizationList 
                //set a boolean in customizations
                if (customizationSelected)
                {
                    MessageBox.Show(checkedListBox.SelectedItem.ToString());
                    CoffeeContext.CurrentOrder.DrinkList.Drink.CustomizationList.Add(checkedListBox.SelectedItem);
                }

                // Adds Drink to static class Coffee context CurrentOrder
                CoffeeContext.CurrentOrder.DrinkList.Add(currentDrink);


            }else {
                MessageBox.Show("SELECT A DRINK");

            }

            //also need to clear checklistbox and unhighlight drink button
            //Might be a seperate matter but Order list box should print order details. If not
            //then write a method to print drinks to Orderlist box
            drinkSelected=false;

        }
    }
}
