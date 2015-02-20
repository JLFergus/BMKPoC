using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMK_API.Startup))]
namespace BMK_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
