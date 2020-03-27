using Microsoft.EntityFrameworkCore;
using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.Assets.Repository
{
    public class MusicInstanceRepository : IInstances
    {

        private readonly DBContent _dBContent;

        public MusicInstanceRepository(DBContent dBContent) {
            _dBContent = dBContent;
        }
        public MusicInstance GetInstanceById(int idInstance)
        {
            return _dBContent.MusicInstances.FirstOrDefault(p => p.Id == idInstance);
        }

        public IEnumerable<MusicInstance> GetInstanceList()
        {
            return _dBContent.MusicInstances.AsEnumerable();
        }
    }
}
