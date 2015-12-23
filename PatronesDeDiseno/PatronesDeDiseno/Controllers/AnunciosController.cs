using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using RepositoryPattern.Model;
using RepositoryPattern.Repository;

namespace PatronesDeDiseno.Controllers
{
    public class AnunciosController : Controller
    {
        private EntitiesDB db = new EntitiesDB();

        Repository _repository = new RepositoryPattern.Repository.Repository();

        // GET: Anuncios
        public ActionResult Index()
        {
            return View(_repository.Get().ToList());
        }

        // GET: Anuncios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = _repository.Get(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }

        // GET: Anuncios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anuncios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Anuncio,Autor,Email,Tipo")] Anuncios anuncios)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(anuncios);
                
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anuncios);
        }

        // GET: Anuncios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = _repository.Get(id); //db.Anuncios1.Find(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }

        // POST: Anuncios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Anuncio,Autor,Email,Tipo")] Anuncios anuncios)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(anuncios);
                //db.Entry(anuncios).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anuncios);
        }

        // GET: Anuncios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = _repository.Get(id);//db.Anuncios1.Find(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anuncios anuncios = _repository.Get(id); // db.Anuncios1.Find(id);
            //db.Anuncios1.Remove(anuncios);
            //db.SaveChanges();
            _repository.Remove(anuncios);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
