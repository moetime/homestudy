using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home_Study.Startup))]
namespace Home_Study
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
