using DotNet6.Di.Libraries.Services.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.ShoppingCart.Model
{
    public class ShoppingCartItemModel
    {
        public ProductModel Product { get; }
        public decimal Price { get; protected set; }
        public int Quantity { get; protected set; }

        public ShoppingCartItemModel(ProductModel product, int quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        public void UpdateQuantity(ProductModel product, int quantity) {
            Price = product.Price;
            Quantity = quantity;
        }

    }
}
