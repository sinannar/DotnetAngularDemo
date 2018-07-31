using System.Threading.Tasks;
using DotnetAngularDemo.Configuration.Dto;

namespace DotnetAngularDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
