using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sdcd001.Startup))]
namespace sdcd001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
