using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQbit.Hospital.Presentation.Web.Startup))]
namespace OpenQbit.Hospital.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
