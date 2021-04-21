using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BARDSports.Startup))]
namespace BARDSports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
