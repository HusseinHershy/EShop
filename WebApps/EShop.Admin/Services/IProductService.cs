using EShop.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Admin.Services
{
    /// <summary>
    ///  Product Service Contract
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>List of Products</returns>
        Task<IEnumerable<ProductModel>> GetProduct();
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product</returns>
        Task<ProductModel> GetProduct(long id);
        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="model">Create Product VM</param>
        /// <returns>Product</returns>
        Task<ProductModel> CreateProduct(CreateProductModel model);
    }
}
