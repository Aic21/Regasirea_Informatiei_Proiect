using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.Services
{
	public class BlogServices : IBlogServices
	{
		private readonly IGenericRepository<Blog> blogRepo;

		public BlogServices(IGenericRepository<Blog> _blogRepo)
		{
			blogRepo = _blogRepo;
		}

		public async Task AddBlogAsync(Blog blog)
		{
			await blogRepo.Insert(blog);
		}


		public async Task DeleteBlogAsync(Blog blog)
		{
			await blogRepo.Delete(blog);
		}
		/*
		public async Task DeleteCategoryAsync(int id)
		{
			await categorieRepo.DeleteById(id);
		}
		*/
		public async Task<Blog> GetBlogByIdAsync(int id)
		{
			return await blogRepo.GetById(id);
		}

		public IEnumerable<Blog> ListAllBlog()
		{
			return blogRepo.GetAll();
		}

		public async Task UpdateBlogAsync(Blog blog)
		{
			await blogRepo.Update(blog);
		}

		public List<Blog> GetBlogByName(string name)
		{
			return blogRepo.GetByCondition(o => o.BlogName.Equals(name));
		}
	}
}
