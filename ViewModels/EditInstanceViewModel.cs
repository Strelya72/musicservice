using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.ViewModels
{
    public class EditInstanceViewModel
    {

        public IEnumerable<MusicInstance> MusicInstances { get; set; }
        public EditInstance EditInstanceObj { get; set; }

    }
}
