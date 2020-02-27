using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoyalPrint.Startup))]
namespace RoyalPrint
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
