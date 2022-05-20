using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;
using Regasirea_Informatiei_Lab.ViewModels;
using System.Security.Claims;
using Stripe;

namespace Regasirea_Informatiei_Lab.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly DBContext context;
        private readonly UserManager<User> _userManager;


        public OrderController(IOrderService orderRepository, ShoppingCart shoppingCart, DBContext _context, UserManager<User> userManager)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            context = _context;
            _userManager = userManager;
        }
        [Authorize(Roles = "User")]

        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> List()
        {
            return View(await context.Orders.ToListAsync());
        }
        [Authorize(Roles = "User")]

        public IActionResult ListOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            return View(context.OrderDetails.Where(c => c.UserID.Contains(userId)).ToList());

        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await context.Orders.FindAsync(id);

            await _orderRepository.Delete(order);

            return RedirectToAction("List", "order");
        }


        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult Checkout(string stripeToken,Models.Order order)
        {
            StripeConfiguration.ApiKey = "sk_test_51KxrJpAx2jxQPuhdkXkvVMm7ssUc8EjvXt932n8uKKhKQTCxmS6PRfP6uvcOBFLjjKySKTgh4SlyXf9cKGB6ruE200KsMqI8rM";

            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty");
            }

            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
                order.UserId = userId;
                _orderRepository.CreateOrder(order);

                var options = new ChargeCreateOptions
                {
                    Amount = (long?)order.OrderTotal*100,
                    Customer = order.LastName,
                    Currency = "RON",
                    Source = stripeToken
                };
                var service = new ChargeService();
                var charge = service.Create(options);


                var model = new ChangeViewModel();
                model.ChargeId = charge.Id;

                _shoppingCart.ClearCart();
                return View("CheckoutComplete", model);
            }

            return View(order);
        }

        [Authorize(Roles = "User")]

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order. Enjoy your products";
            return View();
        }

    }
}
