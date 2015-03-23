using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardSharkWebApp.Startup))]
namespace CardSharkWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
