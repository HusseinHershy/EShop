using EShop.Application.Contract.Persistance;
using EShop.Infrastracture.Persistance;
using EShop.Infrastracture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastracture.UOW
{
 
        public class UnitOfWork : IUnitOfWork
        {
            private readonly ProductContext _context;


            public UnitOfWork(ProductContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
                ProductRepository = new ProductRepository(_context);
                
            }

            public IProductRepository ProductRepository { get; private set; }
        

            public int Complete()
            {
                return _context.SaveChanges();
            }
            public Task<int> CompleteAsync()
            {
                return _context.SaveChangesAsync();
            }
            public void Dispose()
            {
                _context.Dispose();
            }
        }
}
