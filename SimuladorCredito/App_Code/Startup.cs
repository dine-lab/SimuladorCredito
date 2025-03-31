using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimuladorCredito.Startup))]
namespace SimuladorCredito
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
