using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pluralsight_Gighub.Startup))]
namespace Pluralsight_Gighub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
