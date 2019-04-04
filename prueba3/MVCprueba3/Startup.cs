using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCprueba3.Startup))]
namespace MVCprueba3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
