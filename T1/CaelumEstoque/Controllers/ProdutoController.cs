﻿using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var produtoDAO = new ProdutosDAO();
            IList<Produto> produtos = produtoDAO.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}