using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challange.Services.Application.Queries
{
    public class GetProducutsQuery:IRequest<Response<List<Dtos.ProductDto>>>
    {
    }
}
