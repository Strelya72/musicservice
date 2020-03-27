namespace MusicService.Assets.Models
{
    public class MusicInstance
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public ushort Price { set; get; }
        public int AlbumID { set; get; }

        public string ImageUrl { set; get; }
        
    }
}
