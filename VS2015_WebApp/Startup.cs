using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VS2015_WebApp.Startup))]
namespace VS2015_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
