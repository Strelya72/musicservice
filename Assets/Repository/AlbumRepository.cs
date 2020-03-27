using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.Assets.Repository
{
    public class AlbumRepository : IAlbums
    {

        private readonly DBContent _dBContent;

        public AlbumRepository(DBContent dBContent)
        {
            _dBContent = dBContent;
        }
        public Album GetAlbumById(int idAlbum)
        {
            return _dBContent.Albums.FirstOrDefault(p => p.Id == idAlbum);
        }

        public IEnumerable<Album> GetAlbumList()
        {
            return _dBContent.Albums;
        }
    }
}
