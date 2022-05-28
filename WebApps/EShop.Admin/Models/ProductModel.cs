using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Admin.Models
{
    public class ProductModel
    {
        /// <summary>
        /// Unique Identifier Product
        /// </summary>
        public long ProductId { get; set; }
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

        public ProductDetailModel ProdutPriceDetails { get; set; }
    }
}
