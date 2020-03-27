using Microsoft.EntityFrameworkCore;
using MusicService.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicService.Assets
{
    public class DBContent : DbContext
    {

        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {
        }

        public DbSet<MusicInstance> MusicInstances { get; set;  }
        public DbSet<Album> Albums { get; set;  }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }



    }
}
