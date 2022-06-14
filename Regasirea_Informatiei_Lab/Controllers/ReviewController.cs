using Microsoft.AspNetCore.Mvc;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;
using System.Security.Claims;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewServices reviewRepo;
        private readonly IProductService productRepo;

        public ReviewController(IReviewServices _reviewRepo, IProductService _productRepo)
        {
            reviewRepo = _reviewRepo;
            productRepo = _productRepo;
        }

        public IActionResult Create(int productId, CreateReviewViewModel model)
        {
            var product = productRepo.GetProductByIdAsync(productId);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            Review review = new Review();
            review.ReviewMessage = model.ReviewMessage;
            review.User.Id = userId;

            reviewRepo.AddReviewAsync(review);
            return RedirectToAction("ListProducts" ,"Product");
        }
    }
}
