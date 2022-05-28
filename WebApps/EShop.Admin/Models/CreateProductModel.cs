using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Admin.Models
{
    public class CreateProductModel
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
        public CreateProductDetailModel ProductDetail { get; set; }

    }
}
