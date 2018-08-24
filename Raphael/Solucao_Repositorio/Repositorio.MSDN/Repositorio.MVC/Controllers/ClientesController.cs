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
using Repositorio.DAL.Repositorios;

namespace Repositorio.MVC.Controllers
{
    public class ClientesController : Controller
    {
        // Troca o contexto
        // private BancoContexto db = new BancoContexto();
        private readonly ClienteRepositorio repCli = new ClienteRepositorio();

        // GET: Clientes
        public ActionResult Index()
        {
            // return View(db.Clientes.ToList());
            return View(repCli.GetAll().ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = repCli.Find(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteID,Nome,CNPJ,Endereco,Telefone,Ativo")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                // db.Clientes.Add(cliente);
                repCli.Adicionar(cliente);

                // db.SaveChanges();
                repCli.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = repCli.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteID,Nome,CNPJ,Endereco,Telefone,Ativo")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(cliente).State = EntityState.Modified;
                repCli.Atualizar(cliente);

                // db.SaveChanges();
                repCli.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = repCli.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Cliente cliente = db.Clientes.Find(id);
            Cliente cliente = repCli.Find(id);

            // db.Clientes.Remove(cliente);
            repCli.Excluir(c => c == cliente);

            // db.SaveChanges();
            repCli.SalvarTodos();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            // if (disposing)
            // {
            // db.Dispose();
            // }
            repCli.Dispose();
            base.Dispose(disposing);
        }
    }
}
