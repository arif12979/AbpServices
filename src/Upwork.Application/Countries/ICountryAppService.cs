using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.Countries.Dto;

namespace Upwork.Countries
{
    public interface ICountryAppService : IApplicationService 
        // IAsyncCrudAppService<CountryInputDto, int, List<CountryListOutputDto>>
    {
        //EntityDto input
        Task<List<CountryListOutputDto>> GetAll();
        Task<CreateCountryInputDto> GetById(int id);
        Task Create(CreateCountryInputDto countryInputDto); 
        Task Update(CreateCountryInputDto countryInputDto);
        Task Delete(int id);
    }
}
