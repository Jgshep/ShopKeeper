using System.Data.Entity;
using ShopKeeper.Class;

namespace ShopKeeper.DataModel
{
    public class ShopItemContext : DbContext
    {
        public DbSet<ShopItem> Items { get; set; }

    }
}
