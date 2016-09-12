using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_repo_practice.Startup))]
namespace Website_repo_practice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
