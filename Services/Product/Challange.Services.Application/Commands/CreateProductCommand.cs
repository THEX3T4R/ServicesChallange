using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challange.Services.Application.Commands
{
    public class CreateProductCommand:IRequest<Response<NoContent>>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Sku { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string CreatedUserById { get; set; }
    }
}
