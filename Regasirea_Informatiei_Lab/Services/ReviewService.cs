using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Regasirea_Informatiei_Lab.Services
{
    public class ReviewService:IReviewServices
    {
		private readonly IGenericRepository<Review> reviewRepo;

		public ReviewService(IGenericRepository<Review> _reviewRepo)
		{
			reviewRepo = _reviewRepo;
		}

		public async Task AddReviewAsync(Review review)
		{
			await reviewRepo.Insert(review);
		}


		public async Task DeleteReviewAsync(Review review)
		{
			await reviewRepo.Delete(review);
		}
		/*
		public async Task DeleteCategoryAsync(int id)
		{
			await categorieRepo.DeleteById(id);
		}
		*/
		public async Task<Review> GetReviewByIdAsync(int id)
		{
			return await reviewRepo.GetById(id);
		}

		public IEnumerable<Review> ListAllReview()
		{
			return reviewRepo.GetAll();
		}

		public async Task UpdateReviewAsync(Review review)
		{
			await reviewRepo.Update(review);
		}


	}
}
