using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            backButton.Clicked += BackButton_Clicked;
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
