using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6.Di.Libraries.Services.Product.Model
{
    public class ProductModel
    {
        /// <summary>
        /// Unique identifier of the product.
        /// </summary>
        public string Sku {  get; }
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Constructs a new product.
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public ProductModel(string sku, string name, decimal price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }
    }
}
