using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenfieldTree.Startup))]
namespace GreenfieldTree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
