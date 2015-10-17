using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mi Perfil";
            ViewBag.Autor = "J. Rafa Ramón";
            ViewBag.Picture = "";
            ViewBag.Video = "";

            return View();
        }
    }
}