using Challange.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challange.Services.Detail.Services
{
    public interface IFeatureService
    {
        Task<Response<List<Dtos.FeatureDto>>> GetAllAsync();
        Task<Response<Dtos.FeatureDto>> CreateAsync(Dtos.FeatureDto featureDto);
    }
}
