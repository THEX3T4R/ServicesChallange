using AutoMapper;
using Challange.Services.Application.Commands;
using Challange.Services.Product.Infrastructure;
using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challange.Services.Application.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<NoContent>>
    {
        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(ProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response<NoContent>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var prod = new Domain.ProductAggregate.Product()
            {
                CategoryId = request.CategoryId,
                ProdDesc = request.Desc,
                Name = request.Name,
                PictureUrl = request.PictureUrl,
                Sku = request.Sku,
                Price = request.Price,
                CreatedByUserId = request.CreatedUserById,
                CreatedDate = DateTime.Now,
            };
            await _context.Products.AddAsync(prod);
            await _context.SaveChangesAsync();
            return Response<NoContent>.Success(204);
        }
    }
}
