using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DotNetDuds.Areas.Identity.IdentityHostingStartup))]
namespace DotNetDuds.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}