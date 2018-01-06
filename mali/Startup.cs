using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mali.Startup))]
namespace mali
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
