using System.Web.Mvc;

namespace Test.Controllers
{
    public class PreguntasController : Controller
    {
        // GET: Preguntas
        public ActionResult Index()
        { 
            ViewBag.Message = "Listado de Preguntas:";

            return View();
        }
    }
}