using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
	    private readonly IProdutoAppService _produtoAppService;

	    public ProdutoController(IProdutoAppService produtoAppService)
	    {
		    _produtoAppService = produtoAppService;
	    }

        // GET: Produto
        public ActionResult Index()
        {
			return View(_produtoAppService.ObterTodos());
        }

	    // GET: Operadora/Cadastro
	    public ActionResult Cadastro()
	    {
		    return View();
	    }

	    // GET: Operadora/Create
	    public PartialViewResult Create()
	    {
		    return PartialView("Create", new ProdutoViewModel());
	    }

		// GET: Produto/Edit/[Guid]
		public ActionResult Edit(Guid id)
	    {
			return View(_produtoAppService.ObterPorId(id));
	    }

		// POST: Produto/Edit/[Guid]
		[HttpPost]
		public ActionResult Edit(ProdutoViewModel obj)
	    {
		    if (ModelState.IsValid)
		    {
				_produtoAppService.Atualizar(obj);
				return RedirectToAction("Index");
		    }
		    return View(obj);
		}


	    // GET: Produto/Delete/[Guid]
	    public ActionResult Delete(Guid id)
		{
		    return PartialView(_produtoAppService.ObterPorId(id));
	    }
	}
}