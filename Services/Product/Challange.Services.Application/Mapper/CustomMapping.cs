using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Challange.Services.Application.Mapper
{
    internal class CustomMapping:Profile
    {
        public CustomMapping()
        {
            CreateMap< Domain.ProductAggregate.Product,Dtos.ProductDto>().ReverseMap();
            CreateMap< Domain.ProductAggregate.Product,Dtos.CreateProductDto>().ReverseMap();
            CreateMap< Domain.ProductAggregate.Product,Dtos.UpdateProductDto>().ReverseMap();
        }
    }
}
