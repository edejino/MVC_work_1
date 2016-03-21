using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_work_1.Startup))]
namespace MVC_work_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
