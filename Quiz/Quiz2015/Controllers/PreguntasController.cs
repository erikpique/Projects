using System.Web.Mvc;

namespace Quiz2015.Controllers
{
    public class PreguntasController : Controller
    {
        // GET: Preguntas
        public ActionResult Index()
        { 
            ViewBag.Message     = "Listado de Preguntas:";
            ViewBag.Preguntas   = "<ul><li>Listado Preguntas</li></ul>";

            return View();
        }
    }
}