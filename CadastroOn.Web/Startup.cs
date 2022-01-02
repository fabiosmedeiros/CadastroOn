using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CadastroOn.Web.Startup))]
namespace CadastroOn.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
