using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicService.Assets.Models
{
    public class ShopCart
    {
        private readonly DBContent _dBContent;
        private static ISession session;

        public ShopCart(DBContent dBContent)
        {
            _dBContent = dBContent;
        }

        public string ShopCartId { get; set; }

        public List<ShopCartItem> ShopItemsList { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<DBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                ShopCartId = shopCartId
            };
        }

        public void AddToCart(MusicInstance instance)
        {
            string shopCartId = session.GetString("CartId");

            if (_dBContent.ShopCartItems.Where(i => i.instance.Id == instance.Id
            && i.ShopCartId == shopCartId).Any())
            {
                return;
            }
            


            _dBContent.ShopCartItems.Add(new ShopCartItem
            {
                instance = instance,
                ShopCartId = ShopCartId
            });
            ;
            _dBContent.SaveChanges();
        }

        public void RemoveFromCart(MusicInstance instance)
        {
            string shopCartId = session.GetString("CartId");

            ShopCartItem shopCartItem = _dBContent.ShopCartItems
                .FirstOrDefault(i => i.instance.Id == instance.Id
            && i.ShopCartId == shopCartId);

            _dBContent.ShopCartItems.Remove(shopCartItem);
            _dBContent.SaveChanges();
        }

        public void RemoveAll()
        {
            foreach (ShopCartItem item in GetShopItems())
            {
                RemoveFromCart(item.instance);
            }
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _dBContent.ShopCartItems
                .Where(c => c.ShopCartId == ShopCartId)
                .Include(c => c.instance)
                .ToList();
        }
    }
}
