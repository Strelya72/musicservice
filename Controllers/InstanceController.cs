using Microsoft.AspNetCore.Mvc;
using MusicService.Assets.Interfaces;
using MusicService.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MusicService.Controllers
{
    public class InstanceController : Controller
    {
        private readonly IInstances _instances;
        private readonly IAlbums _albums;

        public InstanceController(IInstances instances, IAlbums albums)
        {
            _instances = instances;
            _albums = albums;
        }

        public ViewResult InstancesList(int albumId = -1)
        {
            ViewBag.Title = "Композиции";
            ViewBag.Description = "На данной странице представлен список всех песен в каталоге.";
            InstancesViewModel instancesVM = new InstancesViewModel();

            if (albumId >= 0)
            {
                ViewBag.Description = "Список песен в альбоме " + _albums.GetAlbumById(albumId).Title;
                instancesVM.AllInstances = _instances
                    .GetInstanceList()
                    .Where(i => i.AlbumID == albumId);
                instancesVM.currentAlbumId = "TODO";
            }
            else
            {
                instancesVM.AllInstances = _instances.GetInstanceList();
            }

            instancesVM.AllAlbums = _albums.GetAlbumList();

            return View(instancesVM);
        }
    }
}

