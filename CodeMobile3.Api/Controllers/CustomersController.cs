using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeMobile3.Api.Data;
using CodeMobile3.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeMobile3.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        MyDbContext _db;

        public CustomersController(MyDbContext db)
        {
            this._db = db;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _db.Customers.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _db.Customers.Single(c => c.Id == id);
        }

        // POST api/values
        [HttpPost]
        public Customer Post(Customer value)
        {
            _db.Add(value);
            _db.SaveChanges();
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, Customer value)
        {
            _db.Update(value);
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customer = _db.Customers.Single(c => c.Id == id);
            _db.Remove(customer);
            _db.SaveChanges();
        }
    }
}
