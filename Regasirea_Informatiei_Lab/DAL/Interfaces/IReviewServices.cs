
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regasirea_Informatiei_Lab.DAL.Interfaces
{
    public interface IReviewServices
    {
		public Task AddReviewAsync(Review review);
		public Task DeleteReviewAsync(Review review);
		//public Task DeleteCategoryAsync(int id);

		public Task UpdateReviewAsync(Review review);
		public IEnumerable<Review> ListAllReview();
		public Task<Review> GetReviewByIdAsync(int id);
	}
}
