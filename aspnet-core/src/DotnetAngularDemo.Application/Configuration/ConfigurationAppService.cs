using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DotnetAngularDemo.Configuration.Dto;

namespace DotnetAngularDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DotnetAngularDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
