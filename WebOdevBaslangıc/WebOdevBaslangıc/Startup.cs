using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebOdevBaslangıc.Startup))]
namespace WebOdevBaslangıc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
