using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoCine_Grupo3.Startup))]
namespace ProyectoCine_Grupo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
