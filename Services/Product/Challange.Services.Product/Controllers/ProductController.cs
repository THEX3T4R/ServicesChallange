using Challange.Services.Application.Commands;
using Challange.Services.Application.Queries;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Challange.Services.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        private readonly IMediator _mediator;
        private readonly ISharedIdentityService _sharedIdentityService;

        public ProductController(IMediator mediator, ISharedIdentityService sharedIdentityService)
        {
            _mediator = mediator;
            _sharedIdentityService = sharedIdentityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAll()
        {
            var response = await _mediator.Send(new GetProducutsQuery() { });
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand createProductCommand)
        {
            createProductCommand.CreatedUserById = "56465";
            var response = await _mediator.Send(createProductCommand);
            return CreateActionResultInstance(response);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand updateProductCommand)
        {
            var response = await _mediator.Send(updateProductCommand);
            return CreateActionResultInstance(response);
        }
    }
}
