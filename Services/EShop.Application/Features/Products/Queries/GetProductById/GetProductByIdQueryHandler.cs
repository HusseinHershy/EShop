using AutoMapper;
using EShop.Application.Contract.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EShop.Application.Features.Products.Queries.GetProductsList
{
  public  class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductVM>
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IUnitOfWork iUnitOfWork, IMapper mapper)
        {
            _iUnitOfWork = iUnitOfWork ?? throw new ArgumentNullException(nameof(iUnitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<ProductVM> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var productList = await _iUnitOfWork.ProductRepository.GetProductById(request.ProductId);
            return _mapper.Map<ProductVM>(productList);


        }
    }
}
