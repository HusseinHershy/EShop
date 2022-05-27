using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EShop.Application.Contract.Persistance
{
    public interface IUnitOfWork : IDisposable
    {
       
      
        int Complete();
        Task<int> CompleteAsync();


    }
}
