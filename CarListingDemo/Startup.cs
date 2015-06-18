using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarListingDemo.Startup))]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Web.config", Watch = true)]
namespace CarListingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
