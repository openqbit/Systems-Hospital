using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQbit.Hospital.Presentation.Web.Startup))]
namespace OpenQbit.Hospital.Presentation.Web
{
    //comit
    public partial class Startup
    {
        //dd
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
