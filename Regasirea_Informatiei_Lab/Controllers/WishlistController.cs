using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;
using System.Linq;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IProductService productService;
        private readonly Wishlist _whislistCart;

        public WishlistController(IProductService _productService, Wishlist wishlistCart)
        {
            productService = _productService;
            _whislistCart = wishlistCart;
        }


        [Authorize(Roles = "User")]

        public ViewResult Index()
        {
            _whislistCart.test = _whislistCart.GetWishlistItems();

            var shoppingCartViewModel = new WishlistCartViewModel
            {
                Wishlist = _whislistCart
            };

            return View(shoppingCartViewModel);
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult AddToWishlist(int productId)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);
            if (selectedProduct != null)
            {
                _whislistCart.AddToWishlist(selectedProduct);
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult RemoveFromWishlist(int productId)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);

            if (selectedProduct != null)
            {
                _whislistCart.RemoveFromWishlist(selectedProduct);
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult ClearWishlist()
        {
            _whislistCart.ClearWishlist();
            return RedirectToAction("Index");
        }

    }
}
