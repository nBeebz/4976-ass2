using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ass2.Startup))]
namespace ass2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
