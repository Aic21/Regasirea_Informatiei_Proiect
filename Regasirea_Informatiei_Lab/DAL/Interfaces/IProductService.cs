using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface IProductService
    {
		public Task AddProductAsync(Product product);
		public Task DeleteProductAsync(Product product);
		public Task UpdateProductAsync(Product product);
		public IEnumerable<Product> ListAllProduct();
		public IEnumerable<Product> ListAllProductWith();
		public Task<Product> GetProductByIdAsync(int id);
		public List<Product> GetProductByName(string name);
		public IEnumerable<Product> GetAllWhere(string nume);
	}
}
