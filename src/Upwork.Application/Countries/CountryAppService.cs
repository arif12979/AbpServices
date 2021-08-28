using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.Countries.Dto;
using Upwork.States;
using Upwork.States.Dto;

namespace Upwork.Countries
{
    public class CountryAppService : UpworkAppServiceBase, ICountryAppService
    {
        private readonly IRepository<Country> _countryRepository;

        public CountryAppService(IRepository<Country> countryRepository) 
        {
            _countryRepository = countryRepository;
        }

        public async Task  Create(CreateCountryInputDto countryInputDto)
        {
            var mapper = ObjectMapper.Map<Country>(countryInputDto);
            await _countryRepository.InsertAsync(mapper);
        }

        public async Task Delete(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }

        public async Task<List<CountryListOutputDto>> GetAll()
        {
            var countries =  _countryRepository.GetAll();
            return ObjectMapper.Map<List<CountryListOutputDto>>(countries);             
    }

        public async Task<CreateCountryInputDto> GetById(int id)
        {
            var country = _countryRepository.Get(id);
            return ObjectMapper.Map<CreateCountryInputDto>(country);
        }

        public async Task Update(CreateCountryInputDto countryInputDto)
        {
            var mapper = ObjectMapper.Map<Country>(countryInputDto);
            await _countryRepository.UpdateAsync(mapper);
        }
    }
}
