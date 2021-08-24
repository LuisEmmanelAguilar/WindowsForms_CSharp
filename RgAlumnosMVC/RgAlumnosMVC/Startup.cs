using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RgAlumnosMVC.Startup))]
namespace RgAlumnosMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
