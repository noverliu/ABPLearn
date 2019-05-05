using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PPG.Production.Configuration.Dto;

namespace PPG.Production.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProductionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
