using System;
using CodeMobile3.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeMobile3.Api.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
    }
}
