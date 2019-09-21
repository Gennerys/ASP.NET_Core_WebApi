using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NekoMarket.API.Resources;
using NekoMarket.API.Domain.Models;
using NekoMarket.API.Domain.Models.Queries;


namespace NekoMarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (EUnitOfMeasurement)src.UnitOfMeasurement));


            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}
