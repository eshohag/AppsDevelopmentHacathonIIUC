using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppsDevelopmentHacathonIIUC.Startup))]
namespace AppsDevelopmentHacathonIIUC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
