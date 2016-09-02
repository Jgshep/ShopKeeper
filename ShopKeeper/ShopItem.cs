using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopKeeper.Class
{
    public class ShopItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        [Key]
        public int ID { get; set; }
        public static void Create(string itemName, double itemPrice)
        {
            var item = new ShopItem();
            item.Name = itemName;
            item.Price = itemPrice;
            GlobalVariables.Items.Add(item);
        }
    }
}
