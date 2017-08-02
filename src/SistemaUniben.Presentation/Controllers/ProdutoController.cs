using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaUniben.Application.Interfaces;

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
	}
}