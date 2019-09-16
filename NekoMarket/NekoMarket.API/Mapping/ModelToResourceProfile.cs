using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NekoMarket.API.Domain.Models;
using NekoMarket.API.Resources;
using NekoMarket.API.Extensions;


namespace NekoMarket.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
