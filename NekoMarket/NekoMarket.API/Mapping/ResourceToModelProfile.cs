using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NekoMarket.API.Resources;
using NekoMarket.API.Domain.Models;


namespace NekoMarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
