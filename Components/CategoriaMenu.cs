using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace LanchesMac.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriasRepository _categoriasRepository;

        public CategoriaMenu(ICategoriasRepository categoriasRepository)
        {
            _categoriasRepository = categoriasRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriasRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }


    }
}
