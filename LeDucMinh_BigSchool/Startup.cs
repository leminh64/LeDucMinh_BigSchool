using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeDucMinh_BigSchool.Startup))]
namespace LeDucMinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
