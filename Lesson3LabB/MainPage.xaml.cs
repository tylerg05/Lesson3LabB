using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson3LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Btn_Clicked(Object sender, System.EventArgs e)
        {
            int yob = Date_Age.Date.Year;
            int age = 2021 - yob;
            int drinkingAge = 0;
            // usa
            if (Picker_Country.SelectedIndex == 0)
            {
                drinkingAge = 21;
            }
            // germany
            else if (Picker_Country.SelectedIndex == 1)
            {
                drinkingAge = 16;
            }
            // uk
            else if (Picker_Country.SelectedIndex == 2)
            {
                drinkingAge = 18;
            }
            // japan
            else
            {
                drinkingAge = 20;
            }
            if (age >= drinkingAge)
            {
                Label_Message.Text = "You are already drinking age.";
            }
            else
            {
                int yearsUntilDrink = drinkingAge - age;
                Label_Message.Text = $"You have {yearsUntilDrink} years until you can legally buy alcohol";
            }
        }

    }
}
