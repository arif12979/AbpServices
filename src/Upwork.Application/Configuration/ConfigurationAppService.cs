using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Upwork.Configuration.Dto;

namespace Upwork.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : UpworkAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
