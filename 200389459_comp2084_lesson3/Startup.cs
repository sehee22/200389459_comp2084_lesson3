using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200389459_comp2084_lesson3.Startup))]
namespace _200389459_comp2084_lesson3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
