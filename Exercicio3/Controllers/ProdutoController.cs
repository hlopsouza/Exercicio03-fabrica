using Exercicio3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio3.Controllers
{
    public class ProdutoController : Controller
    {
        private BancoEntities _context = new BancoEntities();

        [HttpGet]
        public ActionResult CadastrarProduto()
        {

            return View();
        }


        [HttpPost]
        public ActionResult CadastrarProduto(Produto p)
        {

            _context.Produtos.Add(p);
            _context.SaveChanges();
            TempData["Mensagem"] = "Sucesso! Produto cadastrado.";
            return RedirectToAction("CadastrarProduto");

        }

        [HttpGet]
        public ActionResult ListarProduto()
        {
            List<Produto> listarProdutos = _context.Produtos.ToList();
            ViewBag.listar = listarProdutos;
            return View();
        }


    }
}