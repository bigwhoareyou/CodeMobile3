using System;
using System.Collections.Generic;
using System.ComponentModel;
using CodeMobile3.Models;

namespace CodeMobile3.ViewModels
{
    public class CustomerListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CustomerListViewModel()
        {
            _customers = Helpers.DbHelper.Current.GetCustomerAll();
        }

        public List<Customer> _customers;
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Customers"));
            }
        }
    }
}








