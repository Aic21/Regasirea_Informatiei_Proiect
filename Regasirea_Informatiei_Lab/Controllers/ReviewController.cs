using Microsoft.AspNetCore.Mvc;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Linq;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ReviewController : Controller
    {
        private readonly DBContext context;
        public ReviewController(DBContext _context)
        {
            context = _context;
        }
        public IActionResult AddReviewProduct(int ProductId,int rate, string comment)
        {
            var currenUser = this.ControllerContext.HttpContext.User.Identity.Name;
            if(context.Users.FirstOrDefault(u=>u.UserName==currenUser)!=null)
            {
                Review review = new Review()
                {
                    Rate = rate,
                    ReviewMessage = comment,
                    ReviewDate = DateTime.Now,
                    Product = context.Products.FirstOrDefault(p=>p.ProductId==ProductId),
                    User = context.Users.FirstOrDefault(u=>u.UserName == currenUser)
                };
                context.Reviews.AddAsync(review);
                context.SaveChanges();
            }
            return RedirectToAction("Details", "Product", new { Id = ProductId });
        }
    }
}
