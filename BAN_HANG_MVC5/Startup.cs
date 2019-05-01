using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BAN_HANG_MVC5.Startup))]
namespace BAN_HANG_MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
