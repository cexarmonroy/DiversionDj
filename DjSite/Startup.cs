using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DjSite.Startup))]
namespace DjSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
