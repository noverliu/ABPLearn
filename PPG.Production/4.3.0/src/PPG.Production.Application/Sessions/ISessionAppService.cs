using System.Threading.Tasks;
using Abp.Application.Services;
using PPG.Production.Sessions.Dto;

namespace PPG.Production.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
