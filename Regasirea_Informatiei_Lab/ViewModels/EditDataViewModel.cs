using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.ViewModels
{
    public class EditDataViewModel
    {
		public string Id { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string FirstName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string LastName { get; set; }

		public string PhoneNumber { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }

		[DataType(DataType.Upload)]
		public IFormFile Photo { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public string Postalcode { get; set; }


	}
}
