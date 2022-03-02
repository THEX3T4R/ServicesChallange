using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Challange.Services.Detail.Models
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string QueryId { get; set; }
        public string ProdId { get; set; }
        public string Size { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Color { get; set; }
        public string Disk { get; set; }
        public string Ram { get; set; }
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }

    }
}
