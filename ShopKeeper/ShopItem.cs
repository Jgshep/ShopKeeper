using System.ComponentModel.DataAnnotations;

namespace ShopKeeper.Class
{
    public class ShopItem
    {
        [Key]
        public string Name { get; set; }
        public double Price { get; set; }
        public static void Create(string itemName, double itemPrice)
        {
            var item = new ShopItem();
            item.Name = itemName;
            item.Price = itemPrice;
            GlobalVariables.Items.Add(item);
        }
    }
}
