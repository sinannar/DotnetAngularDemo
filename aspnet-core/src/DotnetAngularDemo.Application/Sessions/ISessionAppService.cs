using System.Threading.Tasks;
using Abp.Application.Services;
using DotnetAngularDemo.Sessions.Dto;

namespace DotnetAngularDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
