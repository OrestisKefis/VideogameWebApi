using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeirdStreamer.Startup))]
namespace WeirdStreamer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
