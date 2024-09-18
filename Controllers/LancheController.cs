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
            var lanches = _branchesRepository.Lanches;
            return View(lanches);
        }
    }
}
