using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;

namespace Regasirea_Informatiei_Lab.Services
{
	public class ContactService : IContactService
	{
		private readonly IGenericRepository<Contact> contactRepo;

		public ContactService(IGenericRepository<Contact> _contactRepo)
		{
			contactRepo = _contactRepo;
		}

		public async Task AddContactAsync(Contact contact)
		{
			await contactRepo.Insert(contact);
		}


		public async Task DeleteContactAsync(Contact contact)
		{
			await contactRepo.Delete(contact);
		}
		/*
		public async Task DeleteCategoryAsync(int id)
		{
			await categorieRepo.DeleteById(id);
		}
		*/
		public async Task<Contact> GetContactByIdAsync(int id)
		{
			return await contactRepo.GetById(id);
		}

		public IEnumerable<Contact> ListAllContact()
		{
			return contactRepo.GetAll();
		}

		public async Task UpdateContactAsync(Contact contact)
		{
			await contactRepo.Update(contact);
		}

	}
}
