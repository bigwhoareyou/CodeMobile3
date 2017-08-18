using System;
using Newtonsoft.Json;
using SQLite;

namespace CodeMobile3.Models
{
    [Table("Customers")]
    public class Customer
    {
        [JsonProperty("id")]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonProperty("name")]
        [NotNull]
        public string Name { get; set; }

        [JsonProperty("telephone")]
        [MaxLength(10)]
        public string Telephone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

		[JsonProperty("username")]
        [Unique,NotNull]
        public string Username { get; set; }

        [JsonProperty("password")]
        [NotNull]
        public string Password { get; set; }

		[JsonProperty("imagePath")]
        public string ImagePath { get; set; }
    }
}
