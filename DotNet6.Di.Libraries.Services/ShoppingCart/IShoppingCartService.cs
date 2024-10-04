using DotNet6.Di.Libraries.Services.Product.Model;
using DotNet6.Di.Libraries.Services.ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.ShoppingCart
{
    public interface IShoppingCartService
    {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        int Count();
        void SetId(Guid id);
    }
}
