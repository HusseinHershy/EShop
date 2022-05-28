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

        [HttpPost(Name = "CreateProduct")]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var Project = await _mediator.Send(command);
            return Ok(Project);
        }

        [HttpGet(Name = "GetProducts")]
        [ProducesResponseType(typeof(List<ProductVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<ProductVM>>> GetProducts()
        {
            var query = new GetProductsListQuery();
            var Products = await _mediator.Send(query);
            return Ok(Products);
        }

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
