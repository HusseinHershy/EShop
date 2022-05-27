using EShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    /// <summary>
    /// Class Product
    /// </summary>
    public class Product : EntityBase
    {
        /// <summary>
        /// Unique Identifier Product
        /// </summary>
        [Key]
        public long Id { get; set; }
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
        /// Navigation Property Product Price Details
        /// </summary>
        public virtual ProductDetail ProdutPriceDetails { get; set; }

    }
}
