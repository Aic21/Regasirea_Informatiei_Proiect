using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface IBlogServices
    {
		public Task AddBlogAsync(Blog blog);
		public Task DeleteBlogAsync(Blog blog);
		//public Task DeleteCategoryAsync(int id);

		public Task UpdateBlogAsync(Blog blogy);
		public IEnumerable<Blog> ListAllBlog();
		public Task<Blog> GetBlogByIdAsync(int id);
		public List<Blog> GetBlogByName(string name);
	}
}
