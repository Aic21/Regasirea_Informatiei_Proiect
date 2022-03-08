using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface ICategoryServices
    {
		public Task AddCategoryAsync(Category category);
		public Task DeleteCategoryAsync(Category category);
		//public Task DeleteCategoryAsync(int id);

		public Task UpdateCategoryAsync(Category category);
		public IEnumerable<Category> ListAllCategory();
		public Task<Category> GetCategoryByIdAsync(int id);
		public List<Category> GetCategoryByName(string name);
	}
}
