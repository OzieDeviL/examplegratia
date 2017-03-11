using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Examplegratia.Startup))]
namespace Examplegratia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
