using System.Data.Entity;
using ShopKeeper.Class;

namespace ShopKeeper.DataModel
{
    public class ShopItemContext : DbContext
    {
        public ShopItemContext() : base("ShopItemConn") {}
        public DbSet<ShopItem> Items { get; set; }

    }



}
