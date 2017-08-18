using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using CodeMobile3.Models;
using Newtonsoft.Json.Linq;

namespace CodeMobile3.ViewModels
{
    public class CustomerListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CustomerListViewModel()
        {
            //_customers = Helpers.DbHelper.Current.GetCustomerAll();
            //Task.Run(() => GetData());
        }

        public async Task GetData()
        {
            var customerTable = Helpers.Services.MobileServiceClient.GetTable<Customer>();
            Customers = await customerTable.ToListAsync();
        }

        public async Task GetDataManual()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://codemobile3.azurewebsites.net/tables/customer");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                Customers = JArray.Parse(json).ToObject<List<Customer>>();
                //var customer = JObject.Parse(json).ToObject<Customer>();
            }
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








