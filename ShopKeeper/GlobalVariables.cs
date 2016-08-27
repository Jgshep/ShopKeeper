using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeeper
{
    public static class GlobalVariables
    {
        public static List<ShopKeeper.Class.ShopItem> Items { get; set; } = new List<ShopKeeper.Class.ShopItem>();
    }
}

