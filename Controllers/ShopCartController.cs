using Microsoft.AspNetCore.Mvc;
using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using MusicService.ViewModels;
using System.Linq;

namespace MusicService.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IInstances _musicInstanceRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IInstances musicInstanceRepository, ShopCart shopCart)
        {
            _musicInstanceRepository = musicInstanceRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.ShopItemsList = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            obj.SumPrice = 0;
            foreach (ShopCartItem cartItem in items)
            {
                obj.SumPrice += cartItem.instance.Price;
            }

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int itemId)
        {
            var item = _musicInstanceRepository
                .GetInstanceList()
                .FirstOrDefault(i => i.Id == itemId);

            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int itemId)
        {
            var item = _musicInstanceRepository
                .GetInstanceList()
                .FirstOrDefault(i => i.Id == itemId);

            if (item != null)
            {
                _shopCart.RemoveFromCart(item);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveAll()
        {
            _shopCart.RemoveAll();

            return RedirectToAction("Index", "Home");
        }
    }
}
