using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eLeave.Startup))]
namespace eLeave
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
