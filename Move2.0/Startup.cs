using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Move2._0.Startup))]
namespace Move2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
