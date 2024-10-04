using DotNet6.Di.Libraries.Services.Product.Model;
using DotNet6.Di.Libraries.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.Product
{
    public class ProductService : IProductService
    {
        public readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }
        
        public ProductModel Get(string sku)
        {
            return _storageService.Products.FirstOrDefault(p => p.Sku == sku);
        }
    }
}
