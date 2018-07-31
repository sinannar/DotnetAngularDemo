using Abp.AutoMapper;
using DotnetAngularDemo.Authentication.External;

namespace DotnetAngularDemo.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
