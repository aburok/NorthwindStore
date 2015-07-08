using Microsoft.Owin;
using NorthwindStore.WebUI;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace NorthwindStore.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
