using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Upwork.Authorization.Roles;

namespace Upwork.States.Dto
{
    public class StateMapProfile : Profile
    {
        public StateMapProfile()
        {
            
            CreateMap<CreateStateInputDto, State>();

            CreateMap<State, StateListOutputDto>();
            
        }
    }
}
