using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Presentation.Controllers
{
    public class ClienteController : Controller
    {

	    private readonly IClienteAppService _clienteAppService;

	    public ClienteController(IClienteAppService clienteAppService)
	    {
		    _clienteAppService = clienteAppService;
	    }


	    // GET: Cliente
        public ActionResult Index()
        {
            return View(_clienteAppService.ObterTodos());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_clienteAppService.ObterPorId(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(ClienteViewModel obj)
        {

	        if (ModelState.IsValid)
	        {
		        _clienteAppService.Adicionar(obj);
		        return RedirectToAction("Index");
	        }
	        return View(obj);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
			return View(_clienteAppService.ObterPorId(id));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, ClienteViewModel obj)
        {
			if (ModelState.IsValid)
			{
		        _clienteAppService.Atualizar(obj);
		        return RedirectToAction("Index");
	        }
	        return View(obj);

		}

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
			return View(_clienteAppService.ObterPorId(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
			_clienteAppService.Remover(id);

	        return RedirectToAction("Index");
        }
    }
}
