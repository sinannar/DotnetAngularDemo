using Microsoft.AspNetCore.Antiforgery;
using DotnetAngularDemo.Controllers;

namespace DotnetAngularDemo.Web.Host.Controllers
{
    public class AntiForgeryController : DotnetAngularDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
