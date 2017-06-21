using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Presentation.Controllers
{
    public class OperadoraController : Controller
    {
		private readonly IOperadoraAppService _operadoraAppService;

	    public OperadoraController(IOperadoraAppService operadoraAppService)
	    {
		    _operadoraAppService = operadoraAppService;
	    }

        public ActionResult Index()
        {
            return View(_operadoraAppService.ObterTodos());
        }

	    // GET: Operadora/Cadastro
	    public ActionResult Cadastro()
	    {
		    return View();
	    }

	    // POST: Operadora/Cadastro
		[HttpPost]
	    public ActionResult Cadastro(OperadoraViewModel obj)
	    {
			if (ModelState.IsValid)
		    {
			    _operadoraAppService.Adicionar(obj);
			    return RedirectToAction("Index");
		    }
		    return View(obj);
		}


	}
}
