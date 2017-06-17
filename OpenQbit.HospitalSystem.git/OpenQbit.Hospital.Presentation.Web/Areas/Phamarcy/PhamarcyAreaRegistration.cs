using System.Web.Mvc;

namespace OpenQbit.Hospital.Presentation.Web.Areas.Phamarcy
{
    public class PhamarcyAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Phamarcy";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Phamarcy_default",
                "Phamarcy/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}