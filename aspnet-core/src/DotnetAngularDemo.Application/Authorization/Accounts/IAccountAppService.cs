using System.Threading.Tasks;
using Abp.Application.Services;
using DotnetAngularDemo.Authorization.Accounts.Dto;

namespace DotnetAngularDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
