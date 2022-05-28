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
  public  class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductVM>>
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IUnitOfWork iUnitOfWork, IMapper mapper)
        {
            _iUnitOfWork = iUnitOfWork ?? throw new ArgumentNullException(nameof(iUnitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<List<ProductVM>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {

            var productList = await _iUnitOfWork.ProductRepository.GetProducts();
            return _mapper.Map<List<ProductVM>>(productList);


        }
    }
}
