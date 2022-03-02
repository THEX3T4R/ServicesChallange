using AutoMapper;
using Challange.Services.Application.Commands;
using Challange.Services.Product.Infrastructure;
using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challange.Services.Application.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<Commands.UpdateProductCommand, Response<NoContent>>
    {
        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(ProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Response<NoContent>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var Prod = _context.Products.FirstOrDefault(x => x.Id == request.Id);
            if (Prod == null)
                return Response<NoContent>.Success(404);

            Prod.CategoryId = request.CategoryId;
            Prod.ProdDesc = request.Desc;
            Prod.Name = request.Name;
            Prod.PictureUrl = request.PictureUrl;
            Prod.Sku = request.Sku;
            Prod.Price = request.Price;
            Prod.CreatedDate = DateTime.Now;

            await _context.SaveChangesAsync();
            return Response<NoContent>.Success(204);
        }
    }
}
