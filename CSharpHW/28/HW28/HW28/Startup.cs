using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW28.Startup))]
namespace HW28
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
