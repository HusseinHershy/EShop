using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{

    public class ProductDetail : EntityBase
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
        [Range(1, 1000)]
        public decimal Price { get; set; }
        /// <summary>
        /// Product Price
        /// </summary>
        [Range(1, 1000)]
        public decimal ActualCost { get; set; }

        /// <summary>
        /// Navigation Property Product
        /// </summary>
        public virtual Product Product { get; set; }

    }
}
