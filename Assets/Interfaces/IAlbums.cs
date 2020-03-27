using MusicService.Assets.Models;
using System.Collections.Generic;

namespace MusicService.Assets.Interfaces
{
    public interface IAlbums
    {
        IEnumerable<Album> GetAlbumList();

        Album GetAlbumById(int idAlbum);
    }
}
