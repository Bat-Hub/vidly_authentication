using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_authentication.Startup))]
namespace vidly_authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
