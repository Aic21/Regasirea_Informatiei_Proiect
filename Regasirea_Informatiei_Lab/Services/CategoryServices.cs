using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Services
{
    public class CategoryServices:ICategoryServices
    {
		private readonly IGenericRepository<Category> categorieRepo;

		public CategoryServices(IGenericRepository<Category> _categorieRepo)
		{
			categorieRepo = _categorieRepo;
		}

		public async Task AddCategoryAsync(Category category)
		{
			await categorieRepo.Insert(category);
		}


		public async Task DeleteCategoryAsync(Category category)
		{
			await categorieRepo.Delete(category);
		}
		/*
		public async Task DeleteCategoryAsync(int id)
		{
			await categorieRepo.DeleteById(id);
		}
		*/
		public async Task<Category> GetCategoryByIdAsync(int id)
		{
			return await categorieRepo.GetById(id);
		}

		public IEnumerable<Category> ListAllCategory()
		{
			return categorieRepo.GetAll();
		}

		public async Task UpdateCategoryAsync(Category category)
		{
			await categorieRepo.Update(category);
		}

		public List<Category> GetCategoryByName(string name)
		{
			return categorieRepo.GetByCondition(o => o.CategoryName.Equals(name));
		}
	}
}
