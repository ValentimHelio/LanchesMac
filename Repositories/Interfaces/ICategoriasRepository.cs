using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriasRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
