using DotNet6.Di.Libraries.Services.Product.Model;
using DotNet6.Di.Libraries.Services.ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DotNet6.Di.Libraries.Services.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> Products { get; private set; }

        public IList<ShoppingCartModel> ShoppingCarts { get; private set; }

        public StorageService()
        {
            Products = new List<ProductModel>();
            ShoppingCarts = new List<ShoppingCartModel>();

            // Store a list of all the products for the online shop.
        }

        public void AddProduct(ProductModel productModul)
        {
            if (!Products.Any(p => p.Sku == productModul.Sku))
            {
                Products.Add(productModul);
            }
        }

        public void AddShoppingCart(Guid id)
        {
                if (!ShoppingCarts.Any(sc => sc.Id == id))
                {
                    ShoppingCarts.Add(new ShoppingCartModel(id));
                }
        }
    }
}
