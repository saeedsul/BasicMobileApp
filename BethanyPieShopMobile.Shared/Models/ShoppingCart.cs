using System.Collections.Generic;

namespace BethanyPieShopMobile.Shared.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            CartItems = new List<ShoppingCartItem>();
        }

        public List<ShoppingCartItem> CartItems
        {
            get;
            set;
        }
    }
}
