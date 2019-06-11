using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson5_200406015.Startup))]
namespace Lesson5_200406015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
