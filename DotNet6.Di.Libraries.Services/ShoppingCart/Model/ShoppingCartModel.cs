using DotNet6.Di.Libraries.Services.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.ShoppingCart.Model
{
    public class ShoppingCartModel
    {
        public Guid Id { get; }
        public IList<ShoppingCartItemModel> Items { get; }

        public ShoppingCartModel(Guid id)
        {
            Id = id;
            Items = new List<ShoppingCartItemModel>();
        }

        public void AddUpdateItem(ProductModel product, int quantity)
        {
            var item = Items.FirstOrDefault(item => item.Product == product);

            if (item == null)
            {
                // Item doesn't exist in the shopping cart, so add it.
                Items.Add(new ShoppingCartItemModel(product, quantity));
            } else
            {
                // item exists in the shopping cart, so update the quantity
            }
        }
    }
}
