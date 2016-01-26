using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5_Aurelia.Startup))]
namespace Mvc5_Aurelia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
