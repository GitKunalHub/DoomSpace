using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrowdTalk.Startup))]
namespace CrowdTalk
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
