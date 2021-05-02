using PrimeiraAplicacaoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeiraAplicacaoWeb.Controllers
{
    public class CategoriasDeProdutoController : Controller
    {
        // GET: CategoriasDeProduto
        public ActionResult Index(int? id)
        {
            ViewBag.ValorQS = id;
            return View();
        }
        [HttpPost]
        public ActionResult Index(CategotiaDeProduto categoria)
        {
            if (categoria == null)
            {
                return new HttpNotFoundResult();
            }
            return RedirectToAction("Index","Home");
        }
    }
}