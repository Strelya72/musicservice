using Microsoft.AspNetCore.Mvc;
using MusicService.Assets;
using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using MusicService.ViewModels;
using System;
using System.Linq;

namespace MusicService.Controllers
{
    public class EditInstanceController : Controller
    {
        private readonly IInstances _instances;
        private DBContent _dbContent;

        public EditInstanceController(IInstances instances, DBContent dbContent)
        {
            _instances = instances;
            _dbContent = dbContent;
        }

        public ViewResult Index()
        {
            var obj = new EditInstanceViewModel
            {
                MusicInstances = _instances.GetInstanceList(),
                EditInstanceObj = new EditInstance { }
            };

            return View(obj);
        }

        public IActionResult UpdateInstance(EditInstanceViewModel editInstance)
        {
            Console.WriteLine(editInstance.EditInstanceObj.Id);
            Console.WriteLine(editInstance.EditInstanceObj.Title);
            Console.WriteLine(editInstance.EditInstanceObj.Price);

            MusicInstance instance = _dbContent.MusicInstances
                .FirstOrDefault(i => i.Id == editInstance.EditInstanceObj.Id);

            instance.Title = editInstance.EditInstanceObj.Title;
            instance.Price = Convert.ToUInt16(editInstance.EditInstanceObj.Price);

            _dbContent.MusicInstances.Update(instance);
            _dbContent.SaveChanges();

            return Redirect("Index");
        }
    }
}
