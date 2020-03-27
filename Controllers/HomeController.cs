using Microsoft.AspNetCore.Mvc;
using MusicService.Assets.Interfaces;
using MusicService.ViewModels;

namespace MusicService.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlbums _albums;

        public HomeController(IAlbums albums)
        {
            _albums = albums;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Альбомы";
            ViewBag.Description = "На данной странице представлен список всех альбомов в каталоге.";

            var homeAlbums = new HomeViewModel
            {
                Albums = _albums.GetAlbumList()
            };
            return View(homeAlbums);
        }
    }
}
