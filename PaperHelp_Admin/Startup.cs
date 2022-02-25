using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaperHelp_Admin.Startup))]
namespace PaperHelp_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
