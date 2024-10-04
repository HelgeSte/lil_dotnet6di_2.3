using DotNet6.Di.Libraries.Services.Product.Model;
using DotNet6.Di.Libraries.Services.ShoppingCart.Model;
using DotNet6.Di.Libraries.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IStorageService _storageService;

        // overrding di container
        private Guid? Id {  get; set; }
        public ShoppingCartService(IStorageService storageService)
        {
            _storageService = storageService;
        }


        void IShoppingCartService.AddProduct(ProductModel product, int quantity)
        {
            throw new NotImplementedException();
        }

        int IShoppingCartService.Count()
        {
            throw new NotImplementedException();
        }

        ShoppingCartModel IShoppingCartService.Get()
        {
            throw new NotImplementedException();
        }

        void IShoppingCartService.SetId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
