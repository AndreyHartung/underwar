using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Underwar.Startup))]
namespace Underwar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
