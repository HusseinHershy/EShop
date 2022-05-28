using EShop.Admin.Models;
using EShop.Admin.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EShop.Admin.Controllers
{
    [Route("api/V1/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _iProductService;

        public ProductController(IProductService productService)
        {
            _iProductService = productService ?? throw new ArgumentNullException(nameof(productService));

        }

        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="command">Create Product Command</param>
        /// <returns>Product</returns>
        [HttpPost(Name = "CreateProduct")]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreateProduct([FromBody] CreateProductModel command)
        {
            var Product = await _iProductService.CreateProduct(command);
            return Ok(Product);
        }

        /// <summary>
        /// Get Products List
        /// </summary>
        /// <returns>List Of Products</returns>
        [HttpGet(Name = "GetProducts")]
        [ProducesResponseType(typeof(List<ProductModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<ProductModel>>> GetProducts()
        {
            
            var Products = await _iProductService.GetProduct();
            return Ok(Products);
        }

        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="ProductId">Product Unique Identifier</param>
        /// <returns>Product</returns>
        [HttpGet("{ProductId}", Name = "GetProductById")]
        [ProducesResponseType(typeof(ProductModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductModel>> GetProductById(long ProductId)
        {
            var Product = await _iProductService.GetProduct(ProductId);
            return Ok(Product);
        }
    }
}
