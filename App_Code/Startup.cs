using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo_Practice.Startup))]
namespace Repo_Practice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
