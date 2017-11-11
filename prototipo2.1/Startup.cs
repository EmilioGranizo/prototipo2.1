using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prototipo2._1.Startup))]
namespace prototipo2._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
