using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using xAlmoxarifado.Models;

namespace xAlmoxarifado.Controllers
{
    public class ClasseController : Controller
    {
        private xalmoxarifadocopiaEntities1 db = new xalmoxarifadocopiaEntities1();

        // GET: Classe
        public ActionResult Index()
        {
            return View(db.dadosAlmoxarifado.ToList());
        }

        // GET: Classe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadosAlmoxarifado dadosAlmoxarifado = db.dadosAlmoxarifado.Find(id);
            if (dadosAlmoxarifado == null)
            {
                return HttpNotFound();
            }
            return View(dadosAlmoxarifado);
        }

        // GET: Classe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classe/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CLAS,ID_SUB_GRU,NOME_CLA")] dadosAlmoxarifado dadosAlmoxarifado)
        {
            if (ModelState.IsValid)
            {
                db.dadosAlmoxarifado.Add(dadosAlmoxarifado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dadosAlmoxarifado);
        }

        // GET: Classe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadosAlmoxarifado dadosAlmoxarifado = db.dadosAlmoxarifado.Find(id);
            if (dadosAlmoxarifado == null)
            {
                return HttpNotFound();
            }
            return View(dadosAlmoxarifado);
        }

        // POST: Classe/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CLAS,ID_SUB_GRU,NOME_CLA")] dadosAlmoxarifado dadosAlmoxarifado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dadosAlmoxarifado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dadosAlmoxarifado);
        }

        // GET: Classe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dadosAlmoxarifado dadosAlmoxarifado = db.dadosAlmoxarifado.Find(id);
            if (dadosAlmoxarifado == null)
            {
                return HttpNotFound();
            }
            return View(dadosAlmoxarifado);
        }

        // POST: Classe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dadosAlmoxarifado dadosAlmoxarifado = db.dadosAlmoxarifado.Find(id);
            db.dadosAlmoxarifado.Remove(dadosAlmoxarifado);
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
