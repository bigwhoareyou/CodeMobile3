using System;
using SQLite;

namespace CodeMobile3.Models
{
    [Table("Customers")]
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Telephone { get; set; }

        public string Email { get; set; }

        [Unique,NotNull]
        public string Username { get; set; }

        [NotNull]
        public string Password { get; set; }

        public string ImagePath { get; set; }
    }
}
