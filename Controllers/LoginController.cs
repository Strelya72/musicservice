using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicService.Assets;
using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System.Linq;

namespace MusicService.Controllers
{
    public class LoginController : Controller
    {

        private DBContent _dbContent;
        public LoginController(DBContent dbContent)
        {
            _dbContent = dbContent;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("TestKey", "TestValue");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login login)
        {
            if (!string.IsNullOrEmpty(login.Email)
                && !string.IsNullOrEmpty(login.Password))
            {
                _dbContent.MusicInstances.FirstOrDefault(
                    u => u.Title== login.Email && u.Title == login.Password);
                HttpContext.Session.SetString("User", "True");

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
