using EShop.Application.Features.Products.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Features.Products.Commands.CreateProduct
{
   public class CreateProductCommand : IRequest<ProductVM>
    {
      
        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product Color
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Product Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Product Category Name
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Product URL Image
        /// </summary>
        public string ImageUrl { get; set; }
   /// <summary>
   /// Product Details
   /// </summary>
        public CreateProductDetailVM ProductDetail { get; set; }


    }
}
