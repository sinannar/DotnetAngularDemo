using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DotnetAngularDemo.MultiTenancy.Dto;

namespace DotnetAngularDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
