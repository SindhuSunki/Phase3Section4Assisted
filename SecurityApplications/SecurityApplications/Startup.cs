using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityApplications.Startup))]
namespace SecurityApplications
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
