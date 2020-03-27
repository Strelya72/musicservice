using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.ViewModels
{
    public class InstancesViewModel
    {
        public IEnumerable<MusicInstance> AllInstances { get; set; }

        public IEnumerable<Album> AllAlbums { get; set; }

        public string currentAlbumId { get; set; }

    }
}
