namespace EShop.Admin.Models
{
    /// <summary>
    /// Product Details View Model
    /// </summary>
    public class ProductDetailModel
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