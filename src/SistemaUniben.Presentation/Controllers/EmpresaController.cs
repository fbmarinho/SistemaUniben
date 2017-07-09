using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Presentation.Controllers
{
    public class EmpresaController : Controller
    {

	    private readonly IEmpresaAppService _empresaAppService;

	    public EmpresaController(IEmpresaAppService empresaAppService)
	    {
		    _empresaAppService = empresaAppService;
	    }

	    // GET: Empresa
        public ActionResult Index()
        {
            return View(_empresaAppService.ObterTodos());
        }
	    // GET: Operadora/Cadastro
	    public ActionResult Cadastro()
	    {
		    return View();
	    }

	    // POST: Operadora/Cadastro
	    [HttpPost]
	    public ActionResult Cadastro(EmpresaViewModel obj)
	    {
		    if (ModelState.IsValid)
		    {
			    _empresaAppService.Adicionar(obj);
			    return RedirectToAction("Index");
		    }
		    return View(obj);
	    }
	}
}