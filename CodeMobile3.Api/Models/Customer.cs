using System;
using System.ComponentModel.DataAnnotations;

namespace CodeMobile3.Api.Models
{
	public class Customer
	{
        [Key]
		public int Id { get; set; }
        [Required]
		public string Name { get; set; }
        [MaxLength(10)]
        public string Telephone { get; set; }
		public string Email { get; set; }
        [Required]
		public string Username { get; set; }
        [Required]
		public string Password { get; set; }
		public string ImagePath { get; set; }
	}
}
