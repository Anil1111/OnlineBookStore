using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cover2Cover.Startup))]
namespace Cover2Cover
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
