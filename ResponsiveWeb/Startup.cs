using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResponsiveWeb.Startup))]
namespace ResponsiveWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
