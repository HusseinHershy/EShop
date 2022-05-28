using EShop.Admin.Extensions;
using EShop.Admin.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EShop.Admin.Services
{
    /// <summary>
    /// Product Service 
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client, ILogger<ProductService> logger)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>List of Products</returns>
        public async Task<IEnumerable<ProductModel>> GetProduct()
        {
            var response = await _client.GetAsync($"https://localhost:5004/v1/GetProducts");
            return await response.ReadContentAs<List<ProductModel>>();
        }
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product</returns>
        public async Task<ProductModel> GetProduct(long id)
        {
            var response = await _client.GetAsync($"https://localhost:5004/v1/Product/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="model">Create Product VM</param>
        /// <returns>Product</returns>
        public async Task<ProductModel> CreateProduct(CreateProductModel model)
        {
            var response = await _client.PostAsJson($"https://localhost:5004/v1/CreateProduct", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProductModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }

    }
}
