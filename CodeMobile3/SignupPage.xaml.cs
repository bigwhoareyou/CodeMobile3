﻿using System;
using System.Collections.Generic;
using CodeMobile3.Models;
using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();

            saveButton.Clicked += SaveButton_Clicked;
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("Signup", "Are you sure?", "OK", "Cancel");

            if (isOk)
            {
                var customer = BindingContext as Customer;
                int id = Helpers.DbHelper.Current.AddCustomer(customer);

                await DisplayAlert("Signup", $"Signup Success your ID #{id}", "OK");

                var np = Parent as NavigationPage;
                var mp = np.Parent as MasterDetailPage;
                mp.Detail = new NavigationPage(new CustomerListPage());
            }
        }
    }
}