using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineshop.Startup))]
namespace onlineshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}