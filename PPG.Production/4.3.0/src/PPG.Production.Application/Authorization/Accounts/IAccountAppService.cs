using System.Threading.Tasks;
using Abp.Application.Services;
using PPG.Production.Authorization.Accounts.Dto;

namespace PPG.Production.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
