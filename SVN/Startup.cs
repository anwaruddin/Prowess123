using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVN.Startup))]
namespace SVN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
