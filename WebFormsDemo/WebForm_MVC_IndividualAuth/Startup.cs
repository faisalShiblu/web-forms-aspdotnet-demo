using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_MVC_IndividualAuth.Startup))]
namespace WebForm_MVC_IndividualAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
