using EShop.Application.Features.Products.Commands.CreateProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using System.Threading.Tasks;
using System.Net;
using EShop.Application.Features.Products;
using EShop.Application.Features.Products.Queries.GetProductsList;

namespace EShop.API.Controllers
{
    [Route("api/V1/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Create Product
        /// </summary>
        /// <param name="command">Create Product Command</param>
        /// <returns>Product</returns>
        [HttpPost(Name = "CreateProduct")]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var Product = await _mediator.Send(command);
            return Ok(Product);
        }

        /// <summary>
        /// Get Products List
        /// </summary>
        /// <returns>List Of Products</returns>
        [HttpGet(Name = "GetProducts")]
        [ProducesResponseType(typeof(List<ProductVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<ProductVM>>> GetProducts()
        {
            var query = new GetProductsListQuery();
            var Products = await _mediator.Send(query);
            return Ok(Products);
        }

        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="ProductId">Product Unique Identifier</param>
        /// <returns>Product</returns>
        [HttpGet("{ProductId}", Name = "GetProductById")]
        [ProducesResponseType(typeof(ProductVM), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ProductVM>> GetProductById(long ProductId)
        {
            var query = new GetProductByIdQuery(ProductId);
            var Product = await _mediator.Send(query);
            return Ok(Product);
        }


    }
}
