using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ConnectingThruMusicWebApp.Areas.Identity.IdentityHostingStartup))]
namespace ConnectingThruMusicWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}