using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Features.Products.ViewModels
{
    /// <summary>
    /// Create Product Detail View Model Class
    /// </summary>
    public class CreateProductDetailVM
    {
        public CreateProductDetailVM(decimal price, decimal actualCost)
        {
            this.Price = price;
            this.ActualCost = actualCost;
        }
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
