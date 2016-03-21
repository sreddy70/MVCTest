using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTestProject.Startup))]
namespace MVCTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
