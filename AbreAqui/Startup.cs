using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AbreAqui.Startup))]
namespace AbreAqui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
