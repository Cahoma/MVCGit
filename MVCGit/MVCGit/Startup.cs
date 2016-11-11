using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGit.Startup))]
namespace MVCGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
