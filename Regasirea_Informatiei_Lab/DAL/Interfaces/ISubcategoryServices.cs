using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.Models;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface ISubcategoryServices
    {
		public Task AddSubCategoryAsync(Subcategorie subcategorie);
		public Task DeleteSubCategoryAsync(Subcategorie subcategorie);
		//public Task DeleteCategoryAsync(int id);

		public Task UpdateSubCategoryAsync(Subcategorie subcategorie);
		public IEnumerable<Subcategorie> ListAllSubCategory();
		public Task<Subcategorie> GetSubCategoryByIdAsync(int id);
		public List<Subcategorie> GetSubCategoryByName(string name);
	}
}
