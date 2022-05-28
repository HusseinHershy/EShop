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
    public class ProductDetailVM
    {

        /// <summary>
        /// Product Details Unique Identifier
        /// </summary>
        public long productDetailId { get; set; }
        /// <summary>
        /// Foreign Key Product
        /// </summary>
        public long productId { get; set; }
        /// <summary>
        /// Product Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Product Price
        /// </summary>
        public decimal ActualCost { get; set; }



    }
}
