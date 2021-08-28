using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.Countries.Dto;
using Upwork.States.Dto;

namespace Upwork.States
{
    public interface IStateAppService : IApplicationService 
    {
        //EntityDto input
        Task<List<StateListOutputDto>> GetAll();
        Task<CreateStateInputDto> GetById(int id);
        Task Create(CreateStateInputDto createStateInputDto); 
        Task Update(CreateStateInputDto  createStateInputDto);
        Task Delete(int id);
    }
}
