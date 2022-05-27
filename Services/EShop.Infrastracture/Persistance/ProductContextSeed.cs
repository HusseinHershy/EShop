using EShop.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Infrastracture.Persistance
{
    public static class ProductContextSeed
    {
        public static async Task InitializeAsync(ProductContext productContext)
        {
            if (!productContext.Products.Any())
            {
                productContext.Products.AddRange(GetPreconfiguredProduct());
                await productContext.SaveChangesAsync();
            }

        }

        private static IEnumerable<Product> GetPreconfiguredProduct()
        {
            return new List<Product>
            {
                new Product() { Name = "PC", CategoryName = "Elec", Color ="Green", Description = "test",  CreatedBy = "Herchi", CreatedDate = DateTime.Now ,
                    ProdutPriceDetails = new ProductDetail(){
                    Price = 100,
                     ActualCost = 90
                }}, 
                new Product() {Name = "Laptop", CategoryName = "Elecc",Color ="Yellow",Description = "Test01",CreatedBy = "HHerchi", CreatedDate = DateTime.Now ,
                ProdutPriceDetails = new ProductDetail(){
                    Price = 100,
                     ActualCost = 90
                }}
            };
        }
    }
}