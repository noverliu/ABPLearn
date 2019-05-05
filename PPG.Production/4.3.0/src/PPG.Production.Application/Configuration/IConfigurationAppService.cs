using System.Threading.Tasks;
using Abp.Application.Services;
using PPG.Production.Configuration.Dto;

namespace PPG.Production.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}