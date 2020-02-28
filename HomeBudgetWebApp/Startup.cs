using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeBudgetWebApp.Startup))]
namespace HomeBudgetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
