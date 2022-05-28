using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Features.Products
{
    /// <summary>
    /// Class Product
    /// </summary>
    public class ProductVM
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

        public  ProductDetailVM ProdutPriceDetails { get; set; }

    }
}
