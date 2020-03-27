using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.Assets.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public MusicInstance instance { get; set; }

        public string ShopCartId { get; set; }
    }
}
