using AutoMapper;
using Challange.Services.Application.Dtos;
using Challange.Services.Application.Queries;
using Challange.Services.Product.Infrastructure;
using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challange.Services.Application.Handlers
{
    public class GetProducutsQueryHandler : IRequestHandler<Queries.GetProducutsQuery, Response<List<Dtos.ProductDto>>>
    {
        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;

        public GetProducutsQueryHandler(ProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Response<List<ProductDto>>> Handle(GetProducutsQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.ToListAsync();
            if (!products.Any())
                return Response<List<Dtos.ProductDto>>.Success(new List<Dtos.ProductDto>(), 200);

            var mProd =  _mapper.Map<List<Dtos.ProductDto>>(products);
            return Response<List<Dtos.ProductDto>>.Success(mProd, 200);
        }
    }
}
