using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MACS.Startup))]
namespace MACS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
