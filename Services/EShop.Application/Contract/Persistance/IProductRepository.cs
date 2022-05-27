﻿using EShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Contract.Persistance
{
    public interface IProductRepository :  IAsyncRepository<Product>
    {
        Task<IEnumerable<Product>> GetProducts();

    }
}
