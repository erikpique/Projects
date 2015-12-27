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
            return View();
        }

        public ActionResult AbstractFactory()
        {
            return View();
        }

        public ActionResult Singleton()
        {
            return View();
        }

        public ActionResult AnunciosIndex()
        {
            return View("~/Views/Patrones/Repository/Anuncios/Index.cshtml");
        }
    }
}