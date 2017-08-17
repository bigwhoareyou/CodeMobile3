using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();

            nextButton.Clicked += NextButton_Clicked;
            newButton.Clicked += NewButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage2());
        }

        void NewButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Info", "New Button Click!", "OK");
        }
    }
}
