using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
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
            
            //var lanches = _branchesRepository.Lanches;

            var LanchesListViewModel = new LancheListViewModel();
            LanchesListViewModel.Lanches = _branchesRepository.Lanches;
            LanchesListViewModel.CategoriaAtual = "Categoria Atual";

            ViewBag.Total = "Total de Lanches: ";
            ViewBag.TotalLanches = LanchesListViewModel.Lanches.Count();

            return View(LanchesListViewModel);
        }
    }
}
