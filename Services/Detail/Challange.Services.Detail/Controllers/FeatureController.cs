using Challange.Services.Detail.Services;
using FreeCourse.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Challange.Services.Detail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : CustomBaseController
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _featureService.GetAllAsync();
            return CreateActionResultInstance(response);
        }
    }
}
