using AutoMapper;
using Entities.DataTransferObjects.LaptopBrand;
using Entities.Models;
using System;
using Entities.DataTransferObjects.LaptopConfigurationItem;

namespace SimpleComputerShopAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LaptopBrand, LaptopBrandDto>()
                .ForMember(a => a.Cost, opt => opt.MapFrom(b => Convert.ToDecimal(b.Cost) / 100));

            CreateMap<LaptopConfigurationItem, LaptopConfigurationItemDto>();
        }
    }
}