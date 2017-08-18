using System;
using System.Collections.Generic;
using CodeMobile3.ViewModels;
using Xamarin.Forms;

namespace CodeMobile3
{
    public partial class CustomerListPage : ContentPage
    {
        public CustomerListPage()
        {
            InitializeComponent();

            customerList.Refreshing += CustomerList_Refreshing;

            GetData();
        }

        async void GetData()
        {
            var vm = BindingContext as CustomerListViewModel;
            customerList.IsRefreshing = true;
            //await vm.GetData();
            await vm.GetDataManual();
			customerList.IsRefreshing = false;
        }

        void CustomerList_Refreshing(object sender, EventArgs e)
        {
            GetData();
        }

    }
}
