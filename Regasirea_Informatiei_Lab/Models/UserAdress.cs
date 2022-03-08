using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Models
{
    public class UserAdress
    {
		[Key]
		public int AddressID { get; set; }
		public string Address { get; set; }
		public string PostalCode { get; set; }
		public string County { get; set; }
		public string Country { get; set; }
	}
}
