using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class RegisterViewModel
    {
		public string Id { get; set; }
		[Required]
		[DataType(DataType.Text)]
		public string FirstName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string LastName { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		[DataType(DataType.Upload)]
		public IFormFile ProfilePhoto { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Text)]
		public string Address { get; set; }

		[DataType(DataType.Text)]
		public string County { get; set; }

		[DataType(DataType.Text)]
		public string Country { get; set; }

		[DataType(DataType.Text)]
		public string PostalCode { get; set; }
	}
}
