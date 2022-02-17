using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingBasket
    {
        public string UserName { get; set; }
        public List<ShoppingBasketItem> Items { get; set; } = new List<ShoppingBasketItem>();

        public ShoppingBasket()
        {
        }

        public ShoppingBasket(string userName)
        {
            UserName = userName;
        }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Quantity * item.Price;
                }

                return totalPrice;
            }
        }
    }
}
