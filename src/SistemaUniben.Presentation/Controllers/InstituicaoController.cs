using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Presentation.Controllers
{
    public class InstituicaoController : Controller
    {

	    private readonly IInstituicaoAppService _instituicaoAppService;

	    public InstituicaoController(IInstituicaoAppService instituicaoAppService)
	    {
		    _instituicaoAppService = instituicaoAppService;
	    }

	    // GET: Instituicao
        public ActionResult Index()
        {
            return View(_instituicaoAppService.ObterTodos());
        }

		// GET: Operadora/Cadastro
	    public ActionResult Cadastro()
	    {
		    return View();
	    }

	    // POST: Operadora/Cadastro
	    [HttpPost]
	    public ActionResult Cadastro(InstituicaoViewModel obj)
	    {
		    if (ModelState.IsValid)
		    {
			    _instituicaoAppService.Adicionar(obj);
			    return RedirectToAction("Index");
		    }
		    return View(obj);
	    }
	}
}