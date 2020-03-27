using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System.Collections.Generic;

namespace MusicService.Assets.Mocks
{
    public class MockAlbum : IAlbums
    {
        public IEnumerable<Album> GetAlbumList()
        {
            List<Album> albumList = new List<Album>();

            /*
            Album album1 = new Album(0, "Test_1", 10, 5, "/img/nure.png");
            Album album2 = new Album(0, "Test_2", 10, 5, "/img/go-a.png");
            Album album3 = new Album(0, "Test_3", 10, 5, "/img/jerry-heil.png");
            */

            Album album1 = new Album
            {
                Id = 0,
                Title = "Test_1",
                Price = 10,
                Rating = 5,
                ImageUrl = "/img/nure.png"
            };
            Album album2 = new Album
            {
                Id = 1,
                Title = "Test_1",
                Price = 10,
                Rating = 5,
                ImageUrl = "/img/go-a.png"
            };
            Album album3 = new Album
            {
                Id = 2,
                Title = "Test_2",
                Price = 10,
                Rating = 5,
                ImageUrl = "/img/jerry-heil.png"
            };

            albumList.Add(album1);
            albumList.Add(album2);
            albumList.Add(album3);

            return albumList;
        }

        public Album GetAlbumById(int idAlbum)
        {
            return new Album
            {
                Id = idAlbum,
                Title = "Test_1",
                Price = 10,
                Rating = 5,
                ImageUrl = "/img/nure.png"
            };
        }
    }
}