using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            nextButton.Clicked += NextButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page2());

        }

    }
}
