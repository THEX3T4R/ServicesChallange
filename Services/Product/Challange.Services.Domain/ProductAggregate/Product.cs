using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Challange.Services.Domain.ProductAggregate
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string ProdDesc { get; set; }
        [MaxLength(15)]
        public string Sku { get; set; }
        [MaxLength(15)]
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        [MaxLength(100)]
        public string PictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(100)]
        public string CreatedByUserId { get; set; }
    }
}
