using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMstore.Startup))]
namespace TMstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
