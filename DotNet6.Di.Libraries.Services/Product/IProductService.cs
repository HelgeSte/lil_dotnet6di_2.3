using DotNet6.Di.Libraries.Services.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.Product
{
    public interface IProductService
    {
        /// <summary>
        /// Used for product methods.
        /// </summary>
        ProductModel Get(string sku);
    }
}
