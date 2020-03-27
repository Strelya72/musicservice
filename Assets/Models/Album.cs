using System.Collections.Generic;

namespace MusicService.Assets.Models
{
    public class Album
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public ushort Price { set; get; }
        public ushort Rating { set; get; }
        public string ImageUrl { set; get; }
        
    }
}