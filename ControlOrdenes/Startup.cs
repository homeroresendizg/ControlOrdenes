using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlOrdenes.Startup))]
namespace ControlOrdenes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
