using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesPrep.Backend.Startup))]
namespace SalesPrep.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
