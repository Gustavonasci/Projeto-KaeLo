using Kaelo.DAL;
using Kaelo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kaelo.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ILogger<CatalogoController> _logger;

        public CatalogoController(ILogger<CatalogoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string IsAdmin)
        {
            List<Produto> produtos = ProdutoRepository.ListarProdutos();

            Catalogo model = new()
            {
                Produtos = produtos
            };
            model.
            return View(model);
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
