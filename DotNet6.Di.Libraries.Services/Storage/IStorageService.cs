using DotNet6.Di.Libraries.Services.Product.Model;
using DotNet6.Di.Libraries.Services.ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> Products { get; }
        IList<ShoppingCartModel> ShoppingCarts { get; }
        void AddShoppingCart(Guid id);
    }
}
