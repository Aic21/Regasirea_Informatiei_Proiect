using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;

namespace Regasirea_Informatiei_Lab.Services
{
    public class SubcategoryService: ISubcategoryServices
	{ 

		private readonly IGenericRepository<Subcategorie> subcategoriRepo;

	public SubcategoryService(IGenericRepository<Subcategorie> _subcategoriRepo)
	{
		subcategoriRepo = _subcategoriRepo;
	}

	public async Task AddSubCategoryAsync(Subcategorie subcategorie)
	{
		await subcategoriRepo.Insert(subcategorie);
	}


	public async Task DeleteSubCategoryAsync(Subcategorie subcategorie)
	{
		await subcategoriRepo.Delete(subcategorie);
	}
	/*
	public async Task DeleteCategoryAsync(int id)
	{
		await categorieRepo.DeleteById(id);
	}
	*/
	public async Task<Subcategorie> GetSubCategoryByIdAsync(int id)
	{
		return await subcategoriRepo.GetById(id);
	}

	public IEnumerable<Subcategorie> ListAllSubCategory()
	{
		return subcategoriRepo.GetAll(c => c.Categories);
	}

	public async Task UpdateSubCategoryAsync(Subcategorie subcategorie)
	{
		await subcategoriRepo.Update(subcategorie);
	}

	public List<Subcategorie> GetSubCategoryByName(string name)
	{
		return subcategoriRepo.GetByCondition(o => o.Nume.Equals(name));
	}
    }
}
