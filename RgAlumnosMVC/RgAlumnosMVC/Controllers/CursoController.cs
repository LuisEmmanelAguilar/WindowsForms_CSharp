using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RgAlumnosMVC.DAL;
using RgAlumnosMVC.Models;

namespace RgAlumnosMVC.Controllers
{
    [Authorize]
    public class CursoController : Controller
    {
        private TgAlumnosContext db = new TgAlumnosContext();

        // GET: Curso
        public ActionResult Index()
        {
            return View(db.Curso.ToList());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Curso.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,Descripcion,Precio")] Curso curso)
        {
           
            if (ModelState.IsValid)
            {
               // db.Curso.Add(curso);
               // db.SaveChanges(); ---------------------> Se remueve porque ya no sera por EF

                //Se instancia el objeto Curso del cliente de Servicio CursoServiceClient (Service Reference)
                CursoServiceClient.Curso nuevoCurso = new CursoServiceClient.Curso();
                nuevoCurso.Nombre = curso.Nombre;
                nuevoCurso.Descripcion = curso.Descripcion;
                nuevoCurso.Precio = curso.Precio;

                // Se instancia el objeto CursosServiceSoapClient quien sera quien realice la peticion al servicio web
                CursoServiceClient.CursoServiceSoapClient cursoServiceSopaClient = new CursoServiceClient.CursoServiceSoapClient();
                // Se invoca la operacion/metodo GuardarCurso del servicio web
                cursoServiceSopaClient.GuardarCurso(nuevoCurso);
               

               
                return RedirectToAction("Index");
            }

            return View(curso);
           
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Curso.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Curso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,Descripcion,Precio")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(curso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = db.Curso.Find(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Curso curso = db.Curso.Find(id);
            db.Curso.Remove(curso);
            db.SaveChanges();
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
