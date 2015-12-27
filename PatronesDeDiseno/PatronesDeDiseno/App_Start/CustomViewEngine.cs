using System.Linq;
using System.Web.Mvc;

namespace PatronesDeDiseno.App_Start
{
    public class CustomViewEngine : RazorViewEngine
    {
        private string[] _views = new string[] {
            "~/Views/{1}/AbstractFactory/{0}.cshtml",
            "~/Views/{1}/Repository/{0}.cshtml",
            "~/Views/{1}/Singleton/{0}.cshtml"
        };

        public CustomViewEngine()
        {
            base.ViewLocationFormats = base.ViewLocationFormats.Union(_views).ToArray();
            base.PartialViewLocationFormats = base.PartialViewLocationFormats.Union(_views).ToArray();
            base.MasterLocationFormats = base.MasterLocationFormats.Union(_views).ToArray();
        }
    }
}