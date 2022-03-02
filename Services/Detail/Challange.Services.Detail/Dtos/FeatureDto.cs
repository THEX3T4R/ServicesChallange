using System;

namespace Challange.Services.Detail.Dtos
{
    public class FeatureDto
    {
        public string QueryId { get; set; }
        public string ProdId { get; set; }
        public string Size { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Color { get; set; }
        public string Disk { get; set; }
        public string Ram { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
