using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testwebapp.Startup))]
namespace Testwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
