using System;
using System.Collections.Generic;
using System.Text;

namespace Challange.Services.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProdDesc { get; set; }
        public string Sku { get; set; }
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
    }
}
