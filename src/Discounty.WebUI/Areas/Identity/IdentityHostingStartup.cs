using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Discounty.WebUI.Areas.Identity.IdentityHostingStartup))]

namespace Discounty.WebUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}