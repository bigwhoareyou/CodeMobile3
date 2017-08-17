using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            nextButton.Clicked += NextButton_Clicked;
            backButton.Clicked += BackButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page3());
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
