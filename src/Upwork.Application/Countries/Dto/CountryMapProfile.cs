using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Upwork.Authorization.Roles;
using Upwork.Countries.Dto;
using Upwork.Countries;

namespace Upwork.Countries.Dto
{
    public class CountryMapProfile : Profile
    {
        public CountryMapProfile()
        {
            
            CreateMap<CreateCountryInputDto, Country>();

            CreateMap<Country, CountryListOutputDto>();
            
        }
    }
}
