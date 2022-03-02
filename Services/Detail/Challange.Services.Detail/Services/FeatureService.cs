using AutoMapper;
using Challange.Services.Catelog.Settings;
using Challange.Shared.Dtos;
using FreeCourse.Shared.Dtos;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challange.Services.Detail.Services
{
    public class FeatureService: IFeatureService
    {
        private readonly IMongoCollection<Models.Feature> _featureCollection;
        private readonly IMapper _mapper;

        public FeatureService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _featureCollection = database.GetCollection<Models.Feature>(databaseSettings.FeatureCollectionName);
            _mapper = mapper;
        }

        public async Task<Response<List<Dtos.FeatureDto>>> GetAllAsync()
        {
            var feature = await _featureCollection.Find(feature => true).ToListAsync();
            return Response<List<Dtos.FeatureDto>>.Success(_mapper.Map<List<Dtos.FeatureDto>>(feature), 200);
        }

        public async Task<Response<Dtos.FeatureDto>> CreateAsync(Dtos.FeatureDto featureDto)
        {
            var newFeature = _mapper.Map<Models.Feature>(featureDto);
            await _featureCollection.InsertOneAsync(newFeature);
            return Response<Dtos.FeatureDto>.Success(204);
        }
    }
}
