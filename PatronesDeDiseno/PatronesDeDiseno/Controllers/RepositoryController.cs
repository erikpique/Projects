using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatronesDeDiseno.Controllers
{
    public class RepositoryController : Controller
    {
        // GET: Repository
        public ActionResult Repository()
        {
            return View();
        }

        public ActionResult Detalles()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(Repository());
        }
    }
}