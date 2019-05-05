using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PPG.Production.MultiTenancy.Dto;

namespace PPG.Production.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
