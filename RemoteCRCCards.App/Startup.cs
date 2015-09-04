using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemoteCRCCards.App.Startup))]
namespace RemoteCRCCards.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
