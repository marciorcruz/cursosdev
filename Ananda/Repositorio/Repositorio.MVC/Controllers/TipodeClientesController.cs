using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repositorio.DAL.Contexto;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    public class TipodeClientesController : Controller
    {
        private BancoContexto db = new BancoContexto();

        // GET: TipodeClientes
        public ActionResult Index()
        {
            return View(db.TiposdeCliente.ToList());
        }

        // GET: TipodeClientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeCliente tipodeCliente = db.TiposdeCliente.Find(id);
            if (tipodeCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipodeCliente);
        }

        // GET: TipodeClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipodeClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipodeClienteID,Nome")] TipodeCliente tipodeCliente)
        {
            if (ModelState.IsValid)
            {
                db.TiposdeCliente.Add(tipodeCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodeCliente);
        }

        // GET: TipodeClientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeCliente tipodeCliente = db.TiposdeCliente.Find(id);
            if (tipodeCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipodeCliente);
        }

        // POST: TipodeClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipodeClienteID,Nome")] TipodeCliente tipodeCliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodeCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodeCliente);
        }

        // GET: TipodeClientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeCliente tipodeCliente = db.TiposdeCliente.Find(id);
            if (tipodeCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipodeCliente);
        }

        // POST: TipodeClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipodeCliente tipodeCliente = db.TiposdeCliente.Find(id);
            db.TiposdeCliente.Remove(tipodeCliente);
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
