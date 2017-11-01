using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A6LP2.Startup))]
namespace A6LP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
