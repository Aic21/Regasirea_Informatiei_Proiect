using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface IContactService
    {
		public Task AddContactAsync(Contact contact);
		public Task DeleteContactAsync(Contact contact);
		//public Task DeleteCategoryAsync(int id);

		public Task UpdateContactAsync(Contact contact);
		public IEnumerable<Contact> ListAllContact();
		public Task<Contact> GetContactByIdAsync(int id);
	}
}
