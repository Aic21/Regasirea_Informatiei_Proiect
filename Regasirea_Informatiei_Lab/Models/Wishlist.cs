using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Regasirea_Informatiei_Lab.Models
{
    public class Wishlist
    {
        private readonly DBContext _appDbContext;
        public string WishlistCartItem { get; set; }
        public List<WishlistItem> test { get; set; }


        public Wishlist(DBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static Wishlist GetWishlist(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<DBContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new Wishlist(context) { WishlistCartItem = cartId };
        }

        public void AddToWishlist(Product product)
        {
            var shoppingCartItem = _appDbContext.WishlistCartItems.SingleOrDefault(
                s => s.Produs.ProductId == product.ProductId && s.WhishlistId == WishlistCartItem);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new WishlistItem
                {
                    WhishlistId = WishlistCartItem,
                    Produs = product
                };

                _appDbContext.WishlistCartItems.Add(shoppingCartItem);
            }
            else
            {
            }

            _appDbContext.SaveChanges();
        }
        public void RemoveFromWishlist(Product product)
        {
            var shoppingCartItem = _appDbContext.WishlistCartItems.SingleOrDefault(
                s => s.Produs.ProductId == product.ProductId && s.WhishlistId == WishlistCartItem);

            _appDbContext.WishlistCartItems.Remove(shoppingCartItem);


            _appDbContext.SaveChanges();
        }

        public List<WishlistItem> GetWishlistItems()
        {
            return test ?? (test = _appDbContext.WishlistCartItems.Where(c => c.WhishlistId == WishlistCartItem)
                .Include(s => s.Produs)
                .ToList());
        }

        public void ClearWishlist()
        {
            var cartItems = _appDbContext.WishlistCartItems.Where(c => c.WhishlistId == WishlistCartItem);

            _appDbContext.WishlistCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

    }
}
