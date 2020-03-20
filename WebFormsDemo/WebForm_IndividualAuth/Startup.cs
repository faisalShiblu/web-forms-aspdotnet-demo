using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_IndividualAuth.Startup))]
namespace WebForm_IndividualAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
