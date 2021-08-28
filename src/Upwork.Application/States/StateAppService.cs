using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.Countries;
using Upwork.States.Dto;

namespace Upwork.States
{
    public class StateAppService : UpworkAppServiceBase, IStateAppService
    {
        private readonly IRepository<State> _stateRepository;
        private readonly IRepository<Country> _countryRepository;

        public StateAppService(IRepository<State> stateRepository,
            IRepository<Country> countryRepository)
        {
            _stateRepository = stateRepository;
            _countryRepository = countryRepository;
        }

        public async Task Create(CreateStateInputDto stateInputDto)
        {
            var mapper = ObjectMapper.Map<State>(stateInputDto);
            await _stateRepository.InsertAsync(mapper);
        }

        public async Task Delete(int id)
        {
            await _stateRepository.DeleteAsync(id);
        }

        public async Task<List<StateListOutputDto>> GetAll()
        {
            var statesList = (from state in _stateRepository.GetAll()
                join Country in _countryRepository.GetAll() on state.CountryId equals Country.Id
                select new StateListOutputDto
                { 
                Id= state.Id,
                 CountryId=state.CountryId,
                  CountryName=Country.Name,
                   Description=state.Description,
                    Name=state.Name                    
                }            ).ToList();
            //return ObjectMapper.Map<List<StateListOutputDto>>(states);
            return statesList;
        }

        public async Task<CreateStateInputDto> GetById(int id)
        {
            var state =  _stateRepository.Get(id);
                        //join Country in _countryRepository.GetAll() on state.CountryId equals Country.Id
                        //where state.Id == id
                        //select new CreateStateInputDto
                        //{ 
                        // Id=,
                        //  CountryId=,
                        //   Description=,
                        //    Name=,
                             
                             
                        //}
                        //);
            return ObjectMapper.Map<CreateStateInputDto>(state);
        }

        public async Task Update(CreateStateInputDto stateInputDto)
        {
            var mapper = ObjectMapper.Map<State>(stateInputDto);
            await _stateRepository.UpdateAsync(mapper);
        }
    }
}
