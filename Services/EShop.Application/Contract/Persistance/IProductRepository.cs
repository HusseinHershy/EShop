using EShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Contract.Persistance
{
    public interface IProductRepository :  IAsyncRepository<Product>
    {
        /// <summary>
        /// Get List Of Products
        /// </summary>
        /// <returns>List of Products</returns>
        Task<IEnumerable<Product>> GetProducts();
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="productId"> Product Id</param>
        /// <returns>Product</returns>
        Task<Product> GetProductById(long productId);
    }
}
