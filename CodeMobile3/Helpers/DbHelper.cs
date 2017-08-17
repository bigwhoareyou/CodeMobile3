using System;
using System.Collections.Generic;
using CodeMobile3.Models;
using SQLite;
using System.Linq;

namespace CodeMobile3.Helpers
{
    public class DbHelper
    {
        public static DbHelper Current { get; set; } = new DbHelper();

        SQLiteConnection db;
        
        private DbHelper()
        {
            db = new SQLiteConnection(Helpers.Settings.Path);
            db.CreateTable<Customer>();
        }

        public List<Customer> GetCustomerAll()
        {
            return db.Table<Customer>().ToList();
        }

        public int AddCustomer(Customer customer)
        {
            return db.Insert(customer);
        }

        public int UpdateCustomer(Customer customer)
        {
            return db.Update(customer);
        }

        public int DeleteCustomer(Customer customer)
        {
            return db.Delete(customer);
        }
    }
}
