using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriasRepository
    {
        public readonly AppDBbContext _context;

        public CategoriaRepository(AppDBbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => throw new NotImplementedException();
    }
}
