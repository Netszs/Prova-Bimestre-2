using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [HttpGet, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoModel produtoModel = db.produtos.Find(id);
            if (produtoModel == null) 
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdutoModel produtoModel = db.produtos.Find(id);
            if (produtoModel == null)
            {
                return HttpNotFound();
            }
            db.produtos.Remove(produtoModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}