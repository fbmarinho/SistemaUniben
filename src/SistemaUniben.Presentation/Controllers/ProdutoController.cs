using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities.Listas;

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
		    ViewBag.listas = new Listas();
			return PartialView(new ProdutoViewModel());
	    }

	    // POST: Produto/Edit/[Guid]
	    [HttpPost]
	    public ActionResult Create(ProdutoViewModel obj)
	    {
		    if (ModelState.IsValid)
		    {
			    _produtoAppService.Adicionar(obj);
			    return RedirectToAction("Index");
		    }
		    return View(obj);
	    }



		// GET: Produto/Edit/[Guid]
		public ActionResult Edit(Guid id)
		{
			ViewBag.listas = new Listas();
			return PartialView(_produtoAppService.ObterPorId(id));
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

	    [HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
	    public ActionResult DeleteConfirmed(Guid id)
	    {
			_produtoAppService.Remover(id);
			return RedirectToAction("Index");
	    }
	}
}