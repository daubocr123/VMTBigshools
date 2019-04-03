using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMT_BigSchools.Startup))]
namespace VMT_BigSchools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
