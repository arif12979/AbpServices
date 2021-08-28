using Abp.Application.Services;
using Upwork.MultiTenancy.Dto;

namespace Upwork.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

