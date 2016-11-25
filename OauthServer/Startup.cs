using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OauthServer.Startup))]
namespace OauthServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
