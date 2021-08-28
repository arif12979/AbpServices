using System.Threading.Tasks;
using Abp.Application.Services;
using Upwork.Sessions.Dto;

namespace Upwork.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
