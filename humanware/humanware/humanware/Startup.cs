using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(humanware.Startup))]
namespace humanware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
