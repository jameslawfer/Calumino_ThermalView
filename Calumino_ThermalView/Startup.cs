using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calumino_ThermalView.Startup))]
namespace Calumino_ThermalView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
