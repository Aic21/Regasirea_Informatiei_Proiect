using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;

namespace Regasirea_Informatiei_Lab.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService productService;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProductService _productService, ShoppingCart shoppingCart)
        {
            productService = _productService;
            _shoppingCart = shoppingCart;
        }
        [Authorize(Roles = "User")]

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}

