using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHeroInc.UI.Startup))]
namespace SuperHeroInc.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
