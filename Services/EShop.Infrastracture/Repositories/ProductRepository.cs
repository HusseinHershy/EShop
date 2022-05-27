using EShop.Application.Contract.Persistance;
using EShop.Domain.Entities;
using EShop.Infrastracture.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastracture.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ProductContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _dbContext.Products
                              .Include("ProdutPriceDetails")
                               .ToListAsync();
            return products;
        }
    }
}
