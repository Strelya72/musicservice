using MusicService.Assets.Interfaces;
using MusicService.Assets.Models;
using System.Collections.Generic;

namespace MusicService.Assets.Mocks
{
    public class MockInstance : IInstances
    {
        public IEnumerable<MusicInstance> GetInstanceList()
        {
            List<MusicInstance> instanceList = new List<MusicInstance>();
            /*
            MusicInstance musicInstance1 = new MusicInstance(0, "Instance_1", 1, 0);
            MusicInstance musicInstance2 = new MusicInstance(1, "Instance_2", 2, 0);
            MusicInstance musicInstance3 = new MusicInstance(2, "Instance_3", 3, 1);
            MusicInstance musicInstance4 = new MusicInstance(2, "Instance_4", 4, 1);
            MusicInstance musicInstance5 = new MusicInstance(2, "Instance_5", 5, 1);
            MusicInstance musicInstance6 = new MusicInstance(2, "Instance_6", 6, 1);
            */

            MusicInstance musicInstance1 = new MusicInstance
            {
                Id = 0,
                Title = "Instance_1",
                Price = 1,
                AlbumID = 0
            };
            MusicInstance musicInstance2 = new MusicInstance
            {
                Id = 1,
                Title = "Instance_2",
                Price = 2,
                AlbumID = 0
            };
            MusicInstance musicInstance3 = new MusicInstance
            {
                Id = 2,
                Title = "Instance_3",
                Price = 3,
                AlbumID = 1
            };
            MusicInstance musicInstance4 = new MusicInstance
            {
                Id = 3,
                Title = "Instance_4",
                Price = 4,
                AlbumID = 1
            };
            MusicInstance musicInstance5 = new MusicInstance
            {
                Id = 4,
                Title = "Instance_5",
                Price = 5,
                AlbumID = 1
            };
            MusicInstance musicInstance6 = new MusicInstance
            {
                Id = 5,
                Title = "Instance_6",
                Price = 6,
                AlbumID = 1
            };

            instanceList.Add(musicInstance1);
            instanceList.Add(musicInstance2);
            instanceList.Add(musicInstance3);
            instanceList.Add(musicInstance4);
            instanceList.Add(musicInstance5);
            instanceList.Add(musicInstance6);

            return instanceList;
        }

        public MusicInstance GetInstanceById(int idInstance)
        {
            return new MusicInstance
            {
                Id = idInstance,
                Title = "Instance_1",
                Price = 1,
                AlbumID = 0
            };
        }
    }
}