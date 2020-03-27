using MusicService.Assets.Models;
using System.Collections.Generic;

namespace MusicService.Assets.Interfaces
{
    public interface IInstances
    {
        IEnumerable<MusicInstance> GetInstanceList();

        MusicInstance GetInstanceById(int idInstance);
    }
}

