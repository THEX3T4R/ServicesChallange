using AutoMapper;

namespace Challange.Services.Detail.Dtos
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Models.Feature, Dtos.FeatureDto>().ReverseMap();

        }
    }
}
