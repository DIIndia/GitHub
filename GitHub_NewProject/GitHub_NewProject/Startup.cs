using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHub_NewProject.Startup))]
namespace GitHub_NewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
