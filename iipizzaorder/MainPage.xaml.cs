//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 10/01/2020
//Project #: Participation 8
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iipizzaorder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Check to see if the buttons are toggled and a crust is selected,
        ///   then display alerts for each case or when an order is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrder_Clicked(object sender, EventArgs e)
        {
            // Check if one of the switches is selected
            if (SwitchCheese.IsToggled || SwitchPepperoni.IsToggled || SwitchPineapple.IsToggled)
            {
                // If the index is > -1 then there is something selected
                if (PckCrust.SelectedIndex > -1)
                {
                    // If the selected item is not equal to an empty string, we know a city was selected
                    if (LstViewCity.SelectedItem.ToString() != "")
                    {
                        // If there is a topping, a crust, and a city, we can continue

                        // Store the selected items in string variables
                        string crust = PckCrust.SelectedItem.ToString();
                        string city = LstViewCity.SelectedItem.ToString();
                        string toppings = "";

                        // Store the topping(s), use ternary operator/string concatenation to determine if something was selected
                        toppings = SwitchCheese.IsToggled ? "Cheese " :
                        toppings += SwitchPepperoni.IsToggled ? "Pepperoni " :
                        toppings += SwitchPineapple.IsToggled ? "Pineapple" : "";


                        // display a final alert if the order completely succeded
                        DisplayAlert("Pizza Order", $"{crust} crust pizza with {toppings}. Delivered to {city}", "Close");
                    }
                    else
                    {
                        // If no city was selected, display an alert
                        DisplayAlert("Invalid Input", "Please select a city", "Close");
                    }
                }
                else
                {
                    // If no crust is selected, display an alert
                    DisplayAlert("Invalid Input", "Please select a crust", "Close");
                }
            }
            else
            {
                // if no topping is selected, display an alert
                DisplayAlert("Invalid Input", "Please select at least one topping", "Close");
            }
        }
    }
}
