using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Album> Albums { get; set; }

    }
}
