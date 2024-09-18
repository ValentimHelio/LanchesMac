using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _branchesRepository;

        public LancheController(ILanchesRepository branchesRepository)
        {
            _branchesRepository = branchesRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;
            
            var lanches = _branchesRepository.Lanches;

            ViewBag.Total = "Total de Lanches: ";
            ViewBag.TotalLanches = lanches.Count();

            return View(lanches);
        }
    }
}
