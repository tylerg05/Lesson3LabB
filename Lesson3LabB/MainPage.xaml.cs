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
            if (age >= 21)
            {
                Label_Message.Text = "You are already drinking age.";
            }
            else
            {
                int yearsUntilDrink = 21 - age;
                Label_Message.Text = $"You have {yearsUntilDrink} years until you can legally buy alcohol";
            }
        }
    }
}
