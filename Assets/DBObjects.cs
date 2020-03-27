using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicService.Assets
{
    public class DBObjects
    {

        private static Dictionary<string, Album> _albums;

        public static void Initial(DBContent dbContent)
        {

            if (!dbContent.Albums.Any())
            {
                dbContent.Albums.AddRange(GetAlbums().Select(c => c.Value));
            }


            if (!dbContent.MusicInstances.Any())
            {
                dbContent.MusicInstances.AddRange(GetMusicInstances());
            }

            dbContent.SaveChanges();
        }

        public static Dictionary<string, Album> GetAlbums()
        {
            if (_albums == null)
            {
                var listAlbums = new Album[] {
                    new Album
                    {
                        Title = "Test_1",
                        Price = 10,
                        Rating = 5,
                        ImageUrl = "/img/nure.png"
                    },
                    new Album
                    {
                        Title = "Test_2",
                        Price = 10,
                        Rating = 5,
                        ImageUrl = "/img/go-a.png"
                    },
                    new Album
                    {
                        Title = "Test_3",
                        Price = 10,
                        Rating = 5,
                        ImageUrl = "/img/jerry-heil.png"
                    }
                };

                _albums = new Dictionary<string, Album>();
                foreach (Album item in listAlbums)
                {
                    _albums.Add(item.Title, item);
                }
            }

            return _albums;
        }

        public static List<MusicInstance> GetMusicInstances()
        {
            List<MusicInstance> instanceList = new List<MusicInstance>();

            MusicInstance musicInstance1 = new MusicInstance
            {
                Title = "Instance_1",
                Price = 1,
                AlbumID = 0,
                ImageUrl = "/img/nure.png"
            };
            MusicInstance musicInstance2 = new MusicInstance
            {
                Title = "Instance_2",
                Price = 2,
                AlbumID = 0,
                ImageUrl = "/img/nure.png"
            };
            MusicInstance musicInstance3 = new MusicInstance
            {
                Title = "Instance_3",
                Price = 3,
                AlbumID = 1,
                ImageUrl = "/img/go-a.png"
            };
            MusicInstance musicInstance4 = new MusicInstance
            {
                Title = "Instance_4",
                Price = 4,
                AlbumID = 1,
                ImageUrl = "/img/go-a.png"
            };
            MusicInstance musicInstance5 = new MusicInstance
            {
                Title = "Instance_5",
                Price = 5,
                AlbumID = 1,
                ImageUrl = "/img/go-a.png"
            };
            MusicInstance musicInstance6 = new MusicInstance
            {
                Title = "Instance_6",
                Price = 6,
                AlbumID = 1,
                ImageUrl = "/img/jerry-heil.png"
            };

            instanceList.Add(musicInstance1);
            instanceList.Add(musicInstance2);
            instanceList.Add(musicInstance3);
            instanceList.Add(musicInstance4);
            instanceList.Add(musicInstance5);
            instanceList.Add(musicInstance6);

            return instanceList;
        }
    }
}