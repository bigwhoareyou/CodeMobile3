using System;
using System.Collections.Generic;
using CodeMobile3.Models;

namespace CodeMobile3.ViewModels
{
    public class CustomerListViewModel2
    {
        public List<Customer2> Customers { get; set; }
        public List<Gender> Genders { get; set; }

        public CustomerListViewModel2()
        {
            Genders = new List<Gender>();
            Genders.Add(new Gender{
                Id = 1,
                Name = "Male"
            });

			Genders.Add(new Gender
			{
				Id = 2,
				Name = "Female"
			});

            Customers = new List<Customer2>();
            Customers.Add(new Customer2{
                Name = "Bond",
                Gender = Genders[0]
            });

			Customers.Add(new Customer2
			{
				Name = "Yoda",
				Gender = Genders[1]
			});
        }
    }
}
