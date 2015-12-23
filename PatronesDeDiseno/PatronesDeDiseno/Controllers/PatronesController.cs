using System.Web.Mvc;

namespace PatronesDeDiseno.Controllers
{
    public class PatronesController : Controller
    {
        public ActionResult Patrones()
        {
            return View();
        }

        public ActionResult Repository()
        {
            return View("~/Views/Patrones/Repository/Repository.cshtml");
        }

        public ActionResult AbstractFactory()
        {
            return View("~/Views/Patrones/AbstractFactory/AbstractFactory.cshtml");
        }

        public ActionResult Singleton()
        {
            return View("~/Views/Patrones/Singleton/Singleton.cshtml");
        }

        public ActionResult AnunciosIndex()
        {
            return View("~/Views/Patrones/Repository/Anuncios/Index.cshtml");
        }
    }
}