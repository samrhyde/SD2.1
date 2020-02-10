using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HydeMvcP1.Startup))]
namespace HydeMvcP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
